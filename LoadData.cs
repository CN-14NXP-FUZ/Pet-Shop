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

        public static string LoadProductDetail(Product product)
        {
            string listThumb = "";
            int limit = 3;
            foreach (string thumb in product.ListThumb)
            {
                listThumb += $"<img src='{thumb}' alt=''>";
                limit--;
                if (limit == 0)
                {
                    break;
                }
            }
            string listType = "";
            foreach (string type in product.ListSize)
            {
                listType += $"<option>{type}</option>";
            }
            double newPrice = Convert.ToDouble(product.Price) * (1.00 - product.Discount / 100.0);

            string html = $@"<div class='detail-product'>
            <div class='product-gallery'>
                 
                <img src='{product.ImageUrl}' alt=''>
                <!-- Add more images if needed -->
                <div class='product-thumbnails'>
                    {listThumb}
                </div>
            </div>
    
            <div class='product-info'>
                <h1 class='product-name'>{product.Name}</h1>
                <p class='product-code'>Mã sản phẩm: </p> <span id='product-id'> {product.Id} </span>

                <p class='product-status'>Tình trạng:" + (product.IsAvailable ? "còn hàng": "hết hàng") + $@"</p>

                <div class='product-price'>
                    <span class='price-old'>{product.Price}₫</span>
                    <span class='price-new'>{newPrice}₫</span>
                    <span class='price-discount'>-{product.Discount}%</span>
                </div>
    
                <div class='product-options'>
                    <label for='color'>Loại</label>
                    <select id='color' name='color'>
                        {listType}
                    </select>
                </div>

                <div class='quantity-box'> 
                    <button class='quantity-btn-decrease'>-</button>
                    <input type='number' name='quantity-product' id='quantity-product' value='1' min='1' max='{product.Stock}' readonly>
                    <button class='quantity-btn-increase'>+</button>
                </div>
    
                 <div class=""add-to-cart"">
                    <button class=""add-cart-btn"" id='btnAddToCart'>Thêm vào giỏ</button>
                </div>
    
                <div class='product-details'>
                    <h3>Thông tin sản phẩm</h3>
                    <p>{product.Description}</p>
                    <p>Chất liệu sản phẩm:
                        Thẻ tên được làm từ chất liệu inox cao cấp, không gỉ, đảm bảo độ bền và sáng bóng trong suốt thời gian sử dụng. Chất liệu này an toàn cho thú cưng và không gây kích ứng.</p>
                </div>
            </div>
        </div>";

            return html;
            
        }

        public static string LoadCart(CartItem cart, List<Product> listProduct)
        {
            int numOfProduct = 0;
            if (cart.ListProduct != null && cart.ListProduct.Count != 0)
            {
                numOfProduct = cart.ListProduct.Count;
                string listProductHtml = "";
                double totalPrice = 0;
                Dictionary<string, int> list = cart.ListProduct;
                foreach (KeyValuePair<string, int> item in list)
                {
                    foreach (Product product in listProduct)
                    {
                        if (product.Id == item.Key)
                        {
                            double newPrice = Convert.ToDouble(product.Price) * (1.00 - product.Discount / 100.0);
                            totalPrice += newPrice * item.Value;
                            listProductHtml += $@"<tr data-product-id='{product.Id}'>
                                    <td class='infor-product' >
                                        <img src='{product.ImageUrl}' alt='Product 1'>
                                        <div class='inner-infor-product'>
                                            <p>{product.Name}</p>
                                        </div>
                                    </td>
                                    <td>${newPrice}</td>
                                    <td>
                                        <button class='btn-decrease' data-product-id='{product.Id}'>-</button>
                                        <input type='number' value='{item.Value}' class='quantity-input' data-product-id='{product.Id}' max='{product.Stock}'>
                                        <button class='btn-increase' data-product-id='{product.Id}'>+</button>
                                    </td>
                                    <td>${newPrice * item.Value}</td>
                                    <td><button class='delete-btn' data-product-id='{product.Id}'>Delete</button></td>
                                </tr>";
                        }
                    }
                }
                string html = $@"
                            <h4>Bạn đang có {numOfProduct} sản phẩm trong cửa hàng</h4>
                          <!-- Product Cart Table -->
                          <section class=""cart-section"">
                              <table class=""cart-table"">
                                  <thead>
                                      <tr>
                                          <th>Sản phẩm</th>
                                          <th>Giá</th>
                                          <th>Số lượng</th>
                                          <th>Tổng</th>
                                          <th>Thực hiện</th>
                                      </tr>
                                  </thead>
                                  <tbody class='list-product-item'>
                                      {listProductHtml}
                                      <!-- Add more products as needed -->
                                  </tbody>
                              </table>

                              <div class=""cart-summary"">
                                  <p style='marin-bottom: 10px;'>Tổng giá: <span>{totalPrice}</span></p>
                                  <div style='display: flex;'>
                                      <button class='checkout-btn update-btn'>Cập nhật</button>
                                      <a class=""checkout-btn"" href=""checkout.aspx"" style='margin-left: 10px'>Thanh toán</a>
                                  </div>
                              </div>
                          </section>";
                return html;
            }
            
            return $@"<h4 style='text-align: center; font-size: 20px;'>Bạn chưa có sản phẩm nào trong cửa hàng</h4>";
        }

    }
}