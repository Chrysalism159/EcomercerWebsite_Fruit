using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class ProductType
    {
        [Key]
        public Guid ProductTypeID { get; set; }

        public string ProductTypeName { get; set; } = null!;

        //public string? TenLoaiAlias { get; set; }

        public string? ProductTypeDescription { get; set; }

        //public string? ProductTypeImange { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}