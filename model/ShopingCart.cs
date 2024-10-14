using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class ShoppingCart
    {
        private string cartId;
        private string customerId;
        private List<CartItem> cartItems;

        public ShoppingCart(string cartId, string customerId, List<CartItem> cartItems)
        {
            this.cartId = cartId;
            this.customerId = customerId;
            this.cartItems = cartItems;
        }
        public string CartId { get; set; } 
        public int CustomerId { get; set; } 
        public List<CartItem> CartItems { get; set; }
    }

}