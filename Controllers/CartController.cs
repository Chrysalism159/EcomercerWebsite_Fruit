using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public List<CartDTO> cart => HttpContext.Session.Get<List<CartDTO>>(StaticValueService.Cart_Key) ?? new List<CartDTO>();
        public IActionResult Index()
        {
            double total = 0;
            total = cart.Sum(m => m.Total);
            ViewBag.ShippingFee = 0;
            ViewBag.total = total;
            return View(cart);
        }
        string BillID;
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
                var newProduct = new CartDTO
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
            //ViewBag.cart = cart;
            double total = 0;
            total = cart.Sum(m => m.Total);
            ViewBag.total = total;
            BillID = Guid.NewGuid().ToString();
            var checkOutDTO = new CheckOutDTO
            {
                Carts = cart
            };
            return View(checkOutDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CheckOutAsync(CheckOutDTO model)
        {
            if (ModelState.IsValid)
            {
                var customerId = HttpContext.User.Claims.SingleOrDefault(m => m.Type == StaticValueService.CLAIM_CUSTOMERID).Value;
                if (customerId != null)
                {
                    var customer = new Customer();
                    string billId = BillID;
                    if (model.LikeAccount)
                        customer = _context.customers.SingleOrDefault(p => p.CustomerID.Equals(customerId));
                    var bill = new Bill
                    {
                        BillID = billId,
                        CustomerID = customer.CustomerID,
                        DayBuy = DateTime.Now,
                        DayDelivery = DateTime.Now,
                        CustomerName = customer.CustomerName,
                        CustomerAddress = customer.CustomerAddress,
                        PaymentMethod = "COD",
                        WayDelivery = "J&T EXPRESS",
                        DeliveryFee = 0,
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
                                BillInformationDiscount = 0
                            });
                        }
                        await _context.bills.AddAsync(bill);
                        await _context.billInformation.AddRangeAsync(listbillInformation);
                        await _context.SaveChangesAsync();
                        HttpContext.Session.Set<List<CartDTO>>(StaticValueService.Cart_Key, new List<CartDTO>());
                        return View("Index","Home");
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            return View(cart);
        }
    }
}
