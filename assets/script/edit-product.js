function deleteProduct(productId) {
    if (confirm("Bạn có chắc chắn muốn xóa sản phẩm này?")) {
        window.location.href = `admin.aspx?deleteId=${productId}`;
    }
}
function deleteUser(userId) {
    if (confirm("Bạn có chắc chắn muốn xóa người dùng này?")) {
        window.location.href = `admin.aspx?deleteId_User=${userId}`;
    }
}
function showContent(contentId) {
    // Ẩn tất cả các phần nội dung
    var contents = document.getElementsByClassName("content");
    for (var i = 0; i < contents.length; i++) {
        contents[i].classList.remove("active");
    }

    // Hiển thị phần nội dung được chọn
    document.getElementById(contentId).classList.add("active");

    // Cập nhật URL để giữ tab hiện tại
    window.history.pushState(null, null, 'admin.aspx?currentTab=${contentId}');
}

// Gọi hàm này khi trang được tải
window.onload = function () {
    const urlParams = new URLSearchParams(window.location.search);
    const currentTab = urlParams.get('currentTab'); // Đặt mặc định là 'products'
    showContent(currentTab);
};
function openForm() {
    document.getElementById("userForm").style.display = "block";
}

function closeForm() {
    document.getElementById("userForm").style.display = "none";
}
function editUser(userId, fullName, password, email, phoneNumber, address) {
    document.getElementById("editUserId").value = userId;
    document.getElementById("editFullName").value = fullName;
    document.getElementById("editPassword").value = password;
    document.getElementById("editEmail").value = email;
    document.getElementById("editPhoneNumber").value = phoneNumber;
    document.getElementById("editAddress").value = address;
    document.getElementById("editUserForm").style.display = "block";
}

function closeEditUserForm() {
    document.getElementById("editUserForm").style.display = "none";
}
function openProductForm() {
    document.getElementById("productForm").style.display = "block";
}

function closeProductForm() {
    document.getElementById("productForm").style.display = "none";
}
function editProduct(productId, productName, category, price, stock, description, imageUrl, isAvailable, discount, typeProduct, weight, listThumb) {
    document.getElementById("editProductId").value = productId;
    document.getElementById("editProductName").value = productName;
    document.getElementById("editCategory").value = category;
    document.getElementById("editPrice").value = price;
    document.getElementById("editStock").value = stock;
    document.getElementById("editDescription").value = description;
    document.getElementById("editImageUrl").value = imageUrl;
    document.getElementById("editIsAvailable").value = isAvailable === "true" ? "true" : "false";
    document.getElementById("editDiscount").value = discount;
    document.getElementById("editTypeProduct").value = typeProduct;
    document.getElementById("editWeight").value = weight.split(",");
    document.getElementById("editListThumb").value = listThumb.split(",");
    document.getElementById("editProductForm").style.display = "block";
}

function closeEditProductForm() {
    document.getElementById("editProductForm").style.display = "none";
}
function logout() {
    // Thực hiện điều hướng tới trang đăng xuất
    if (confirm("Bạn có chắc muốn đăng xuất?")) {
        window.location.href = "logout.aspx";
    }
}
