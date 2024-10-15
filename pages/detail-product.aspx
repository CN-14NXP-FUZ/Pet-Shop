<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detail-product.aspx.cs" Inherits="Pet_Shop.pages.detail_product" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <link rel="stylesheet" href="../assets/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assets/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <!---- css -->
    <link rel="stylesheet" href="../assets/css/index.css" />
    <link rel="stylesheet" href="../assets/css/detail-product.css"/>
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
        <div runat="server" id="productDetail"></div>

        <section class="product-relate">
            <div  class="title-section">
                <p>SẢN PHẨM LIÊN QUAN</p>
            </div>

            <div class="list-product">
                <div class="inner-item">
                    <div class="item">
                        <img src="https://product.hstatic.net/200000263355/product/hcgm4317_2b28fb5922de4f91b5d652fa273a2aa3_large.jpg" alt="">
                        <p class="name-product">Thức ăn hạt hữu cơ Natural Core Bene C1 Cho mèo Con [400g - 500g - 2kg - 5kg]</p>
                        <div class="price">
                            <p class="newPrice">Giá: 100.000đ</p>
                            <p class="oldPrice">Giá: 130.000đ</p>
                        </div>
                        <a class="btn-buy">
                            Chọn Mua
                        </a>
                    </div>
                </div>
                <div class="inner-item">
                    <div class="item">
                        <img src="https://product.hstatic.net/200000263355/product/z4431095003016_2502c8469ac42e9a69abdbc622a3f2f3_acc3767e69f0402087641ba8d80396bb_large.jpg" alt="">
                        <p class="name-product">Thức ăn hạt hữu cơ Natural Core Bene C1 Cho mèo Con [400g - 500g - 2kg - 5kg]</p>
                        <div class="price">
                            <p class="newPrice">Giá: 100.000đ</p>
                            <p class="oldPrice">Giá: 130.000đ</p>
                        </div>
                        <a class="btn-buy">
                            Chọn Mua
                        </a>
                    </div>
                </div>

                <div class="inner-item">
                    <div class="item">
                        <img src="https://product.hstatic.net/200000263355/product/z4428139456220_e5fdb0770e148227b787b40d4b561903_7687010be48a40e7af45482f326f41ab_large.jpg" alt="">
                        <p class="name-product">Thức ăn hạt hữu cơ Natural Core Bene C1 Cho mèo Con [400g - 500g - 2kg - 5kg]</p>
                        <div class="price">
                            <p class="newPrice">Giá: 100.000đ</p>
                            <p class="oldPrice">Giá: 130.000đ</p>
                        </div>
                        <a class="btn-buy">
                            Chọn Mua
                        </a>
                    </div>
                </div>

                <div class="inner-item">
                    <div class="item">
                        <img src="https://product.hstatic.net/200000263355/product/z4453851054051_3442df911a8aa7a60f1ebb86649f6c1c_4721ee84e7f642b4b8bef47cec89a472_large.jpg" alt="">
                        <p class="name-product">Thức ăn hạt hữu cơ Natural Core Bene C1 Cho mèo Con [400g - 500g - 2kg - 5kg]</p>
                        <div class="price">
                            <p class="newPrice">Giá: 100.000đ</p>
                            <p class="oldPrice">Giá: 130.000đ</p>
                        </div>
                        <a class="btn-buy">
                            Chọn Mua
                        </a>
                    </div>
                </div>
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
      

    <script src="../assets/script/detail-product.js"></script>
    
</body>
</html>
