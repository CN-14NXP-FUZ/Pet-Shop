﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pet_Shop.pages
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Chỉ loại bỏ session có tên Global.CUSTOMER_NAME
            Session.Remove(Global.USER_ID);
            Session.Remove(Global.USER_NAME);

            // Hoặc có thể đặt session về null
            Response.Redirect("index.aspx");
        }
    }
}