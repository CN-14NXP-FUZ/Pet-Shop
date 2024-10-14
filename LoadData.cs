using Pet_Shop.model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using static System.Collections.Specialized.BitVector32;

namespace Pet_Shop
{
    public class LoadData
    {

        public static string LoadProduct(string type, int maxItem, List<Product> listProduct, string nameTitle)
        {
            string htmls = "";

            if (type == "sale")
            {
                htmls += $@"<section class='product-sale'>
                            <div class='title-section'><p>{nameTitle}</p></div>
                            <div class='list-product'>";
            }else if (type == "new")
            {
                htmls += $@"<section class='product-new'>
                            <div class='title-section'><p>{nameTitle}</p></div>
                            <div class='list-product'>";
            }
            int time = maxItem;
            foreach (Product product in listProduct)
            {
                if (product.TypeProduct == type)
                {

                    string item = $@"
                    <div class='inner-item'>
                        <div class='item'>
                            <img src='" + product.ImageUrl + $@"' alt=''>
                            <p class='name-product'>" + product.Name + $@"</p>
                            <div class='price'>
                                <p class='newPrice'>Giá:" + (product.Price - (product.Price * product.Discount / 100)) + $@"đ</p>
                                <p class='oldPrice'>Giá: " + product.Price + $@"</p>
                            </div>
                            <a class='btn-buy' href='detail-product.aspx?id={product.Id}'>
                                Chọn Mua
                            </a>
                        </div>
                    </div>";

                    htmls += item;
                    time--;
                    if (time == 0)
                    {
                        break;
                    }
                }
            }

            if (type == "sale")
            {
                htmls += "</div></section>"; 
            }

            return htmls; 
        }





        public static string LoadUser(string username, string id_user)
        {
            string html = "";
            if (username == null || username=="" || id_user == null || id_user=="")
            {
                html = $@"<div class='login'>
                    <a href='login.aspx'>Đăng nhập</a>
                    <p>|</p>
                    <a href='register.aspx'>Đăng ký</a>
                </div>";
                
            }
            else
            {
                html = $@"<a href='/user/profile.aspx?id=${id_user}'>{username}</a>
                        <a href='logout.aspx'><i class=""fa-solid fa-arrow-right-from-bracket""></i></a>";
            }

            return html;
        }

    }
}