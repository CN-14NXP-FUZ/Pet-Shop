using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class register : System.Web.UI.Page
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



            // register user
            if (IsPostBack)
            {
                try
                {
                    string password = Request.Form["password"];
                    string password_confirm = Request.Form["password_confirm"];
                    string email = Request.Form["email"];
                    string name = Request.Form["name"];
                    string phone = Request.Form["phoneNumber"];

                    if (password != password_confirm)
                    {
                        register_error.InnerHtml = "<p>Mật khẩu không khớp</p>";
                    }
                    else
                    {
                        bool emailExist = false;
                        bool phoneExist = false;
                        List<User> users = (List<User>)Application[Global.LIST_USER];
                        foreach (User user in users)
                        {
                            if (user.Email == email)
                            {
                                emailExist = true;
                                break;
                            }
                            if (user.PhoneNumber == phone)
                            {
                                phoneExist = true;
                                break;
                            }
                        }
                        if (emailExist)
                        {
                            register_error.InnerHtml = "<p>Email đã tồn tại</p>";
                        }
                        else if (phoneExist)
                        {
                            register_error.InnerHtml = "<p>Số điện thoại đã tồn tại</p>";
                        }
                        else
                        {
                            string newID = "user" + email.Split('@')[0] + users.Count();
                            if (name.Length > 20)
                            {
                                name = name.Substring(0, 20);
                            }

                            User user = new User(newID, name, password, email, phone, "");
                            users.Add(user);
                            Application[Global.LIST_USER] = users;

                            Session[Global.USER_NAME] = user.FullName;
                            Session[Global.USER_ID] = user.UserId;
                            Response.Redirect("index.aspx");
                        }
                    }
                } catch 
                {
                    register_error.InnerHtml = "<p>Vui lòng nhập thông tin !</p>";
                }
                

            }
        }
    }
}