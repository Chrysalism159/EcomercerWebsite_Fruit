namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class CartDTO
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double ProductCost { get; set; }
        public double ShippingFee { get; set; }
        public int ProductAmount { get; set; }
        public double Total => ProductCost * ProductAmount + ShippingFee; 

    }
    public class TotalCartDTO
    {
        public int Amount { get; set; }
        public double Total { get; set; }

    }
}
