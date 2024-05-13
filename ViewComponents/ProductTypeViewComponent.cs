using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcomercerWebsite_Fruit.ViewComponents
{
    public class ProductTypeViewComponent : ViewComponent
    {
        private readonly EcomercerDataContext _context;

        public ProductTypeViewComponent(EcomercerDataContext context) => _context = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = _context.productTypes.Select(m => new ProductTypeDTO
            {
                ProductTypeID = m.ProductTypeID,
                ProductTypeName = m.ProductTypeName,
                ProductAmount = m.Products.Count()
                
            }).OrderBy(m => m.ProductTypeName);
            return View(data);
        }
    }
}
