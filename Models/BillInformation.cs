using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class BillInformation
    {
        [Key]
        public string BillInformationID { get; set; }

        public string BillID { get; set; }

        public string ProductID { get; set; }

        public double ProductCost { get; set; }
        
        public int NumberBuyPerProduct { get; set; }
        //public int BillInformationNumber { get; set; }

        public double BillInformationDiscount { get; set; }

        public virtual Bill BillNavigation { get; set; } = null!;

        public virtual Product ProductNavigation { get; set; } = null!;
    }
}