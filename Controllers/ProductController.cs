using AutoMapper;
using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomercerWebsite_Fruit.Controllers
{
    public class ProductController : Controller
    {
        private readonly EcomercerDataContext _context;
        private readonly IMapper _map;

        public ProductController(EcomercerDataContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }
        public IActionResult Index(string? type, int? page)
        {
            var productList = _context.products.AsQueryable();
            int pagenumber = (page ?? 1);
            if (type != null)
            {
                productList = productList.Where(h => h.ProductTypeID == type);
            }
            var data = productList.Select(h => new ProductDTO
            {
                ProductID = h.ProductID,
                ProductName = h.ProductName,
                ProductImage = h.ProductImage ?? "",
                ProductCost = h.ProductCost ?? 0,
                ProductDescription = h.ProductDescription ?? "",
                ProviderName = h.ProviderNavigation.ProviderName,
                ProductTypeName = h.ProductTypeNavigation.ProductTypeName
            });
            int pageSize = 9;
            int totalPage = data.Count() / pageSize;
            ViewBag.total = data.Count();
            ViewBag.type = type;
            return View(PaginatedListServices<ProductDTO>.CreateAsync(data.AsNoTracking(), page ?? 1, pageSize));
        }
        public IActionResult Detail(string id)
        {
             
            if(id != null)
            {
                var data = _context.products.SingleOrDefault(h => h.ProductID.Equals( id));
                if(data == null)
                {
                    return NotFound();
                }
                else
                {
                    var product = _map.Map<ProductDTO>(data);
                    List<Product> relatedDatas = _context.products.Where(m => m.ProductCost <= data.ProductCost).ToList();
                    List<ProductDTO> relatedProducts = _map.Map<List<ProductDTO>>(relatedDatas);
                    ViewBag.relatedProducts = relatedProducts;
                    return View(product);
                }
            }
            return View();
        }
    }
}
