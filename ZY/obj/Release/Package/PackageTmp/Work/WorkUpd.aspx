<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="WorkUpd.aspx.cs" Inherits="ZY.Work.WorkUpd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/jquery-3.5.1.js"></script>
    <style>
        .a{
            margin-left:200px;
            line-height:90px;
        }
        .a11{
            margin-left:205px;
        }
        .b{
            margin-left:400px;
        }
        .b11{
            margin-left:355px;
        }
        .b12{
            margin-left:388px;
        }
        .b13{
            margin-left:236px;
        }
        .c11{
            height:30px;
            width:200px;
        }
        .z{
            margin-left:405px;
        }
        .btn1{
            background-color:dodgerblue;
            cursor:pointer;
            width:100px;
            height:40px;
            border:none;
            margin-left:450px;
            margin-top:100px;
            color:white;
        }
        .btn2{
            background-color:red;
            cursor:pointer;
            width:100px;
            height:40px;
            border:none;
            margin-left:100px;
            color:white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" CssClass="a a11" runat="server" Text="姓名："></asp:Label><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label5" CssClass="b z" runat="server" Text="入职日期："></asp:Label><asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" CssClass="a" runat="server" Text="身份证号："></asp:Label><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label7" CssClass="b b11" runat="server" Text="联系电话："></asp:Label><asp:Label ID="Label8" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label9" CssClass="a a11" runat="server" Text="部门：">
        </asp:Label>
        <asp:DropDownList ID="DropDownList2" CssClass="TextBox5 c11"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="Label11" CssClass="b b13" runat="server" Text="职位：">
        </asp:Label>
        <asp:DropDownList ID="DropDownList3"  CssClass="TextBox5 c11" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" CssClass="btn1" runat="server" Text="修改" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn2" runat="server" Text="返回" OnClick="Button2_Click" />
    </p>
</asp:Content>
