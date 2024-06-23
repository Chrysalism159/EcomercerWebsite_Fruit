using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class Provider
    {
        [Key]
        public string ProviderID { get; set; }

        public string ProviderName { get; set; } = null!;

        public string Logo { get; set; } = null!;

        public string? ProviderContact { get; set; }

        public string Email { get; set; } = null!;

        public string? ProviderPhone { get; set; }

        public string? ProviderAddress { get; set; }

        public string? ProviderDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}