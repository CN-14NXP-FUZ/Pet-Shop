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
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            // giao diện khi đã đăng nhập và chưa đăng nhập
            string customerName = "";
            string info_curr_user = "<div class='login'><a href='login.aspx'>Đăng nhập</a><p>|</p><a href='register.aspx'>Đăng ký</a></div>";
            string user_id = "";
            if (Session[Global.USER_NAME] != null && Session[Global.USER_ID] != null && Session[Global.USER_NAME] != "" && Session[Global.USER_ID] != "")
            {
                customerName = Session[Global.USER_NAME].ToString();
                user_id = Session[Global.USER_ID].ToString();
                info_curr_user = LoadData.LoadUser(customerName, user_id);
            }
            infor_user.InnerHtml = info_curr_user;


            // hiện sản phẩm chi tiết
            string product_id = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(product_id))
            {
                List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;

                Product product = products?.Find(p => p.Id == product_id);

                if (product == null)
                {
                    Response.Redirect("./errorPage/NotFound.html");
                }
                else
                {
                    // xử lý tiếp nếu sản phẩm tồn tại
                    // Ví dụ: hiển thị thông tin chi tiết sản phẩm
                    // productName.InnerHtml = product.Name;
                    // productPrice.InnerHtml = product.Price.ToString();
                }
            }
            else
            {
                Response.Redirect("./errorPage/NotFound.html");
            }

        }
    }
}