namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class ProductTypeDTO
    {
        public Guid ProductTypeID { get; set; }

        public string ProductTypeName { get; set; } = null!;

        //public string? TenLoaiAlias { get; set; }
        public int ProductAmount {  get; set; }
    }
}
