namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class ProductDTO
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; } = null!;

        //public string? TenAlias { get; set; }

        public string? ProductTypeName { get; set; }

        public string? ProductUnit { get; set; }

        public double? ProductCost { get; set; }

        public string? ProductImage { get; set; }

        public DateTime ProductDate { get; set; }

        public double ProductDiscount { get; set; }

        public int ProductNumberAccess { get; set; }

        public string? ProductDescription { get; set; }

        public string? ProviderName { get; set; }
    }
}
