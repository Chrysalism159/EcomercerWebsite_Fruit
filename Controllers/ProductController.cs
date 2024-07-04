using AutoMapper;
using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;

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
        public IActionResult Index(string? type, int? page, string? sort)
        {
            var productList = _context.products.AsQueryable();
            int pagenumber = (page ?? 1);
            if (type != null)
            {
                productList = productList.Where(h => h.ProductTypeID == type);
            }
            var data = productList.Select(h => new dtoProduct
            {
                ProductID = h.ProductID,
                ProductName = h.ProductName,
                ProductImage = h.ProductImage ?? "",
                ProductCost = h.ProductCost ?? 0,
                ProductDescription = h.ProductDescription ?? "",
                ProviderName = h.ProviderNavigation.ProviderName,
                ProductTypeName = h.ProductTypeNavigation.ProductTypeName
            });
            switch (sort)
            {
                case "ascPrice":
                    data = data.OrderBy(s => s.ProductCost);
                    break;
                case "descPrice":
                    data = data.OrderByDescending(s => s.ProductCost);
                    break;
                case "bestSelling":
                    data = data.OrderByDescending(s => s.ProductNumberAccess);
                    break;
                default:
                    data = data.OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 9;
            int totalPage = data.Count() / pageSize;
            ViewBag.total = data.Count();
            ViewBag.type = type;
            ViewBag.sort = sort;
            return View(PaginatedListServices<dtoProduct>.CreateAsync(data.ToList(), page ?? 1, pageSize));
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
                    var product = _map.Map<dtoProduct>(data);
                    List<dtoReview> relatedComment = _map.Map<List<dtoReview>>(_context.reviews.Where(m=>m.ProductID == id));
                    List<Product> relatedDatas = _context.products.Where(m => m.ProductCost <= data.ProductCost).ToList();
                    List<dtoProduct> relatedProducts = _map.Map<List<dtoProduct>>(relatedDatas);
                    List<dtoCustomer> relatedCustomers = _map.Map<List<dtoCustomer>>(_context.customers.ToList());
                    foreach(var review in relatedComment)
                    {
                        var customer = relatedCustomers.SingleOrDefault(m=>m.CustomerID == review.CustomerID);
                        review.CustomerName = customer.CustomerName;
                        review.CustomerAvt = customer.CustomerImages;
                    }
                    ViewBag.relatedProducts = relatedProducts;
                    ViewBag.relatedReview = relatedComment;
                    return View(product);
                }
            }
            return View();
        }
        public IActionResult Search(string? value, int? page)
        {
            var productList = _context.products.AsQueryable();
            int pagenumber = (page ?? 1);
            var data = _map.Map<List<dtoProduct>>(productList.Where(m=>m.ProductName.Contains(value)));
            int pageSize = 9;
            int totalPage = data.Count() / pageSize;
            ViewBag.total = data.Count();
            ViewBag.value = value;
            return View(PaginatedListServices<dtoProduct>.CreateAsync(data, page ?? 1, pageSize));
        }
        [Authorize]
        public IActionResult WishList ()
        {
            var customerId = HttpContext.User.Claims.SingleOrDefault(m => m.Type == StaticValueService.CLAIM_CUSTOMERID).Value;
            List<dtoWishList> wishLists = new List<dtoWishList>();
            
            if(customerId != null)
            {
                var list = _context.favorites.Where(m=>m.CustomerID.Equals(customerId)).ToList();
                foreach(var item in list)
                {
                    dtoProduct product = _map.Map<dtoProduct>(_context.products.SingleOrDefault(h => h.ProductID.Equals(item.ProductID)));
                    dtoWishList LikeProduct;
                    if (product.ProductNumberAccess > 0)
                    {
                        LikeProduct = new dtoWishList
                        {
                            ProductID = item.ProductID,
                            ProductImage = product.ProductImage,
                            ProductName = product.ProductName,
                            ProductCost = product.ProductCost,
                            IsAvailable = true
                        };
                    }
                    else
                        LikeProduct = new dtoWishList
                        {
                            ProductID = item.ProductID,
                            ProductImage = product.ProductImage,
                            ProductName = product.ProductName,
                            ProductCost = product.ProductCost,
                            IsAvailable = false
                        };
                    wishLists.Add(LikeProduct);
                }
                
            }
            return View(wishLists);
        }
        [Authorize]
        public IActionResult AddToWishList(string id)
        {
            var customerId = HttpContext.User.Claims.SingleOrDefault(m => m.Type == StaticValueService.CLAIM_CUSTOMERID).Value;
            if (id != null)
            {
                var wishlist = _context.favorites.Where(m=>m.CustomerID.Equals(customerId)).ToList();
                var check = wishlist.SingleOrDefault(m => m.ProductID.Equals(id));
                if(check != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Favorite newFavorite = new Favorite
                    {
                        CustomerID = customerId,
                        FavoriteID = Guid.NewGuid().ToString(),
                        ProductID = id
                    };
                    _context.favorites.Add(newFavorite);
                    _context.SaveChanges();
                    return RedirectToAction("WishList", "Product");
                }

            }
            return View();
        }
        [Authorize]
        public IActionResult RemoveFromWishList(string id)
        {
            var customerId = HttpContext.User.Claims.SingleOrDefault(m => m.Type == StaticValueService.CLAIM_CUSTOMERID).Value;
            if (id != null)
            {
                var wishList = _context.favorites.Where(m=>m.CustomerID.Equals(customerId)).ToList();
                var product = wishList.SingleOrDefault(m => m.ProductID.Equals(id));
                if (product == null)
                {
                    TempData["Message"] = $"Không thấy sản phẩm có mã {id}";
                    return Redirect("/404");
                }
                else
                {

                    _context.favorites.Remove(product);
                    _context.SaveChanges();
                    return RedirectToAction("WishList", "Product");
                }

            }
            return View();
        }

    }
}
