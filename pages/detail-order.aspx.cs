using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class detail_order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //số lượng sản phẩm trong giỏ hàng
            List<CartItem> carts = (List<CartItem>)Application[Global.LIST_CART];
            int currNum = 0;
            CartItem currCart = (Session[Global.YOUR_CART] as CartItem);

            numOfProduct.InnerHtml = "<p>" + 0 + "</p>";
            if (currCart != null)
            {
                if (currCart.ListProduct != null && currCart.ListProduct.Count != 0)
                {
                    numOfProduct.InnerHtml = "<p>" + currCart.ListProduct.Count() + "</p>";
                }
            }else
            {
                Session[Global.YOUR_CART] = new CartItem("cart-" + (Application[Global.LIST_CART] as List<CartItem>).Count());
            }
            


            // giao diện khi đã đăng nhập và chưa đăng nhập
            string customerName = "";
            string info_curr_user = "<div class='login'><a href='login.aspx'>Đăng nhập</a><p>|</p><a href='register.aspx'>Đăng ký</a></div>";
            string user_id = "";
            if (Session[Global.USER_NAME] != null && Session[Global.USER_ID] != null && Session[Global.USER_NAME] != "" && Session[Global.USER_ID] != "")
            {
                customerName = Session[Global.USER_NAME].ToString();
                user_id = Session[Global.USER_ID].ToString();
                info_curr_user = LoadData.LoadUser(customerName, user_id);

                if (carts != null)
                {
                    (Session[Global.YOUR_CART] as CartItem).UserId = Session[Global.USER_ID].ToString();

                    foreach (CartItem cart in carts)
                    {
                        if (cart.UserId == Session[Global.USER_ID] && cart.WasOrder == false)
                        {
                            numOfProduct.InnerHtml = "<p>" + cart.ListProduct.Count() + "</p>";
                            Session[Global.YOUR_CART] = cart;
                            currCart = cart;
                            break;
                        }
                    }
                }
            }
            infor_user.InnerHtml = info_curr_user;



            if (Session[Global.USER_ID] != null && Session[Global.USER_ID].ToString() != "")
            {
                string userId = Session[Global.USER_ID].ToString();
                List<Order> orders = (List<Order>)Application[Global.LIST_ORDER];

                if (orders != null)
                {
                    List<Order> userOrders = orders.Where(o => o.UserId == userId).ToList();

                    string htmlOrder = LoadOrder.LoadOrderDetail(
                        userOrders,
                        Application[Global.LIST_PRODUCT] as List<Product>,
                        Application[Global.LIST_CART] as List<CartItem>);

                    list_info_order.InnerHtml = htmlOrder;
                }
            }
        }
    }
}