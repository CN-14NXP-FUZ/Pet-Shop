using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class Coupon
    {
        private string id;
        private string name;
        private int discount;
        private DateTime expireAt;

        public Coupon(string id, string name, int discount, DateTime expireAt)
        {
            this.id = id;
            this.name = name;
            this.discount = discount;
            this.expireAt = expireAt;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public DateTime ExpireAt
        {
            get { return expireAt; }
            set { expireAt = value; }
        }
    }
}