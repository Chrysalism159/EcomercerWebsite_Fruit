using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;

namespace EcomercerWebsite_Fruit.Controllers
{
    public class CartController : Controller
    {
        private readonly EcomercerDataContext _context;

        public CartController(EcomercerDataContext context)
        {
            _context = context;
        }
        public List<dtoCart> cart => HttpContext.Session.Get<List<dtoCart>>(StaticValueService.Cart_Key) ?? new List<dtoCart>();
        public IActionResult Index()
        {
            double total = 0;
            total = cart.Sum(m => m.Total);
            ViewBag.ShippingFee = 0;
            ViewBag.total = total;
            return View(cart);
        }
        double ShippingFee = 0;
        public IActionResult UpdateShippingFee(double value)
        {
            ShippingFee = value;
            return RedirectToAction("Index");
        }
        public IActionResult AddToCart(string id)
        {
            var shopbag = cart;
            var product = shopbag.SingleOrDefault(m => m.ProductID.Equals(id));
            if (product != null)
            {
                product.ProductAmount++;
            }
            else
            {
                var data = _context.products.SingleOrDefault(m => m.ProductID.Equals(id));
                if (data == null)
                {
                    TempData["Message"] = $"Không thấy sản phẩm có mã {id}";
                    return Redirect("/404");
                }
                var newProduct = new dtoCart
                {
                    ProductID = data.ProductID,
                    ProductName = data.ProductName,
                    ProductImage = data.ProductImage,
                    ProductCost = (double)data.ProductCost,
                    ProductAmount = 1
                };
                shopbag.Add(newProduct);
            }
            HttpContext.Session.Set(StaticValueService.Cart_Key, shopbag);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveItem(string id)
        {
            var shopbag = cart;
            var product = shopbag.SingleOrDefault(m => m.ProductID.Equals(id));
            if (product != null)
            {
                TempData["Message"] = $"Không thấy sản phẩm có mã {id}";
                return Redirect("/404");
            }
            else
            {

                shopbag.Remove(product);
            }
            HttpContext.Session.Set(StaticValueService.Cart_Key, shopbag);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult CheckOut()
        {
            if (cart.Count == 0)
                return RedirectToAction("Index");
            

            ViewBag.Cart = cart;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CheckOut(dtoCheckOut model)
        {
            if (ModelState.IsValid)
            {
                var customerId = HttpContext.User.Claims.SingleOrDefault(m => m.Type == StaticValueService.CLAIM_CUSTOMERID).Value;
                if (customerId != null)
                {
                    var customer = new Customer();
                    string billId = Guid.NewGuid().ToString(); 
                    if (model.LikeAccount)
                        customer = _context.customers.SingleOrDefault(p => p.CustomerID.Equals(customerId));
                    double total = cart.Sum(m => m.Total);
                    double tax = total * 0.08;
                    var bill = new Bill
                    {
                        BillID = billId,
                        CustomerID = customer.CustomerID,
                        DayBuy = DateTime.Now,
                        DayDelivery = DateTime.Now,
                        CustomerName = customer.CustomerName,
                        CustomerAddress = customer.CustomerAddress,
                        PaymentMethod = model.PaymentMethod,
                        WayDelivery = "J&T EXPRESS",
                        DeliveryFee = model.ShippingFee,
                        Tax = tax,
                        TotalMoney = total + tax + model.ShippingFee,
                        deliveryStatement = DeliveryStatement.ToPay

                    };
                    await _context.Database.BeginTransactionAsync();
                    try
                    {
                        await _context.Database.CommitTransactionAsync();
                        List<BillInformation> listbillInformation = new List<BillInformation>();
                        foreach (var item in cart)
                        {
                            
                            listbillInformation.Add(new BillInformation
                            {
                                BillInformationID = Guid.NewGuid().ToString(),
                                BillID = billId,
                                ProductID = item.ProductID,
                                ProductCost = item.ProductCost,
                                NumberBuyPerProduct = item.ProductAmount,
                                BillInformationDiscount = 0
                            });
                            Product product = await _context.products.SingleOrDefaultAsync(m => m.ProductID.Equals(item.ProductID));
                            product.ProductNumberAccess = product.ProductNumberAccess - item.ProductAmount;
                            _context.products.Update(product);
                        }
                        await _context.bills.AddAsync(bill);
                        await _context.billInformation.AddRangeAsync(listbillInformation);
                        await _context.SaveChangesAsync();
                        HttpContext.Session.Set<List<dtoCart>>(StaticValueService.Cart_Key, new List<dtoCart>());
                        return RedirectToAction("Index", "Home");
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            return View();
        }
    }
}
