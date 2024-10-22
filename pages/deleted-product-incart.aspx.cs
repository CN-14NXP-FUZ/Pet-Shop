using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class deleted_product_incart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.Form["id"];
                int quantity = int.Parse(Request.Form["quantity"]);
                CartItem carts = Session[Global.YOUR_CART] as CartItem;
                Dictionary<string, int> listProduct = carts.ListProduct as Dictionary<string, int>;
                listProduct.Remove(id);

                List<Product> products = Application[Global.LIST_PRODUCT] as List<Product>;
                foreach (Product product in products)
                {
                    if (product.Id == id)
                    {
                        product.Stock += quantity;
                        break;
                    }
                }
                Application[Global.LIST_PRODUCT] = products;
            }
            catch
            {
                Response.Write("Error");
            }
            Response.Redirect("cart.aspx");
        }
    }
}