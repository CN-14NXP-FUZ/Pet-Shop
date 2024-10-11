<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pet_Shop.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: white;
        }
        .container {
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            background-color: white;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .container h2 {
            text-align: center;
            margin-bottom: 20px;
            color: #522f1f
        }
        .container hr{
            width:8%;
            color: black;
        }
        .input-group {
            margin-bottom: 15px;
        }
        .input-group label {
            display: block;
            margin-bottom: 5px;
        }
        .input-group input {
            width: 90%;
            padding: 10px;
            border-radius: 4px;
        }
        .login-button {
            width: 30%;
            padding: 10px;
            margin-left: 50px;
            background-color: #522f1f;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .login-button:hover {
            background-color: white;
            color: #522f1f;
            border: 1px solid #522f1f;
        }
        .process-group {
            display: flex;
            align-items: center; 
        }
        .login-button {
            margin-right: 20px;
        }
        .link-group {
            display: flex;
            flex-direction: column;
        }
        .link-group a {
            text-decoration: none;
            color: #522f1f;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
         <div class="header">

         </div>
         <div class="container">
            <h2>Đăng nhập</h2>
            <hr />
            <div class="input-group">
                <label for="email">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server"  TextMode="Email" BackColor="#E7E7E7" BorderStyle="None" />
            </div>
            <div class="input-group">
                <label for="password">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" BackColor="#E7E7E7" BorderStyle="None" />
            </div>
            <div class="process-group">
                <asp:Button ID="btnLogin" runat="server" CssClass="login-button" Text="ĐĂNG NHẬP" />
                <div class="link-group">
                    <a href="#">Quên mật khẩu?</a>
                    hoặc <a href="#">Đăng ký</a>
                </div>
            </div>
         </div>
         <div class ="footer">

         </div>
    </form>
</body>
</html>
