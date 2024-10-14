using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class Order
    {
        public int OrderId { get; set; } 
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; } 
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public List<OrderItem> OrderItems { get; set; } 
    }

}