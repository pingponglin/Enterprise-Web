<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="PostAdd.aspx.cs" Inherits="ZY.Class.PostAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--页面样式--%>
    <style>
        /*整体样式*/
        .ADDZTYS {
            width: 1200px;
            height: 600px;
            margin-left: 140px;
            margin-top: 90px;
        }
        /*同P中拓宽空间*/
        .TKKJ1 {
            margin-left: 105px;
        }

        .TKKJ2 {
            margin-left: -130px;
        }
        /*同P中最后一个拓宽空间*/
        .TKKJLAST {
            margin-left:0px;
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
        /*新增按钮触摸样式*/
        .ADDAN:hover {
            box-shadow: 1px 1px 20px #274a78;
        }
        /*重置按钮触摸样式*/
        .CZAN:hover {
            box-shadow: 1px 1px 20px #274a78;
        }
        /*返回主界面触摸样式*/
        .FHZJMAN:hover {
            box-shadow: 1px 1px 20px #274a78;
        }
        /*日期选择*/
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ADDZTYS">
        <%--职位编号，职位名称--%>
        <p style="height: 100px; font-size: 28px;">
            <span>职位编号：</span>
            <%--限制只能输入正整数，职位编号最多为11位数--%>
            <asp:TextBox ID="Txt_postidADD" placeholder="请输入职位编号！" runat="server" CssClass="SRK" Style="font-size: 15px;" MaxLength="11"></asp:TextBox>
            <span class="TKKJ1">职位名称：</span>
            <asp:TextBox ID="Txt_postnameADD" placeholder="请输入职位名称！" runat="server" CssClass="SRK" Style="font-size: 15px;"></asp:TextBox>
            
        </p>
        <%--职位薪水，职位需求人数--%>
        <p style="height: 100px; font-size: 28px;">
            <span>职位薪水：</span>
            <%--限制只能输入正整数，职位薪水不能为负数--%>
            <asp:TextBox ID="Txt_postsalaryADD" placeholder="请输入职位薪水！" runat="server" CssClass="SRK" Style="font-size: 15px;"></asp:TextBox>
            
             <span style="position:relative;right:-50px;">
                <asp:Label ID="Label1" runat="server" Font-Size="28px" Text="已有职位编号："></asp:Label>
                <asp:DropDownList ID="DropDownList2" CssClass="SRK" Style="font-size:15px;" runat="server"></asp:DropDownList>
            </span> 
            
        </p>
        <%--职位已有人数，职位备注--%>
        <p style="height: 80px; font-size: 28px;">
            <%--<span>职位已有人数：</span>--%>
            <%--限制只能输入正整数，职位已有人数不能为负数--%>
            <%--<asp:TextBox ID="Txt_postrecruitsedADD" placeholder="请输入职位已有人数！" runat="server" CssClass="SRK" Style="font-size: 15px;" ReadOnly="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Txt_postrecruitsedADD" ErrorMessage="请勿留空!" ForeColor="Red" Font-Size="24px"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Txt_postrecruitsedADD"
                ErrorMessage="请输入正整数!" ForeColor="Red" Font-Size="24px" ValidationExpression="^([1-9]\d*|[0]{1,1})$" Style="position: relative; bottom: 35px; right: 290px;"></asp:RegularExpressionValidator>--%>
            <span class="TKKJLAST">职位备注：</span>
            <asp:TextBox ID="Txt_postcommentADD" placeholder="请输入职位备注！" runat="server" CssClass="SRK" Style="font-size: 15px;"></asp:TextBox>
            
            <span style="margin-left:105px;">部门编号：</span>
            <%--限制只能输入正整数，部门编号不能为负数--%>
            <asp:DropDownList ID="DropDownList1" runat="server" placeholder="" CssClass="SRK" Style="font-size: 15px;" ></asp:DropDownList>
            
        </p>
        <%--部门编号--%>
        <%--增加按钮--%>
        <asp:Button ID="BTN_ADD" class="ADDAN" runat="server" Style="height: 40px; width: 100px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="增加" OnClick="BTN_ADD_Click" />
        <%--重置按钮--%>
        <asp:Button ID="BTN_CZ" class="CZAN" runat="server" Style="height: 40px; width: 100px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="重置" OnClick="BTN_CZ_Click" />
        <%--返回主界面按钮--%>
        <asp:Button ID="BTN_ADDBACKMAIN" class="FHZJMAN" runat="server" Style="height: 40px; width: 200px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="返回主界面" OnClick="BTN_ADDBACKMAIN_Click" />
    </div>
</asp:Content>
