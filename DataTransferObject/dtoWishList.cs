namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class dtoWishList
    {
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductImage { get; set; }
        public double? ProductCost { get; set; }
        public bool IsAvailable { get; set; }
    }
}
