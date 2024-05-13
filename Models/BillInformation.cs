using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class BillInformation
    {
        [Key]
        public Guid BillInformationID { get; set; }

        public Guid BillID { get; set; }

        public Guid ProductID { get; set; }

        public double ProductCost { get; set; }

        public int BillInformationNumber { get; set; }

        public double BillInformationDiscount { get; set; }

        public virtual Bill BillNavigation { get; set; } = null!;

        public virtual Product ProductNavigation { get; set; } = null!;
    }
}