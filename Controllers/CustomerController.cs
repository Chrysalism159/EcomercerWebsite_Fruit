using AutoMapper;
using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace EcomercerWebsite_Fruit.Controllers
{
    public class CustomerController : Controller
    {
        private readonly EcomercerDataContext _context;
        private readonly IMapper _map;

        public CustomerController(EcomercerDataContext context, IMapper map) {
            _context = context;
            _map = map;
        }
        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(dtoCustomer model, IFormFile imagesFile)
        {
            model.CustomerID = Guid.NewGuid().ToString();
            if(ModelState.IsValid)
            {
                try
                {
                    var customer = _map.Map<Customer>(model);
                    customer.RandomKey = MasterServices.GenerateRamdomKey();
                    if (imagesFile != null)
                    {
                        customer.CustomerImages = MasterServices.UploadImages(imagesFile, "CustomerImages");
                    }
                    customer.CustomerPassword = model.CustomerPassword.ToMd5Hash(customer.RandomKey);
                    customer.CustomerIsActive = true;
                    customer.CustomerRole = 0;
                    await _context.AddAsync(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Home");
                }
                catch(Exception ex)
                {
                    var messenger = ex.Message.ToString();
                }
            }
            return View();
        }
        #endregion
        #region Login
        [HttpGet]
        public IActionResult Login(string? returnUrl)
        {
            ViewBag.returnUrl = returnUrl;  
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login (LoginData model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var data = _context.customers.SingleOrDefault(m => m.CustomerEmail.Equals(model.Email));
                    if(data == null)
                        ModelState.AddModelError("Error", "Account is not available!");
                    else
                    {
                        if(!data.CustomerIsActive)
                            ModelState.AddModelError("Error", "Your account is currently blocked!");
                        else
                        {
                            if(model.Password.ToMd5Hash(data.RandomKey) != data.CustomerPassword)
                                ModelState.AddModelError("Error", "Wrong username or password!");
                            else
                            {
                                var claims = new List<Claim> {
                                new Claim(ClaimTypes.Email, data.CustomerEmail),
                                new Claim(ClaimTypes.Name, data.CustomerName),
                                new Claim(StaticValueService.CLAIM_CUSTOMERID, data.CustomerID.ToString()),

								//claim - role động
								new Claim(ClaimTypes.Role, "Customer")
                            };

                                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                                await HttpContext.SignInAsync(claimsPrincipal);

                                if (Url.IsLocalUrl(returnUrl))
                                {
                                    return Redirect(returnUrl);
                                }
                                else
                                {
                                    return Redirect("/");
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {

                }
            }
            return View();
        }
        #endregion
        [Authorize]
        public IActionResult Profile()
        {
            var customerId = HttpContext.User.Claims.SingleOrDefault(m => m.Type == StaticValueService.CLAIM_CUSTOMERID).Value;
            var Oders = _context.bills.Where(m => m.CustomerID.Equals(customerId)).ToList();
            var numberOder = Oders.Count();
            var totalmoney = Oders.Sum(m => m.TotalMoney);
            var Favorites = _context.favorites.Where(m => m.CustomerID.Equals(customerId)).ToList();
            var numberFav = Favorites.Count();
            ViewBag.TotalMoney = totalmoney;
            ViewBag.TotalFav = numberFav;
            ViewBag.TotalOder = numberOder;
            var customer = _map.Map<dtoCustomer>(_context.customers.SingleOrDefault(m=>m.CustomerID.Equals(customerId)));
            return View(customer);
        }

        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Customer/Login");
        }
    }
}
