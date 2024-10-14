<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="Pet_Shop.pages.checkout" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <link rel="stylesheet" href="../assets/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assets/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <!---- css -->
    <link rel="stylesheet" href="../assets/css/index.css" />
    <link rel="stylesheet" href="../assets/css/checkout.css"/>
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
        <div class="checkout-container">
            <div class="checkout-left">
                <h3>Thông tin giao hàng</h3>
                <form action="#" method="POST" class="checkout-form">
                    <div class="form-group">
                        <input type="text" name="name" placeholder="Họ và tên" required>
                        <input type="email" name="email" placeholder="Email" required>
                        <input type="text" name="phone" placeholder="Số điện thoại" required>
                        <input type="text" name="address" placeholder="Địa chỉ" required>
                    </div>
                    <div class="form-group">
                        <select name="city">
                            <option value="">Tỉnh / thành</option>
                            <option value="hanoi">Hà Nội</option>
                            <!-- Add more options here -->
                        </select>
                        <select name="district">
                            <option value="">Quận / huyện</option>
                        </select>
                        <select name="ward">
                            <option value="">Phường / xã</option>
                        </select>
                    </div>

                    <h4>Phương thức vận chuyển</h4>
                    <div class="shipping-method">
                        <p>Vui lòng chọn tỉnh / thành để có danh sách phương thức vận chuyển.</p>
                    </div>

                    <h4>Phương thức thanh toán</h4>
                    <div class="payment-method">
                        <div class="inner-payment">
                            <label for="cod">Thanh toán khi giao hàng (COD)</label>
                            <input type="radio" id="cod" name="payment" value="cod" checked>
                        </div>
                        <div class="inner-payment">
                            <label for="bank">Chuyển khoản qua ngân hàng</label>
                            <input type="radio" id="bank" name="payment" value="bank">
                        </div>
                    </div>

                    <button type="submit" class="complete-order">Hoàn tất đơn hàng</button>
                </form>
            </div>

            <div class="checkout-right">
                <h3>Giỏ hàng</h3>
                <div class="cart-items">
                    <div class="cart-item">
                        <img src="https://product.hstatic.net/200000263355/product/568ca5b1-c395-423a-a8dd-bba7f53959ca_fc19499f14f24a5594931ff69b000b41_small.jpg" alt="Product 1">
                        <p>Thẻ tên inox dành cho Thú cưng</p>
                        <span>59,000₫</span>
                    </div>
                    <div class="cart-item">
                        <img src="https://product.hstatic.net/200000263355/product/hzqu7821_84244effd59d4945844e03dfccf9e337_small.jpg" alt="Product 2">
                        <p>Thức ăn hạt hữu cơ Natural Core Bene C1</p>
                        <span>58,500₫</span>
                    </div>
                </div>

                <div class="cart-summary">
                    <div class="btn-discount">
                        <input type="text" placeholder="Mã giảm giá">
                        <button>Sử dụng</button>
                    </div>
                    

                    <div class="summary-detail">
                        <p>Tạm tính: <span>117,500₫</span></p>
                        <p>Phí vận chuyển: <span>-</span></p>
                        <div class="inner-price">
                            <p><strong>Tổng cộng:</strong></p>
                            <p><strong>117,500₫</strong></p>
                        </div>
                    </div>
                </div>
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
