using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class ProductType
    {
        [Key]
        public string ProductTypeID { get; set; }

        public string ProductTypeName { get; set; } = null!;

        public string? ProductTypeDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}