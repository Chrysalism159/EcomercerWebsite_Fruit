using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class Review
    {
        [Key]
        public string ReviewID { get; set; }
        public string CustomerID { get; set; }
        public string ProductID { get; set; }
        public string? Content { get; set; }
        public DateTime DayReview {  get; set; }
        public virtual Customer customer { get; set; } = null!;
        public virtual Product product { get; set; } = null!;

    }
}
