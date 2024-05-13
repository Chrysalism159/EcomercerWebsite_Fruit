using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
