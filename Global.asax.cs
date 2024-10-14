using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Pet_Shop
{
    public class Global : System.Web.HttpApplication
    {
        public const string LIST_USER = "LIST_INFO_CUSTOMER";
        public const string LIST_PET = "LIST_PET";
        public const string LIST_SHOPPING_CART = "LIST_SHOPPING_CART";
        public const string USER_NAME = "USER_NAME";
        public const string USER_ID = "USER_ID";
        public const string LIST_PRODUCT  = "LIST_PRODUCT";

        protected void Application_Start(object sender, EventArgs e)
        {
            Application[Global.LIST_USER] = new List<User>
            {
                new User("user-ha", "Hecker", "hecker", "hecker@gmail.com", "123456789", "Ethurium"),
                new User("user-va", "Skupika", "skut", "skut@gmail.com", "123455612", "Notherland")
            };


            Application[Global.LIST_PRODUCT] = new List<Product>
            {
                new Product("product-1", "Natural Core Thức ăn hữu cơ cho mèo con", "Thức ăn cho mèo", 58000, 100, "Thức ăn hữu cơ chất lượng cao", "../assets/images/product-1.jpg", true, 10, "sale", new List<string>{ "400g", "500g", "2kg" }, new List<string>{ "../assets/images/product-1-1.jpg", "../assets/images/product-1-2.jpg",  "../assets/images/product-1-3.jpg", "../assets/images/product-1-4.jpg"  }),
                new Product("product-2", "Hạt Royal Canin cho mèo con", "Thức ăn cho mèo", 320000, 50, "Hỗ trợ tăng cường tiêu hóa", "../assets/images/product-2.jpg", true, 5,"sale", new List<string>{ "1kg", "2kg" }, new List<string>{ "thumb3.png", "thumb4.png" }),
                new Product("product-3", "Pate Sheba Thịt gà", "Pate cho mèo", 25000, 200, "Thịt gà dinh dưỡng cho mèo", "../assets/images/product-3.jpg", true, 0,"sale", new List<string>{ "70g", "85g" }, new List<string>{ "thumb5.png", "thumb6.png" }),
                new Product("product-4", "Bánh thưởng cho mèo Whiskas", "Bánh thưởng cho mèo", 12000, 300, "Bổ sung vitamin", "../assets/images/product-4.jpg", true, 15,"sale", new List<string>{ "60g", "80g" }, new List<string>{ "thumb7.png", "thumb8.png" }),
                new Product("product-5", "Cát vệ sinh cho mèo", "Phụ kiện cho mèo", 100000, 150, "Cát vệ sinh khử mùi", "../assets/images/product-5.jpg", true, 0,"sale", new List<string>{ "5kg", "10kg" }, new List<string>{ "thumb9.png", "thumb10.png" }),
                new Product("product-6", "Hạt thức ăn hữu cơ Natural Core cho chó", "Thức ăn cho chó", 70000, 80, "Thức ăn hữu cơ giúp tiêu hóa","../assets/images/product-6.jpg", true, 10,"new", new List<string>{ "500g", "2kg", "5kg" }, new List<string>{ "thumb11.png", "thumb12.png" }),
                new Product("product-7", "Pate Pedigree thịt bò", "Pate cho chó", 30000, 120, "Thịt bò bổ sung đạm cho chó", "../assets/images/product-7.jpg", true, 5,"new", new List<string>{ "70g", "100g" }, new List<string>{ "thumb13.png", "thumb14.png" }),
                new Product("product-8", "Sữa tắm cho chó mèo", "Phụ kiện cho chó mèo", 150000, 60, "Sữa tắm diệt khuẩn", "../assets/images/product-8.jpg", true, 20,"new", new List<string>{ "200ml", "500ml" }, new List<string>{ "thumb15.png", "thumb16.png" }),
                new Product("product-9", "Vòng cổ cho chó", "Phụ kiện cho chó", 50000, 90, "Vòng cổ chất liệu bền", "../assets/images/product-9.jpg", true, 0,"new", new List<string>{ "M", "L", "XL" }, new List<string>{ "thumb17.png", "thumb18.png" }),
                new Product("product-10", "Thức ăn ướt cho chó Pedigree", "Thức ăn cho chó", 35000, 70, "Thức ăn ướt tăng cường thể lực", "../assets/images/product-10.jpg", true, 5,"new", new List<string>{ "400g", "500g" }, new List<string>{ "thumb19.png", "thumb20.png" })
            };

            Application[Global.LIST_SHOPPING_CART] = new List<CartItem>
            {
                new CartItem { CartItemId = "cart-item-1", CartId = "cart-1", ProductId = "product-1", ProductType = "Thức ăn cho mèo", Quantity = 2, Price = 58000 },
                new CartItem { CartItemId = "cart-item-2", CartId = "cart-1", ProductId = "product-2", ProductType = "Thức ăn cho mèo", Quantity = 1, Price = 320000 },
                new CartItem { CartItemId = "cart-item-3", CartId = "cart-1", ProductId = "product-3", ProductType = "Pate cho mèo", Quantity = 3, Price = 25000 },
                new CartItem { CartItemId = "cart-item-4", CartId = "cart-1", ProductId = "product-4", ProductType = "Bánh thưởng cho mèo", Quantity = 4, Price = 12000 }
            };


        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session[Global.LIST_SHOPPING_CART] = new List<CartItem>();
            Session[Global.USER_NAME] = "";
            Session[Global.USER_ID] = "";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}