using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcomercerWebsite_Fruit.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly EcomercerDataContext _context;

        public CartViewComponent(EcomercerDataContext context) => _context = context;
        public IViewComponentResult Invoke()
        {
            //để dùng được session thì cần đăng kí trong program, sau đó khởi tạo extension set và get (SesionExtension)
            var cart = HttpContext.Session.Get<List<CartDTO>>(StaticValueService.Cart_Key) ?? new List<CartDTO>();
                //HttpContext.Session.Get<List<CartDTO>>(StaticValueService.Cart_Key) ?? new List<CartDTO>();
            return View(new TotalCartDTO
            {
                Amount = cart.Sum(m=>m.ProductAmount),
                Total = cart.Sum(m => m.Total)
            });
        }
    }
}
