<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="Pet_Shop.pages.cart" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <link rel="stylesheet" href="../assets/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assets/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <!---- css -->
    <link rel="stylesheet" href="../assets/css/index.css" />
    <link rel="stylesheet" href="../assets/css/cart.css"/>
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
            <a  class="cart" href='cart.aspx'>
                <i class="fa-solid fa-cart-shopping"></i>
                <div id="numOfProduct" class="quantity-product-cart" runat="server">0</div>
            </a>
             <div id="infor_user" runat="server"></div>
            
        </div>
    </header>


    <main>
      <h3 class="title-cart">Giỏ hàng của bạn</h3>
      <h4>Bạn đang có 4 sản phẩm trong cửa hàng</h4>
      <!-- Product Cart Table -->
      <section class="cart-section">
          <table class="cart-table">
              <thead>
                  <tr>
                      <th>Sản phẩm</th>
                      <th>Giá</th>
                      <th>Số lượng</th>
                      <th>Tổng</th>
                      <th>Thực hiện</th>
                  </tr>
              </thead>
              <tbody>
                  <tr>
                      <td class="infor-product">
                        <img src="https://product.hstatic.net/200000263355/product/568ca5b1-c395-423a-a8dd-bba7f53959ca_fc19499f14f24a5594931ff69b000b41_medium.jpg" alt="Product 1">
                        <div class="inner-infor-product">
                          <p>Thẻ tên inox dành cho thú cưng </p>
                        </div>
                      </td>
                      
                      <td>$25.00</td>
                      <td>
                          <button class="decrement-btn">-</button>
                          <input type="number" value="1" class="quantity-input">
                          <button class="increment-btn">+</button>
                      </td>
                      <td>$25.00</td>
                      <td><button class="delete-btn">Delete</button></td>
                  </tr>

                  <tr>
                    <td class="infor-product">
                      <img src="https://product.hstatic.net/200000263355/product/hzqu7821_84244effd59d4945844e03dfccf9e337_medium.jpg" alt="Product 1">
                      <div class="inner-infor-product">
                        <p>Thẻ tên inox dành cho thú cưng </p>
                      </div>
                    </td>
                    
                    <td>$35.00</td>
                    <td>
                        <button class="decrement-btn">-</button>
                        <input type="number" value="1" class="quantity-input">
                        <button class="increment-btn">+</button>
                    </td>
                    <td>$35.00</td>
                    <td><button class="delete-btn">Delete</button></td>
                </tr>
                  
                  <!-- Add more products as needed -->
              </tbody>
          </table>


          
          <div class="cart-summary">
              <p>Tổng giá: <span>55.00</span></p>
              <a class="checkout-btn" href="checkout.aspx">Thanh toán</a>
          </div>
      </section>

      
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
