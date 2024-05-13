namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class CustomerDTO
    {
        public Guid CustomerID { get; set; }

        public string? CustomerPassword { get; set; }

        public string CustomerName { get; set; } = null!;

        public bool CustomerGender { get; set; }

        public DateTime CustomerDoB { get; set; }

        public string? CustomerAddress { get; set; }

        public string? CustomerPhone { get; set; }

        public string CustomerEmail { get; set; } = null!;

        public string? CustomerImages { get; set; }

        public bool CustomerIsActive { get; set; }

        public int CustomerRole { get; set; }

        public string? RandomKey { get; set; }
    }
}
