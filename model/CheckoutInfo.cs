using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class CheckoutInfo
    {
        private string name;
        private string email;
        private string phone;
        private string address;
        private string city;
        private string district;
        private string ward;
        private string paymentMethod;
        
        public CheckoutInfo(string name, string email, string phone, string address, string city, string district, string ward, string paymentMethod)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.city = city;
            this.district = district;
            this.ward = ward;
            this.paymentMethod = paymentMethod;
        }
        public CheckoutInfo()
        {
            this.name = "";
            this.email = "";
            this.phone = "";
            this.address = "";
            this.city = "";
            this.district = "";
            this.ward = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string District
        {
            get { return district; }
            set { district = value; }
        }

        public string Ward
        {
            get { return ward; }
            set { ward = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }



    }
}