﻿namespace EcomercerWebsite_Fruit.DataTransferObject
{
    public class dtoProductType
    {
        public string ProductTypeID { get; set; }

        public string ProductTypeName { get; set; } = null!;

        //public string? TenLoaiAlias { get; set; }
        public int ProductAmount {  get; set; }
    }
}