using Pet_Shop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Pet_Shop.pages
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductList();
                BindUserList();
            }
            // Kiểm tra xem có yêu cầu xóa sản phẩm hay không
            string deleteId = Request.QueryString["deleteId"];
            if (!string.IsNullOrEmpty(deleteId))
            {
                DeleteProduct(deleteId);
                BindProductList(); // Cập nhật lại danh sách sản phẩm

                Response.Redirect($"admin.aspx?currentTab=products");
            }

            // Kiểm tra xem có yêu cầu xóa sản phẩm hay không
            string deleteId_User = Request.QueryString["deleteId_User"];
            if (!string.IsNullOrEmpty(deleteId_User))
            {
                DeleteUser(deleteId_User);
                BindUserList(); // Cập nhật lại danh sách sản phẩm

                Response.Redirect($"admin.aspx?currentTab=users");
            }
            // Xử lý thêm người dùng
            string action = Request.Form["action"];
            if (action == "addUser")
            {
                AddUser();
                BindUserList();
                Response.Redirect("admin.aspx?currentTab=users");
            }
            else if (action == "editUser")
            {
                EditUser();
                BindUserList();
                Response.Redirect("admin.aspx?currentTab=users");
            }
            // Xử lý thêm sản phẩm
            string action2 = Request.Form["action"];
            if (action2 == "addProduct")
            {
                AddProduct();
                BindProductList();
                Response.Redirect("admin.aspx?currentTab=products");
            }
            else if (action == "editProduct")
            {
                EditProduct();
                BindProductList();
                Response.Redirect("admin.aspx?currentTab=products");
            }
        }
        private void EditProduct()
        {
            string productId = Request.Form["productId"];
            string productName = Request.Form["productName"];
            string category = Request.Form["category"];
            int price = int.Parse(Request.Form["price"]);
            int stock = int.Parse(Request.Form["stock"]);
            string description = Request.Form["description"];
            string imageUrl = Request.Form["imageUrl"];
            bool isAvailable = bool.Parse(Request.Form["isAvailable"]);
            int discount = int.Parse(Request.Form["discount"] ?? "0");
            string typeProduct = Request.Form["typeProduct"];
            List<string> listWeight = string.IsNullOrEmpty(Request.Form["listWeight"])
                ? new List<string>()
                : Request.Form["listWeight"].Split(',').ToList();
            List<string> listThumb = string.IsNullOrEmpty(Request.Form["listThumb"])
                ? new List<string>()
                : Request.Form["listThumb"].Split(',').ToList();
            // Sửa thông tin sản phẩm
            List<Product> products = Application[Global.LIST_PRODUCT] as List<Product>;
            if(products != null)
            {
                var product = products.FirstOrDefault(p => p.Id == productId);
                if(product != null)
                {
                    product.Name = productName;
                    product.NameCategory = category;
                    product.Price = price;
                    product.Stock = stock;
                    product.Description = description;
                    product.ImageUrl = imageUrl;
                    product.IsAvailable = isAvailable;
                    product.Discount = discount;
                    product.TypeProduct = typeProduct;
                    product.ListSize = listWeight;
                    product.ListThumb = listThumb;
                    Application[Global.LIST_PRODUCT] = products; // Cập nhật danh sách sản phẩm
                }
            }
        }
        private void AddProduct()
        {
            // Lấy thông tin từ form
            string productId = Request.Form["productId"];
            string productName = Request.Form["productName"];
            string category = Request.Form["category"];
            int price = int.Parse(Request.Form["price"]);
            int stock = int.Parse(Request.Form["stock"]);
            string description = Request.Form["description"];
            string imageUrl = Request.Form["imageUrl"];
            bool isAvailable = bool.Parse(Request.Form["isAvailable"]);
            int discount = int.Parse(Request.Form["discount"] ?? "0");
            string typeProduct = Request.Form["typeProduct"];
            List<string> listWeight = Request.Form["listWeight"].Split(',').ToList();
            List<string> listThumb = Request.Form["listThumb"].Split(',').ToList();

            // Thêm sản phẩm mới
            List<Product> products = Application[Global.LIST_PRODUCT] as List<Product> ?? new List<Product>();

            Product newProduct = new Product(productId, productName, category, price, stock, description, imageUrl, isAvailable, discount, typeProduct, listWeight, listThumb);
            if (products != null)
            {
                products.Add(newProduct);
                Application[Global.LIST_PRODUCT] = products; // Cập nhật danh sách người dùng trong Application
            }
        }
        private void EditUser()
        {
            // Lấy thông tin từ form
            string userId = Request.Form["userId"];
            string fullName = Request.Form["fullName"];
            string password = Request.Form["password"];
            string email = Request.Form["email"];
            string phoneNumber = Request.Form["phoneNumber"];
            string address = Request.Form["address"];

            // Sửa thông tin người dùng
            List<User> users = Application[Global.LIST_USER] as List<User>;
            if (users != null)
            {
                var user = users.FirstOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    user.FullName = fullName;
                    user.Password = password;
                    user.Email = email;
                    user.PhoneNumber = phoneNumber;
                    user.Address = address;
                    Application[Global.LIST_USER] = users; // Cập nhật danh sách người dùng
                }
            }
        }
        private void AddUser()
        {
            // Lấy thông tin người dùng từ form
            string userId = Request.Form["userId"];
            string fullName = Request.Form["fullName"];
            string password = Request.Form["password"];
            string email = Request.Form["email"];
            string phoneNumber = Request.Form["phoneNumber"];
            string address = Request.Form["address"];

            // Tạo đối tượng người dùng mới
            User newUser = new User(userId, fullName, password, email, phoneNumber, address);

            // Thêm người dùng vào danh sách
            List<User> users = Application[Global.LIST_USER] as List<User>;
            if (users != null)
            {
                users.Add(newUser);
                Application[Global.LIST_USER] = users; // Cập nhật danh sách người dùng trong Application
            }
        }
        

        private void BindProductList()
        {
            // Lấy danh sách sản phẩm từ Application
            List<Product> products = Application[Global.LIST_PRODUCT] as List<Product>;

            // Tạo chuỗi HTML để hiển thị danh sách sản phẩm
            string productHtml = string.Empty;

            if (products != null && products.Count > 0)
            {
                foreach (var product in products)
                {
                    productHtml += "<tr>";
                    productHtml += $"<td>{product.Id}</td>";
                    productHtml += $"<td>{product.Name}</td>";
                    productHtml += $"<td>{product.NameCategory}</td>";
                    productHtml += $"<td>{product.Price.ToString("N0")} VND</td>";
                    productHtml += $"<td>{product.Stock}</td>";
                    productHtml += $"<td>{product.Description}</td>";
                    productHtml += $"<td><img src='{product.ImageUrl}' alt='{product.Name}' width='50' height='50' /></td>";
                    productHtml += $"<td>{(product.IsAvailable ? "Còn hàng" : "Hết hàng")}</td>";
                    productHtml += $"<td>{product.Discount}%</td>";
                    productHtml += $"<td>{product.TypeProduct}</td>";
                    productHtml += $"<td>{string.Join(", ", product.ListSize)}</td>";
                    productHtml += "<td>";
                    foreach (var image in product.ListThumb)
                    {
                        productHtml += $"<img src='{image}' alt='product image' width='50' height='50' />";
                    }
                    productHtml += "</td>";
                    productHtml += "<td>";
                    productHtml += $"<button class='btn' onclick=\"editProduct('{product.Id}', '{product.Name}', '{product.NameCategory}', '{product.Price}', '{product.Stock}', '{product.Description}', '{product.ImageUrl}', '{product.IsAvailable}', '{product.Discount}', '{product.TypeProduct}', '{product.ListSize}', '{product.ListThumb}' )\">Sửa</button>";
                    productHtml += $"<button class='btn' onclick=\"deleteProduct('{product.Id}')\">Xóa</button>";
                    productHtml += "</td>";
                    productHtml += "</tr>";
                }
            }
            else
            {
                productHtml = "<tr><td colspan='12'>Không có sản phẩm nào</td></tr>";
            }

            // Đưa HTML vào trong table body trên giao diện
            productTableBody.InnerHtml = productHtml;
        }

        private void BindUserList()
        {
            // Lấy danh sách user từ Application
            List<User> users = Application[Global.LIST_USER] as List<User>;

            // Tạo chuỗi HTML để hiển thị danh sách người dùng
            string userHtml = string.Empty;
            if (users != null && users.Count > 0)
            {
                foreach (var user in users)
                {
                    userHtml += "<tr>";
                    userHtml += $"<td>{user.UserId}</td>";
                    userHtml += $"<td>{user.FullName}</td>";
                    userHtml += $"<td>{user.Password}</td>";
                    userHtml += $"<td>{user.Email}</td>";
                    userHtml += $"<td>{user.PhoneNumber}</td>";
                    userHtml += $"<td>{user.Address}</td>";
                    userHtml += "<td>";
                    userHtml += $"<button class='btn' onclick=\"editUser('{user.UserId}', '{user.FullName}', '{user.Password}', '{user.Email}', '{user.PhoneNumber}', '{user.Address}')\">Sửa</button>";
                    userHtml += $"<button class='btn' onclick=\"deleteUser('{user.UserId}')\">Xóa</button>";
                    userHtml += "</td>";
                    userHtml += "</tr>";
                }
            }
            else
            {
                userHtml = "<tr><td colspan='6'>Không có người dùng nào</td></tr>";
            }
            userTableBody.InnerHtml = userHtml;
        }
        private void DeleteProduct(string productId)
        {
            List<Product> products = Application[Global.LIST_PRODUCT] as List<Product>;
            if (products != null)
            {
                var productToRemove = products.FirstOrDefault(p => p.Id == productId);
                if (productToRemove != null)
                {
                    products.Remove(productToRemove);
                    Application[Global.LIST_PRODUCT] = products; // Cập nhật danh sách sản phẩm trong Application
                }
            }
        }
        private void DeleteUser(string userId)
        {
            List<User> users = Application[Global.LIST_USER] as List<User>;
            if (users != null)
            {
                var userToRemove = users.FirstOrDefault(p => p.UserId == userId);
                if (userToRemove != null)
                {
                    users.Remove(userToRemove);
                    Application[Global.LIST_PRODUCT] = users; // Cập nhật danh sách người dùng trong Application
                }
            }
        }
    }
}