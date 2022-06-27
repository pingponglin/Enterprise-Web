<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="EditClass.aspx.cs" Inherits="ZY.Class.EditClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--引用日历JS--%>
    <script language="javascript" type="text/javascript" src="../My97DatePicker/WdatePicker.js"></script>
    <%--页面样式--%>
    <style>
        .EDITZTYS {
            width: 1300px;
            height: 600px;
            margin-left: 150px;
            margin-top: 100px;
        }
        /*同P中拓宽空间*/
        .TKKJ {
            margin-left:155px;
        }
        /*同P中最后一个拓宽空间*/
        .TKKJLAST {
        }
        /*输入框样式*/
        .SRK {
            margin-left: 10px;
            height: 30px;
            border-radius: 10px;
        }
            /*输入框触摸样式*/
            .SRK:hover {
                box-shadow: 1px 1px 20px #165e83;
                border-radius: 10px;
            }
        /*修改按钮样式*/
        .XGAN:hover {
            box-shadow: 1px 1px 20px #274a78;
        }
        /*返回主界面触摸样式*/
        .FHZJMAN:hover {
            box-shadow: 1px 1px 20px #274a78;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="EDITZTYS">
        <%--部门编号，部门名称--%>
        <p style="height: 70px; font-size: 28px;">
            <span>部门编号：</span>
            <%--限制只能输入正整数，部门编号最多为6位数--%>
            <asp:TextBox ID="Txt_classIDUPDATE" placeholder="请输入部门编号！" runat="server" CssClass="SRK" Style="font-size: 15px;" MaxLength="6" ReadOnly="True"></asp:TextBox>
            
            <span class="TKKJ">部门名称：</span>
            <asp:TextBox ID="Txt_classNameUPDATE" placeholder="请输入部门名称！" runat="server" CssClass="SRK" Style="font-size: 15px;"></asp:TextBox>
            
        </p>
        <%--创建时间，部门需求人数--%>
        <p style="height: 70px; font-size: 28px;">
            <span>创建时间：</span>
            <asp:TextBox ID="Txt_classTimeUPDATE" placeholder="请选择部门创建时间！" runat="server" CssClass="SRK" onclick="WdatePicker()" Style="font-size: 15px;"></asp:TextBox>
            
            <span style="position: relative; left: 100px;">
                <asp:Label ID="Label1" runat="server" Text="已有部门编号："></asp:Label>
                <asp:DropDownList ID="DropDownList1" CssClass="SRK" Style="font-size:15px;"  runat="server"></asp:DropDownList></span>
        </p>
        <%--部门已有人数，部门备注--%>
        <p style="height: 70px; font-size: 28px;">
            <span>部门已有人数：</span>
            <%--限制只能输入正整数，部门已有人数不能为负数--%>
            <asp:TextBox ID="Txt_classRecruitsedUPDATE" placeholder="请输入部门已有人数！" runat="server" CssClass="SRK" Style="font-size: 15px;" ReadOnly="True"></asp:TextBox>
            
            <span Style="position:relative;right:-45px;">
                <asp:Label ID="Label2" runat="server" Text="已有部门名称："></asp:Label>
                <asp:DropDownList ID="DropDownList2" CssClass="SRK" Style="font-size:15px;" runat="server"></asp:DropDownList>
            </span>
        </p>
        <p style="height: 70px; font-size: 28px;">
            <span>部门备注：</span>
            <asp:TextBox ID="Txt_classCommentUPDATE" placeholder="请输入部门备注！" runat="server" CssClass="SRK" Style="font-size: 15px;"></asp:TextBox>
            
            
        </p>
        <%--保存按钮--%>
        <asp:Button ID="BTN_UPDATE" class="XGAN" runat="server" Style="height: 40px; width: 120px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="保存修改" OnClick="BTN_UPDATE_Click" Font-Italic="False" BorderStyle="None" CommandArgument='<%# Eval("ClassID") %>' OnCommand="BTN_UPDATE_Command"/>
        <%--返回主界面按钮--%>
        <asp:Button ID="BTN_EDITBACKMAIN" class="FHZJMAN" runat="server" Style="height: 40px; width: 200px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="返回主界面" OnClick="BTN_EDITBACKMAIN_Click" BorderStyle="None" />
    </div>
</asp:Content>
