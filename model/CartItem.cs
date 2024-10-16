using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class CartItem
    {
        private string id;
        private string userId;
        private Dictionary<string, int> listProduct;
        private Coupon coupon;
       
        public CartItem(string id, Dictionary<string, int> listProduct, string userId )
        {
            this.id = id;
            this.listProduct = listProduct;
            this.userId = userId;
        }
        public CartItem(string id, Dictionary<string, int> listProduct)
        {
            this.id = id;
            this.listProduct = listProduct;
        }
        public CartItem(string id)
        {
            this.id = id;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public Dictionary<string, int> ListProduct
        {
            get { return listProduct; }
            set { listProduct = value; }
        }

        public Coupon Coupon
        {
            get { return coupon; }
            set { coupon = value; }
        }
    }

}