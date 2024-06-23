using System;
using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Models
{
    public class Product
    {
        [Key]
        public string? ProductID { get; set; }

        public string ProductName { get; set; } = null!;

        //public string? TenAlias { get; set; }

        public string ProductTypeID { get; set; }

        public string? ProductUnit { get; set; }

        public double? ProductCost { get; set; }

        public string? ProductImage { get; set; }

        public DateTime ProductDate { get; set; }

        public double ProductDiscount { get; set; }

        public int ProductNumberAccess { get; set; }

        public string? ProductDescription { get; set; }

        public string ProviderID { get; set; }
        //public virtual ICollection<BanBe> BanBes { get; set; } = new List<BanBe>();

        public virtual ICollection<BillInformation> BillInformations { get; set; } = new List<BillInformation>();

        public virtual ProductType ProductTypeNavigation { get; set; } = null!;

        public virtual Provider ProviderNavigation { get; set; } = null!;

        public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}