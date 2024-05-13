using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class Favorite
    {
        [Key]
        public Guid FavoriteID { get; set; }

        public Guid ProductID { get; set; }

        public Guid CustomerID { get; set; }

        public DateTime? PickDay { get; set; }

        public string? FavoriteDescription { get; set; }

        public virtual Product? ProductNavigation { get; set; }

        public virtual Customer? CustomerNavigation { get; set; }
    }
}