using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class detail_product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //số lượng sản phẩm trong giỏ hàng
            List<CartItem> carts = (List<CartItem>)Application[Global.LIST_CART];
            int currNum = 0;
            CartItem currCart = (Session[Global.YOUR_CART] as CartItem);

            numOfProduct.InnerHtml = "<p>" + 0 + "</p>";
            if (currCart.ListProduct != null && currCart.ListProduct.Count != 0)
            {
                numOfProduct.InnerHtml = "<p>" + currCart.ListProduct.Count() + "</p>";
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
                        if (cart.UserId == Session[Global.USER_ID])
                        {
                            numOfProduct.InnerHtml = "<p>" + cart.ListProduct.Count() + "</p>";
                            Session[Global.YOUR_CART] = cart;
                            break;
                        }
                    }
                }
            }
            infor_user.InnerHtml = info_curr_user;


            // hiện sản phẩm chi tiết
            string product_id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(product_id))
            {
                List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;

                // tìm sản phẩm với ID từ URL
                Product product = products?.Find(p => p.Id == product_id);

                // nếu sản phẩm không tìm thấy
                if (product == null)
                {
                    Response.Redirect("./errorPage/NotFound.html");
                }
                else
                {
                    string htmlProduct = LoadData.LoadProductDetail(product);
                    productDetail.InnerHtml = htmlProduct;
                }
            }
            else
            {
                // nếu product_id không có trong URL
                Response.Redirect("./errorPage/NotFound.html");
            }

        }
    }
}