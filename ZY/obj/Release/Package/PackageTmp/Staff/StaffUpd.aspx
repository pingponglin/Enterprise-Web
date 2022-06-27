<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="StaffUpd.aspx.cs" Inherits="ZY.Staff.StaffUpd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/jquery-3.5.1.js"></script>
    <script>
        $(function () {
            //鼠标移入事件
            $('.z1').mouseover(function () {
                $(this).addClass('color1');
            })
           //鼠标移除事件
            $('.z1').mouseout(function () {
                $(this).removeClass('color1');
            })
            $('.z2').mouseover(function () {
                $(this).addClass('color1');
            })
             $('.z2').mouseout(function () {
                $(this).removeClass('color1');
            })
             $('.z3').mouseover(function () {
                $(this).addClass('color1');
            })
             $('.z3').mouseout(function () {
                $(this).removeClass('color1');
            })
        })
    </script>
    <style>
        .color1{
            background-color:lightgray;
            box-shadow:0px 0px 5px gray;
        }
       .a,.b,.c,.post,.e{
           margin-left:140px;
           line-height:80px;
       }
       .c{
            margin-left:110px;
       }
       .TextBox1,.TextBox2,.TextBox3,.TextBox4,.TextBox5,.TextBox6，.TextBox7，.TextBox8{
           width:350px;
           height:25px;
           margin-left:10px;
       }
       .btn1{
           margin-left:20px;
             width:100px;
           height:35px;
       }
       .a11,.b11{
           margin-left:90px;
       }
       .c11{
           margin-left:62px;
       }
       .z1,.z2,.z3{
           margin-top:170px;
           cursor:pointer;
           color:white;
       }
       .z1{
           background-color:dodgerblue;
           border:none;
           margin-left:270px;
       }
       .z2{
           background-color:lightblue;
           border:none;
           margin-left:30px;
       }
       .z3{
           background-color:red;
           border:none;
           margin-left:30px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="a"><asp:Label ID="Label1" runat="server" Text="姓名:"></asp:Label><asp:TextBox ID="TextBox1" CssClass="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" CssClass="a11" runat="server" Text="性别:"></asp:Label><asp:DropDownList ID="ddlSex" CssClass="TextBox2"  runat="server">
        <asp:ListItem>*请选择*</asp:ListItem>
        <asp:ListItem>男</asp:ListItem>
        <asp:ListItem>女</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p class="b"><asp:Label ID="Label3" runat="server" Text="年龄:"></asp:Label><asp:TextBox ID="TextBox3" CssClass="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" CssClass="b11" runat="server" Text="学历:"></asp:Label><asp:DropDownList ID="DropDownList1" CssClass="TextBox4"  runat="server">
        <asp:ListItem>*请选择*</asp:ListItem>
        <asp:ListItem>本科</asp:ListItem>
        <asp:ListItem>专科</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p class="c">
        <asp:Label ID="Label5" runat="server" Text="身份证号:"></asp:Label><asp:TextBox ID="TextBox5" CssClass="TextBox5" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" CssClass="c11" runat="server" Text="联系电话:"></asp:Label><asp:TextBox ID="TextBox6" CssClass="TextBox5" runat="server"></asp:TextBox>
    </p>
    <%--<p class="post">
        <asp:Label ID="Label7" runat="server" Text="部门:"></asp:Label><asp:DropDownList ID="DropDownList2" CssClass="TextBox5"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
    <asp:Label ID="Label8" runat="server" Text="职位:"></asp:Label><asp:DropDownList ID="DropDownList3"  CssClass="TextBox5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
        </asp:DropDownList>
    </p>--%>
    <p class="e"><asp:Button ID="Button3" CssClass="btn1 z1" runat="server" Text="重置" OnClick="Button3_Click" /><asp:Button ID="Button1" CssClass="btn1 z2" runat="server" Text="修改" OnClick="Button1_Click" /><asp:Button ID="Button2" CssClass="btn1 z3" runat="server" Text="返回" OnClick="Button2_Click" /></p>
</asp:Content>
