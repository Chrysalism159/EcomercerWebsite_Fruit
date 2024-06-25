using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class Favorite
    {
        [Key]
        public string FavoriteID { get; set; }

        public string ProductID { get; set; }

        public string CustomerID { get; set; }


        public virtual Product? ProductNavigation { get; set; }

        public virtual Customer? CustomerNavigation { get; set; }
    }
}