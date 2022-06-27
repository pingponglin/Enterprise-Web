<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="ZY.Class.EditPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--页面样式--%>
    <style>
        .EDITZTYS {
            width: 1200px;
            height: 600px;
            margin-left: 140px;
            margin-top: 90px;
        }
        /*同P中拓宽空间*/
        .TKKJ1 {
            margin-left: 130px;
        }

        .TKKJ2 {
            margin-left: -147px;
        }
        /*同P中最后一个拓宽空间*/
        .TKKJLAST {
            margin-left: 130px;
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
        <%--职位编号，职位名称--%>
        <p style="height: 80px; font-size: 28px;">
            <span>职位编号：</span>
            <%--限制只能输入正整数，职位编号最多为11位数--%>
            <asp:TextBox ID="Txt_PostIDUPDATE" placeholder="请输入职位编号！" runat="server" CssClass="SRK" ReadOnly="True"></asp:TextBox>
            <span class="TKKJ1">职位名称：</span>
            <asp:TextBox ID="Txt_PostNameUPDATE" placeholder="请输入职位名称！" runat="server" CssClass="SRK"></asp:TextBox>
            
        </p>
        <%--职位薪水，职位需求人数--%>
        <p style="height: 80px; font-size: 28px;">
            <span>职位薪水：</span>
            <%--限制只能输入正整数，职位薪水不能为负数--%>
            <asp:TextBox ID="Txt_PostSalaryUPDATE" placeholder="请输入职位薪水！" runat="server" CssClass="SRK"></asp:TextBox>
            
            <span class="TKKJLAST">职位备注：</span>
            <asp:TextBox ID="Txt_PostCommentUPDATE" placeholder="请输入职位备注！" runat="server" CssClass="SRK"></asp:TextBox>
            
            <%--<span class="TKKJ2">职位需求人数：</span>--%>
            <%--限制只能输入正整数，职位需求人数不能为负数--%>
            <%--<asp:TextBox ID="Txt_classRecruitsUPDATE" placeholder="请输入职位需求人数！" runat="server" CssClass="SRK"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Txt_classRecruitsUPDATE" ErrorMessage="请勿留空!" ForeColor="Red" Font-Size="24px"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="Txt_classRecruitsUPDATE"
                ErrorMessage="请输入正整数!" ForeColor="Red" Font-Size="24px" ValidationExpression="^[1-9]*[1-9][0-9]*$" Style="position: relative; bottom: 35px; right: 290px;"></asp:RegularExpressionValidator>--%>
        </p>
        <%--职位已有人数，职位备注--%>
        <p style="height: 80px; font-size: 28px;">
            <span>职位已有人数：</span>
            <%--限制只能输入正整数，职位已有人数不能为负数--%>
            <asp:TextBox ID="Txt_classRecruitsedUPDATE" placeholder="请输入职位已有人数！" runat="server" CssClass="SRK" ReadOnly="True"></asp:TextBox>
            <span style="position:relative;right:-20px;">
                <asp:Label ID="Label1" runat="server" Text="已有职位编号："></asp:Label>
                <asp:DropDownList ID="DropDownList2" CssClass="SRK" Style="font-size:15px;" runat="server"></asp:DropDownList>
            </span>
            
        </p>
        <%--部门编号--%>
        <p style="height: 80px; font-size: 28px;">
            <span>部门编号：</span>
            <%--限制只能输入正整数，部门编号不能为负数--%>
            <asp:DropDownList ID="DropDownList1" runat="server" placeholder="" CssClass="SRK" Style="font-size: 15px;" ></asp:DropDownList>
            
            
        </p>
        <%--保存按钮--%>
        <asp:Button ID="BTN_UPDATE" class="XGAN" runat="server" Style="height: 40px; width: 120px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="保存修改" OnClick="BTN_UPDATE_Click" />
        <%--返回主界面按钮--%>
        <asp:Button ID="BTN_EDITBACKMAIN" class="FHZJMAN" runat="server" Style="height: 40px; width: 200px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="返回主界面" OnClick="BTN_EDITBACKMAIN_Click" />
    </div>
</asp:Content>
