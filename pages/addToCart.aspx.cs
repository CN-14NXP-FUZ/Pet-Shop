using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class addToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productId = Request.Form["id"];
            int quantity = int.Parse(Request.Form["quantity"]);
            List<Product> products = Application[Global.LIST_PRODUCT] as List<Product>;
            CartItem cartItem = (Session[Global.YOUR_CART] as CartItem);
            if (cartItem.WasOrder)
            {
                cartItem = new CartItem("cart-" + ((Application[Global.LIST_CART] as List<CartItem>).Count + 1));
            }
            int maxQuantity = 0;
            foreach (Product product in products)
            {
                if (product.Id == productId)
                {
                    maxQuantity = product.Stock;
                    if (quantity > 0 && quantity <= maxQuantity)
                    {
                        Dictionary<string, int> listPro = cartItem.ListProduct as Dictionary<string, int>;
                        if (listPro == null)
                        {
                            listPro = new Dictionary<string, int>();
                        }

                        if (listPro.ContainsKey(productId))
                        {
                            listPro[productId] += quantity;
                        }
                        else
                        {
                            listPro.Add(productId, quantity);
                        }

                        (Session[Global.YOUR_CART] as CartItem).ListProduct = listPro;

                        maxQuantity -= quantity;
                        product.Stock = maxQuantity;
                    }
                    break;
                }
            }
            Response.Redirect("detail-product.aspx?id=" + productId);

        }
    }
}