<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="StaffAdd.aspx.cs" Inherits="ZY.Staff.StaffAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .a,.b,.c,.post,.e{
           margin-left:140px;
           line-height:80px;
       }
       .c{
            margin-left:110px;
       }
       .TextBox1,.TextBox2,.TextBox3,.TextBox4,.TextBox5,.TextBox6，.TextBox7，.TextBox8{
           width:150px;
           height:25px;
       }
       .btn1{
           margin-left:20px;
             width:100px;
           height:35px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p class="a"><asp:Label ID="Label1" runat="server" Text="姓名:"></asp:Label><asp:TextBox ID="TextBox1" CssClass="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="性别:"></asp:Label><asp:DropDownList ID="ddlSex" CssClass="TextBox2"  runat="server">
        <asp:ListItem>*请选择*</asp:ListItem>
        <asp:ListItem>男</asp:ListItem>
        <asp:ListItem>女</asp:ListItem> 
        </asp:DropDownList>
    </p>
    <p class="b"><asp:Label ID="Label3" runat="server" Text="年龄:"></asp:Label><asp:TextBox ID="TextBox3" CssClass="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="学历:"></asp:Label><asp:DropDownList ID="DropDownList1" CssClass="TextBox4"  runat="server">
        <asp:ListItem>*请选择*</asp:ListItem>
        <asp:ListItem>本科</asp:ListItem>
        <asp:ListItem>专科</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p class="c">
        <asp:Label ID="Label5" runat="server" Text="身份证号:"></asp:Label><asp:TextBox ID="TextBox5" CssClass="TextBox5" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="联系电话:"></asp:Label><asp:TextBox ID="TextBox6" CssClass="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p class="post">
        <asp:Label ID="Label7" runat="server" Text="部门:"></asp:Label><asp:DropDownList ID="DropDownList2" CssClass="TextBox5"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
    <asp:Label ID="Label8" runat="server" Text="职位:"></asp:Label><asp:DropDownList ID="DropDownList3"  CssClass="TextBox5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p class="e"><asp:Button ID="Button3" CssClass="btn1" runat="server" Text="重置" OnClick="Button3_Click" /><asp:Button ID="Button1" CssClass="btn1" runat="server" Text="添加" OnClientClick="return confirm('确定添加吗?')" OnClick="Button1_Click" /><asp:Button ID="Button2" CssClass="btn1" runat="server" Text="返回" OnClick="Button2_Click" /></p>
</asp:Content>
