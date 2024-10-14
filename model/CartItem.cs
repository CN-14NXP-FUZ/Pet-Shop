using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class CartItem
    {
        public string CartItemId { get; set; } 
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public string ProductType { get; set; } 
        public int Quantity { get; set; } 
        public decimal Price { get; set; } 
    }

}