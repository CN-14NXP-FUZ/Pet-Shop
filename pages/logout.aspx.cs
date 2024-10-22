using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Session.Remove(Global.USER_ID);
            Session.Remove(Global.USER_NAME);
            Session[Global.YOUR_CART] = new CartItem("cart-" + (Application[Global.LIST_CART] as List<CartItem>).Count());

            Response.Redirect("index.aspx");
        }
    }
}