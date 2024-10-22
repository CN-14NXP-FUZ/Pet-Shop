<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Pet_Shop.pages.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <link rel="stylesheet" href="../assets/css/admin.css" />
    <script src="../assets/script/edit-product.js"></script>
</head>
<body>
    <div class="sidebar">
        <a href="#" onclick="showContent('home')"><i class="fas fa-home"></i> Trang chủ</a>
        <a href="#" onclick="showContent('products')"><i class="fas fa-dog"></i> Quản lý sản phẩm</a>
        <a href="#" onclick="showContent('users')"><i class="fas fa-shopping-cart"></i> Quản lý người dùng</a>
        <a href="#" onclick="showContent('customers')"><i class="fas fa-users"></i> Quản lý admin</a>
        <a href="#" onclick="showContent('reports')"><i class="fas fa-chart-line"></i> Báo cáo</a>
        <a href="#" onclick="logout()"><i class="fas fa-sign-out-alt"></i> Đăng xuất</a>
    </div>

    <div class="main-content">
        <div class="header">
            <h1>Quản Lý Cửa Hàng Bán Đồ Và Phụ Kiện Cho Thú Cưng</h1>
            <a href='index.aspx'>
                <img class="logo" src="../assets/images/logo.jpg" alt="" width="50" height="50">
            </a>
        </div>
        <!-- Nội dung trang chủ -->
        <div id="home" class="content active">
            <h2>Trang chủ</h2>
            <p>Chào mừng bạn đến với trang quản lý cửa hàng thú cưng.</p>
        </div>
        <!-- Nội dung quản lý sản phẩm -->
        <div id="products" class="content">
            <h2>Danh sách sản phẩm</h2>
            <button class="btn" onclick="openProductForm()">Thêm sản phẩm</button>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Tên sản phẩm</th>
                        <th>Thể loại</th>
                        <th>Giá</th>
                        <th>Stock</th>
                        <th>Miêu tả</th>
                        <th>Ảnh</th>
                        <th>IsAvailable</th>
                        <th>Giảm giá</th>
                        <th>Loại sp</th>
                        <th>Trọng lượng</th>
                        <th>Ảnh</th>
                        <td>Thao tác</td>
                    </tr>
                </thead>
                <tbody id="productTableBody" runat="server">

                </tbody>
            </table>
        </div>
        <!-- Nội dung quản lý người dùng -->
        <div id="users" class="content">
            <h2>Quản lý người dùng</h2>
            <button class="btn" onclick="openForm()">Thêm người dùng</button>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Họ tên</th>
                        <th>Password</th>
                        <th>Email</th>
                        <th>SĐT</th>
                        <th>Địa chỉ</th>
                        <td>Thao tác</td>
                    </tr>
                </thead>
                <tbody id="userTableBody" runat="server">

                </tbody>
            </table>
        </div>

        <!-- Nội dung quản lý tài khoản admin -->
        <div id="customers" class="content">
            <h2>Quản lý admin</h2>
            <p>Danh sách admin sẽ được hiển thị ở đây.</p>
        </div>

        <!-- Nội dung báo cáo -->
        <div id="reports" class="content">
            <h2>Báo cáo</h2>
            <p>Thông tin báo cáo sẽ được hiển thị ở đây.</p>
        </div>
    </div>
    <!-- Form thêm người dùng -->
    <div id="userForm" class="form-popup">
        <h2>Thêm người dùng</h2>
        <form action="admin.aspx" method="post">
            <label for="userId">ID Người dùng</label>
            <input type="text" id="userId" name="userId" required />
            <label for="fullName">Họ tên</label>
            <input type="text" id="fullName" name="fullName" required />
            <label for="password">Mật khẩu</label>
            <input type="password" id="password" name="password" required />
            <label for="email">Email</label>
            <input type="email" id="email" name="email" required />
            <label for="phoneNumber">Số điện thoại</label>
            <input type="tel" id="phoneNumber" name="phoneNumber" required />
            <label for="address">Địa chỉ</label>
            <input type="text" id="address" name="address" required />
            <button type="submit" name="action" value="addUser">Thêm người dùng</button>
            <button type="button" class="btn cancel" onclick="closeForm()">Hủy</button>
        </form>
    </div>
    
    <!-- Form sửa người dùng -->
    <div id="editUserForm" class="form-popup">
        <h2>Sửa người dùng</h2>
        <form action="admin.aspx" method="post">
            <input type="hidden" id="editUserId" name="userId" />
            <label for="editFullName">Họ tên</label>
            <input type="text" id="editFullName" name="fullName" required />
            <label for="editPassword">Mật khẩu</label>
            <input type="password" id="editPassword" name="password" required />
            <label for="editEmail">Email</label>
            <input type="email" id="editEmail" name="email" required />
            <label for="editPhoneNumber">Số điện thoại</label>
            <input type="tel" id="editPhoneNumber" name="phoneNumber" required />
            <label for="editAddress">Địa chỉ</label>
            <input type="text" id="editAddress" name="address" required />
            <button type="submit" name="action" value="editUser">Cập nhật</button>
            <button type="button" class="btn cancel" onclick="closeEditUserForm()">Hủy</button>
        </form>
    </div>

    <!-- Form thêm sản phẩm -->
    <div id="productForm" class="form-popup">
        <h2>Thêm sản phẩm mới</h2>
        <form action="admin.aspx" method="post">
            <label for="productId">ID Sản phẩm</label>
            <input type="text" id="productId" name="productId" required />
            <label for="addProductName">Tên sản phẩm</label>
            <input type="text" id="addProductName" name="productName" required />
            <label for="addCategory">Thể loại</label>
            <input type="text" id="addCategory" name="category" required />
            <label for="addPrice">Giá</label>
            <input type="number" id="addPrice" name="price" required />
            <label for="addStock">Stock</label>
            <input type="number" id="addStock" name="stock" required />
            <label for="addDescription">Miêu tả</label>
            <textarea id="addDescription" name="description" required></textarea>
            <label for="addImageUrl">Ảnh chính</label>
            <input type="text" id="addImageUrl" name="imageUrl" />
            <label for="addIsAvailable">Còn hàng</label>
            <select id="addIsAvailable" name="isAvailable">
                <option value="true" >Còn hàng</option>
                <option value="false">Hết hàng</option>
            </select>
            <label for="addDiscount">Giảm giá (%)</label>
            <input type="number" id="addDiscount" name="discount" />
            <label for="addTypeProduct">Loại sản phẩm</label>
            <select id="addTypeProduct" name="typeProduct">
                <option value="sale">sell</option>
                <option value="new">new</option>
            </select>
            <label for="addWeight">Trọng lượng (kg)</label>
            <input type="text" step="0.01" id="addWeight" name="listWeight" required />
            <label for="addListThumb">Ảnh kèm theo (cách nhau bằng dấu phẩy)</label>
            <input type="text" id="addListThumb" name="listThumb" placeholder="URL ảnh kèm theo" />
            <button type="submit" name="action" value="addProduct">Thêm sản phẩm</button>
            <button type="button" class="btn cancel" onclick="closeProductForm()">Hủy</button>
        </form>
    </div>

    <!-- Form sửa sản phẩm -->
    <div id="editProductForm" class="form-popup">
        <h2>Sửa sản phẩm</h2>
        <form action="admin.aspx" method="post">
            <input type="hidden" id="editProductId" name="productId" />
            <label for="editProductName">Tên sản phẩm</label>
            <input type="text" id="editProductName" name="productName" required />
            <label for="editCategory">Thể loại</label>
            <input type="text" id="editCategory" name="category" required />
            <label for="editPrice">Giá</label>
            <input type="number" id="editPrice" name="price" required />
            <label for="editStock">Stock</label>
            <input type="number" id="editStock" name="stock" required />
            <label for="editDescription">Miêu tả</label>
            <textarea id="editDescription" name="description" required></textarea>
            <label for="editImageUrl">Ảnh</label>
            <input type="text" id="editImageUrl" name="imageUrl" required />
            <label for="editIsAvailable">Còn hàng</label>
            <select id="editIsAvailable" name="isAvailable">
                <option value="true">Còn hàng</option>
                <option value="false">Hết hàng</option>
            </select>
            <label for="editDiscount">Giảm giá (%)</label>
            <input type="number" id="editDiscount" name="discount" />
            <label for="editTypeProduct">Loại sản phẩm</label>
            <select id="editTypeProduct" name="typeProduct">
                <option value="sale">sell</option>
                <option value="new">new</option>
            </select>
            <label for="editWeight">Trọng lượng (kg)</label>
            <input type="text" step="0.01" id="editWeight" name="weight" required />
            <label for="editListThumb">Ảnh kèm theo (cách nhau bằng dấu phẩy)</label>
            <input type="text" id="editListThumb" name="listThumb" placeholder="URL ảnh kèm theo" required />
            <button type="submit" name="action" value="editProduct">Cập nhật</button>
            <button type="button" class="btn cancel" onclick="closeEditProductForm()">Hủy</button>
        </form>
    </div>
</body>
</html>
