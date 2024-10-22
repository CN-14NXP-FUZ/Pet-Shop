﻿using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class forgot_password : System.Web.UI.Page
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
                        if (cart.UserId == Session[Global.USER_ID] && cart.WasOrder == false)
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
                try
                {
                    string email = Request.Form["email"];
                    string phone = Request.Form["phoneNumber"];
                    string password = Request.Form["newPassword"];
                    string password_confirm = Request.Form["newPassword_confirm"];
                    if (password != password_confirm)
                    {
                        reset_error.InnerHtml = "<p style='text-align: center; color: red'>Mật khẩu không khớp!</p>";

                    }else
                    {
                        bool existUser = false;
                        List<User> users = (List<User>)Application[Global.LIST_USER];
                        foreach (User user in users)
                        {
                            if (user.Email == email && user.PhoneNumber == phone)
                            {
                                existUser = true;
                                break;
                            }

                        }
                        if (existUser)
                        {
                            foreach (User user in users)
                            {
                                if (user.Email == email && user.PhoneNumber == phone)
                                {
                                    user.Password = password;
                                    reset_error.InnerHtml = "<p style='text-align: center; color: green'>Đổi mật khẩu thành công !</p>";

                                    ClientScript.RegisterStartupScript(this.GetType(), "redirectScript",
                                        "setTimeout(function(){ window.location.href = 'login.aspx'; }, 3000);", true);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            reset_error.InnerHtml = "<p style='text-align: center; color: red'>Thông tin không chính xác !</p>";
                        }
                    }
                } catch
                {
                    reset_error.InnerHtml = "<p style='text-align: center; color: red'>Thông tin không chính xác !</p>";
                }



            }
        }
    }
}