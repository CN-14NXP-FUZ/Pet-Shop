<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Pet_Shop.pages.register" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <link rel="stylesheet" href="../assets/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assets/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <!---- css -->
    <link rel="stylesheet" href="../assets/css/index.css" />
    <link rel="stylesheet" href="../assets/css/register.css" />
</head>
<body>
    <header class="header">
        <div class="header-left">
            <div class="menu-bar">
                <i class="fa-solid fa-bars" style="font-size: 27px;"></i>
                <p>Menu</p>
            </div>
            <a href='index.aspx'>
                <img class="logo" img src="https://theme.hstatic.net/200000263355/1001161916/14/logo.png?v=115" alt="">
            </a>
        </div>
        
        <div class="box-search">
            <div class="search">
                <input type="text" placeholder="Tìm kiếm" id="search" />
                <i class="ti-search" onclick="search()"></i>
            </div>
            <a class="cart" href='cart.aspx'>
                <i class="fa-solid fa-cart-shopping"></i>
                <div id="numOfProduct" class="quantity-product-cart" runat="server">0</div>
            </a>
             <div id="infor_user" runat="server"></div>
            
        </div>
    </header>


    <main>
        <div class="box-register">
            <div class="register-form">
                <h1>Đăng ký</h1>
                <form action="register.aspx" method="post" runat="server">
                    <div class="input-box">
                        <label for="email">Email</label>
                        <input type="email" name="email" placeholder="Email" required>
                    </div>
                    <div class="input-box">
                        <label for="name">Họ tên</label>
                        <input type="text" name="name" placeholder="Họ và tên" required>
                    </div>
                    <div class="input-box">
                        <label for="password">Mật khẩu</label>
                        <input type="password" name="password" placeholder="Mật khẩu" required>
                    </div>
                    <div class="input-box">
                        <label for="password_confirm">Nhập lại mật khẩu</label>
                        <input type="password" name="password_confirm" placeholder="Nhập lại mật khẩu" required>
                    </div>
                    
                    <div class="input-box">
                        <label for="phoneNumber">Số điện thoại</label>
                        <input type="text" name="phoneNumber" placeholder="Số điện thoại" required>
                    </div>
                    <div id="register_error" runat="server" style="margin: 10px 0px; text-align: center; color: red"></div>

                    <div class="input-box">
                        <input type="submit" value="Đăng ký">
                    </div>
                    <div class="input-box">
                        <p>Đã có tài khoản? <a href="login.aspx">Đăng nhập</a></p>
                    </div>
                </form>
            </div>
        </div>
    </main>
    
    

    <footer class="footer">
        <div class="inner-footer">
          <div class="footer-left">
            <div class="logo">
              <img src="https://theme.hstatic.net/200000263355/1001161916/14/logo.png?v=115" alt="Company Logo">
            </div>
            
          </div>
          <div class="contact">
            <p>Địa chỉ: 123</p>
            <p>Điện thoại: 0123456789</p>
            <p>Email: chinh1234@example.com</p>
          </div>
          <div class="footer-right">
            <div class="social">
              <a href="#">
                <i class="fab fa-facebook-f"></i>
              </a>
              <a href="#">
                <i class="fab fa-instagram"></i>
              </a>
              <a href="#">
                <i class="fab fa-twitter"></i>
              </a>
            </div>
            
          </div>
        </div>
      </footer>
      


</body>
</html>

