using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop
{
    public class LoadOrder
    {
        public static string LoadOrderDetail(List<Order> userOrders, List<Product> listProduct, List<CartItem> listCart)
        {
            string htmlOrderDetail = "";
            if (userOrders == null)
            {
                return "<p>Your cart is empty !<p>";
            }
            foreach (Order order in userOrders)
            {
                string orderId = order.Id;

                string cartId = order.CartId;
                string status = order.Status;
                string orderType = order.OrderType;
                DateTime timeOrder = order.TimeOrder;

                CartItem cart = listCart.Find(item => item.Id == cartId);

                Dictionary<string, int> listProInCart = cart.ListProduct;

                if (listProduct == null )
                {
                    continue;
                }

                string infoProductItem = "";
                int index = 1;
                foreach (KeyValuePair<string, int> productItem in listProInCart)
                {
                    string productId = productItem.Key;
                    int quantity = productItem.Value;

                    Product product = listProduct.Find(item => item.Id == productId);
                    if (product == null)
                    {
                        continue;
                    }
                    string productName = product.Name;
                    string productImage = product.ImageUrl;
                    int productPrice = product.Price;

                    infoProductItem += $@"
                        <tr class=""order-row"">
                            <td>{index++}</td>
                            <td>
                                <div class=""product"">
                                    <img src='{productImage}' alt=""Product"">
                                    <div class=""product-info"">
                                        <h3 class=""product-name"">{productName}</h3>
                                        <p>Số lượng: {quantity}</p>
                                    </div>
                                </div>
                            </td>
                            <td>{productPrice.ToString("N0")}đ</td>
                        </tr>";
                }



                string orderHtml = $@"
                <section class=""order-item"">
                <div class=""order-head"">
                    <h2 class=""title"">Đơn hàng #{orderId}</h2>
                    <a href=''>Chi tiết</a>
                </div>
                <div>
                    <table>
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Sản phẩm</th>
                                <th>Giá</th>
                            </tr>
                        </thead>
                    <tbody>
                        {infoProductItem}
                    </tbody>
                </table>
                </div>
            </section>";

                htmlOrderDetail += orderHtml;
            }
            if (htmlOrderDetail == "")
            {
                return "<p style='font-size: 24px; text-align: center; font-weight: bold; margin-bottom: 100px;'>Your cart is empty !<p>";
            }
            return htmlOrderDetail;
        }
    }
}