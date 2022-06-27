<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loging.aspx.cs" Inherits="ZY.Loging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="pragma" content="no-cache" />
    <meta http-equiv="cache-control" content="no-cache" />
    <meta http-equiv="expires" content="0" />
    <title>登录界面</title>
	<script src="JS/jquery-3.5.1.js"></script>
	<script src="layer/layer.js"></script>
    <link rel="stylesheet" href="Font/style.css" />
    <link rel="stylesheet" href="Font/SYSFrame.css" />
    <link rel="stylesheet" href="Font/moldbox.css" />
	<script>
		function D() {
            layer.open({
                content: '登录失败',
                scrollbar: false
			});
		}
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="left">
                <div class="header">
                    <h2 class="animation a1">欢迎回来</h2>
                </div>
                <div class="form">
                    <asp:TextBox ID="name" runat="server" class="form-field animation a3" placeholder="用户名"></asp:TextBox>
                    <asp:TextBox ID="t_pwd" runat="server" TextMode="Password" class="form-field animation a4" placeholder="密码"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="登录" class="a6 btn bg-bule padding10" OnClick="Button1_Click" />
                </div>
            </div>
            <div class="right"></div>
        </div>

    </form>
	
</body>
</html>
