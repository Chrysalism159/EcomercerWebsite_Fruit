﻿namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class dtoCheckOut
    {
        public bool LikeAccount {  get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phonenumber { get; set; }
        public double ShippingFee { get; set; }
        public string? PaymentMethod { get; set; }

        //public List<CartDTO>? Carts { get; set; }
    }
}