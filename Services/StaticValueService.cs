using System.ComponentModel.DataAnnotations;

namespace EcomercerWebsite_Fruit.Services
{
    public class StaticValueService
    {
        public static string Cart_Key = "Shopping Cart";
        public static string CLAIM_CUSTOMERID = "CustomerID";
        
    }
    public class DeliveryStatement
    {
        private int idDS;
        private string? nameDS;
        public static DeliveryStatement ToPay = new DeliveryStatement { idDS = 0, nameDS = "Wait to confirmation" };
        public static DeliveryStatement ToShip = new DeliveryStatement { idDS = 1, nameDS = "Wait to delivery" };
        public static DeliveryStatement ToReceive = new DeliveryStatement { idDS = 2, nameDS = "Wait to reception" };
    }
    
}
