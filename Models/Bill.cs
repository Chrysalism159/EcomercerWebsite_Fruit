using EcomercerWebsite_Fruit.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomercerWebsite_Fruit.Models
{
    public class Bill
    {
        [Key]
        public string BillID { get; set; }

        public string? CustomerID { get; set; }

        public DateTime DayBuy { get; set; }

        public DateTime? DayDelivery { get; set; }

        public string? CustomerName { get; set; }

        public string CustomerAddress { get; set; } = null!;

        public string PaymentMethod { get; set; } = null!;

        public string WayDelivery { get; set; } = null!;

        public double DeliveryFee { get; set; }
        [NotMapped]
        public DeliveryStatement? deliveryStatement { get; set; }

        //public string? MaNv { get; set; }

        public string? Notes { get; set; }

        public virtual ICollection<BillInformation> BillInformations { get; set; } = new List<BillInformation>();

        public virtual Customer CustomerNavigation { get; set; } = null!;

        //public virtual NhanVien? MaNvNavigation { get; set; }
        [NotMapped]
        public virtual StatementInformation StatementInformationNavigation { get; set; } = null!;

        //public static implicit operator Bill(Bill v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}