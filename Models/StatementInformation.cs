using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class StatementInformation
    {
        [Key]
        public Guid StatementID { get; set; }

        public string StatementName { get; set; } = null!;

        public string? StatementDescription { get; set; }

        public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
    }
}
