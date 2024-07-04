namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class dtoReview
    {
        public string ReviewID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAvt { get; set; }
        public string? Content { get; set; }
        public DateTime DayReview { get; set; }
    }
}
