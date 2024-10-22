<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Pet_Shop.pages.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <!---- css -->
    <link rel="stylesheet" href="../assets/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assets/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <link rel="stylesheet" href="../assets/css/index.css" />
</head>
<body>
    <header class="header">
        <div class="header-left">
            <div class="menu-bar">
                <button class="btn-menu">
                    <i class="fa-solid fa-bars" style="font-size: 27px;"></i>
                </button>
                <p>Menu</p>
            </div>
            <a href='index.aspx'>
                <img class="logo" src="../assets/images/logo.jpg" alt="">
            </a>
        </div>
        
        <div class="box-search">
            <div class="search">
                <input type="text" placeholder="Tìm kiếm" id="search" />
                <i class="ti-search" onclick="search()"></i>
            </div>

            <a class="cart" href='cart.aspx' style="margin-right: 10px; margin-left: 0px">
                <i class="fa-solid fa-cart-shopping"></i>
                <div id="numOfProduct" class="quantity-product-cart" runat="server">0</div>
            </a>

            <div id="infor_user" runat="server"></div>

        </div>

        <div class="menu">
            <ul class="list-category">
                <li>
                    <div>
                        <p>Mua đồ cho chó</p>
                    </div>
                    <ul class="inner-list">
                        <li><a href="">Xem tất cả</a></li>
                        <li><a href="">Thức ăn</a></li>
                        <li><a href="">Phụ kiện</a></li>
                        <li><a href="">Vật dụng</a></li>
                        <li><a href="">Sữa tắm</a></li>
                    </ul>
                </li>

                <li>
                    <div>
                        <p>Mua đồ cho mèo</p>
                    </div>
                    <ul class="inner-list">
                        <li><a href="">Xem tất cả cho mèo</a></li>
                        <li><a href="">Thức ăn</a></li>
                        <li><a href="">Phụ kiện</a></li>
                        <li><a href="">Vật dụng</a></li>
                        <li><a href="">Sữa tắm</a></li>
                    </ul>
                </li>
                <li>
                    <div>
                        <p>KHUYẾN MÃI</p>
                    </div>
                </li>
                <li>
                    <div>
                        <p>TIN TỨC</p>
                    </div>
                    
                </li>
                <li>
                    <div>
                        <p>LIÊN HỆ</p>
                    </div>
                </li>
            </ul>
        </div>
    </header>



    <main>
        <div class="category">
            <i class="fa-solid fa-house"></i>
            <a href="">Mua đồ cho chó</a>
            <a href="">Mua đồ cho mèo</a>
            <a href="">Dịch vụ Spa</a>
            <a href="">Khuyến mãi</a>
        </div>

        <div class="bg-advertise">
            <img src="../assets/images/advertise.jpg" alt="" style="width:  100%;">
        </div>
        
        <div id="product_list_sale" runat="server">

        </div>
        <div id="product_list_new" runat="server">

        </div>

        <div class="thumb-bottom">
            <img src="https://theme.hstatic.net/200000263355/1001161916/14/home_collection_5_image.jpg?v=115" alt="">
        </div>


        <div class="more-article">
            <h3>Có thể bạn muốn biết</h3>
            <div class="inner-list">
              <div class="inner-item">
                <img src="https://file.hstatic.net/200000263355/article/lam_the_nao_diet_bo_chet_trong_nha_d69e5c802fec4fa4b793ee484e5bb5c9_small.png" alt="Article Image">
                <div class="info-item">
                  <p class="title">Làm thế nào để hết bò chết trong nhà?</p>
                  <p class="date-article">11/12/2023</p>
                </div>
              </div>

              <div class="inner-item">
                <img src="https://file.hstatic.net/200000263355/article/cham_soc_meo_con_1bea5eeabff644a9bffe7065984d2439_small.png" alt="Article Image">
                <div class="info-item">
                  <p class="title">Làm thế nào để hết bỏ chết trong nhà?</p>
                  <p class="date-article">11/12/2023</p>
                </div>
              </div>
              <div class="inner-item">
                <img src="https://file.hstatic.net/200000263355/article/lam-sao-de-cho-an-nhieu_82c3150d6e8f4454b22822ba875421b5_small.jpg" alt="Article Image">
                <div class="info-item">
                  <p class="title">Làm thế nào để hết bỏ chết trong nhà?</p>
                  <p class="date-article">11/12/2023</p>
                </div>
              </div>
              <div class="inner-item">
                <img src="https://file.hstatic.net/200000263355/article/sua_tam_tri_viem_da_davis_4124fd1caf9a440d95aa4dc80c4b180a_small.jpg" alt="Article Image">
                <div class="info-item">
                  <p class="title">Làm thế nào để hết bỏ chết trong nhà?</p>
                  <p class="date-article">11/12/2023</p>
                </div>
              </div>
              <!-- Repeat inner-item structure for other articles -->
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
      

    <script src="./click-menu.js"></script>
</body>
</html>

