using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<User> users = (List<User>)Application[Global.LIST_USER];
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

            if (IsPostBack)
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    bool notfound = true;
                    foreach (User user in users)
                    {
                        string em = user.Email;
                        string pas = user.Password;
                        if (user.Email == username && user.Password == password)
                        {
                            notfound = false;
                            Session[Global.USER_NAME] = user.FullName;
                            Session[Global.USER_ID] = user.UserId;
                            Response.Redirect("index.aspx");
                            break;
                        }
                    }
                    if (notfound)
                    {
                        login_error.InnerHtml = $@"<p style='color:red; margin-bottom: 10px; text-align: center'>Sai tên đăng nhập hoặc mật khẩu</p>";
                    }
                }
                else
                {
                    login_error.InnerHtml = "<p style='color:red; margin-bottom: 10px; text-align: center'>Vui lòng nhập tên đăng nhập và mật khẩu.</p>";
                }

            }


        }
    }
}