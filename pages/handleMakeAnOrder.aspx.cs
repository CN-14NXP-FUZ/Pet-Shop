using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class handleMakeAnOrder : System.Web.UI.Page
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

            bool checkUserExit = false;
            List<User> users = (List<User>)Application[Global.LIST_USER];
            foreach (User user in users)
            {
                if (user.UserId == Session[Global.USER_ID].ToString())
                {
                    checkUserExit = true;
                    break;
                }
            }
            if (checkUserExit && Session[Global.USER_ID] != null && Session[Global.USER_ID].ToString() != "")
            {

                CartItem currentCart = Session[Global.YOUR_CART] as CartItem;

                List<CartItem> carts = (List<CartItem>)Application[Global.LIST_CART];
                // check if id in cart has been existin list cart => we will make a new cart\
                bool checkCartExist = false;
                foreach (CartItem cart in carts)
                {
                    if (cart.Id == currentCart.Id)
                    {
                        checkCartExist = true;
                        break;
                    }
                }
                if (checkCartExist)
                {
                    currentCart.Id = "cart-" + (carts.Count + 1);
                }
                currentCart.WasOrder = true;
                carts.Add(currentCart);

                List<Order> orders = (List<Order>)Application[Global.LIST_ORDER];

                Order newOrder = new Order("order-item-" + (orders.Count + 1), Session[Global.USER_ID].ToString(), currentCart.Id, "pending", paymentMethod, DateTime.Now, Session["CheckoutInfo"] as CheckoutInfo);

                orders.Add(newOrder);

                Application[Global.LIST_ORDER] = orders;

                // reset cart
                Session.Remove(Global.YOUR_CART);
                Session[Global.YOUR_CART] = new CartItem("cart-" + ((Application[Global.LIST_CART] as List<CartItem>).Count + 1));

                Response.Redirect("detail-order.aspx");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}