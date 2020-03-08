using System;

namespace eCommerceDotNetCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Product_Image { get; set; }
        public double Product_Price { get; set; }
        public double Product_Shipping_Cost { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}