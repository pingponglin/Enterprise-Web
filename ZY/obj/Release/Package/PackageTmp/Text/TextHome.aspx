<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="TextHome.aspx.cs" Inherits="ZY.Text.TextHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/jquery-3.5.1.js"></script>
    <script>
        $(function () {
            //鼠标移入事件
            $('.link1').mouseover(function () {
                $(this).addClass('color1');
            })
           //鼠标移除事件
            $('.link1').mouseout(function () {
                $(this).removeClass('color1');
            })
        })
    </script>
    <style>
          .cz{
            background-color:#5CB85C;
            width:50px;
            height:30px;
            border:none;
            margin-left:50px;
            color:white;
            border-radius:5px;
            cursor:pointer;
        }
         .top{
            background-color:white;
            height:40px;
            width:98%;
            margin-top:10px;
            margin-left:10px;
        }
         .link{
            padding-right:12px;
            padding-left:3px;
            border-bottom-right-radius:5px;
            border-top-right-radius:5px;
            margin-top:7px;
            position:absolute;
            background-color:#5CB85C;
        }
         .linkimg{
            width:30px;
            height:25px;
        }
         .s{
             margin-left:780px;
             line-height:44px;
        }
           .sousuo{
            height:30px;
            width:230px;
        }
           .re1,.re2,.re3{
               height:150px;
               width:1277px;
               background-color:white;
               margin-left:10px;
               color:black;
           }
           .re1{
               margin-top:10px;
               border-radius:10px;
           }
           .re2,.re3{
               margin-top:10px;
               border-radius:10px;
           }
            .btn1{
            background-color:dodgerblue;
            cursor:pointer;
            width:100px;
            height:40px;
            border:none;
            margin-left:430px;
            margin-top:100px;
            color:white;
            border-radius:5px;
        }
        .btn2{
            background-color:dodgerblue;
            cursor:pointer;
            width:100px;
            height:40px;
            border:none;
            margin-left:100px;
            color:white;
            border-radius:5px;
        }
        .btn3{
            background-color:#5CB85C;
            cursor:pointer;
            width:100px;
            height:40px;
            border:none;
            margin-left:100px;
            color:white;
            border-radius:5px;
        }
        .color1{
            background-color:lightgray;
            box-shadow:0px 0px 5px gray;
        }
        .re1 p{
            line-height:37px;
            margin-left:150px;
        }
        .t1{
            margin-left:100px;
        }
        .t2{
            margin-left:198px;
        }
        .t3{
            margin-left:200px;
        }
        .t22{
            margin-left:100px;
        }
        .t23{
            margin-left:186px;
        }
        .center{
            height:450px;
               width:1277px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="top">
        <asp:Label ID="Label1" runat="server" CssClass="s" Text="输入身份证号："></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="sousuo" runat="server"></asp:TextBox><asp:LinkButton ID="LinkButton1" CssClass="link" runat="server" OnClick="LinkButton1_Click"><asp:Image ID="Image1" CssClass="linkimg" runat="server" ImageUrl="~/Image/search.png" /></asp:LinkButton>
            <asp:Button ID="Button3" CssClass="cz" runat="server" Text="重置" OnClick="Button3_Click"/>
    </div>
    <div class="center">
        <asp:Panel ID="Panel1" CssClass="re1" runat="server">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <p><span class="t1">姓名：<%#Eval("TextName") %></span><span class="t2">旧部门：<%#Eval("TextClassID") %></span><span class="t3">新部门：<%#Eval("TextNewClassID") %></span></p>
                    <p><span class="t1">时间：<%#Eval("TextTime") %></span><span class="t22">旧职位：<%#Eval("TextPostID") %></span><span class="t23">新职位：<%#Eval("TextNewPostID") %></span></p>
                    <p><span class="t1">身份证号：<%#Eval("TextIDcard") %></span></p>
                </ItemTemplate>
            </asp:Repeater>
        </asp:Panel>
        <asp:Panel ID="Panel2" CssClass="re2" runat="server"></asp:Panel>
        <asp:Panel ID="Panel3" CssClass="re3" runat="server"></asp:Panel>
    </div>
    <div class="bottom">
        <asp:Button ID="Button1" CssClass="btn1 link1" runat="server" Text="上一页" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" CssClass="btn2 link1" runat="server" Text="下一页" OnClick="Button2_Click"/>
        <asp:Button ID="Button4" CssClass="btn3 link1" runat="server" Text="返回" OnClick="Button4_Click"/>
    </div>
</asp:Content>
