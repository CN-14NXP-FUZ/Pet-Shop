using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; } 
        public int OrderId { get; set; } 
        public int ProductId { get; set; } 
        public string ProductType { get; set; } 
        public int Quantity { get; set; } 
        public decimal Price { get; set; } 
    }

}