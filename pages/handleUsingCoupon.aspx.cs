using Pet_Shop.model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Pet_Shop.pages
{
    public partial class handleUsingCoupon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string phone = Request.Form["phone"];
            string address = Request.Form["address"];
            string city = Request.Form["city"];
            string district = Request.Form["district"];
            string ward = Request.Form["ward"];
            string paymentMethod = Request.Form["paymentMethod"];

            Session["CheckoutInfo"] = new CheckoutInfo(name, email, phone, address, city, district, ward, paymentMethod);

            string couponCode = Request.Form["couponCode"];
            List<Coupon> coupons = Application[Global.LIST_COUPON] as List<Coupon>;

            Coupon coupon = coupons.FirstOrDefault(c => c.Id == couponCode);
            if (coupon != null)
            {
                CartItem cart = Session[Global.YOUR_CART] as CartItem;
                cart.Coupon = coupon;
            }
            
            Response.Redirect("checkout.aspx");
        }
    }
}