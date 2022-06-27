<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="ClassAdd.aspx.cs" Inherits="ZY.Class.ClassAdd1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript" src="../My97DatePicker/WdatePicker.js"></script>

    <%--页面样式--%>
    <style>
        /*整体样式*/
        .ADDZTYS {
            width: 1300px;
            height: 600px;
            margin-left: 150px;
            margin-top: 100px;
        }
        /*同P中拓宽空间*/
        .TKKJ1 {
            margin-left: 155px;
        }
        /*同P中最后一个拓宽空间*/
        .TKKJLAST {
            margin-left: 10px;
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
        .button, input, optgroup, select, textarea {
            margin: 0;
            font-family: inherit;
            font-size: inherit;
            line-height: inherit;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--整体--%>
    <div class="ADDZTYS">
        <%--部门编号，部门名称--%>
        <p style="height: 80px; font-size: 28px;">
            <span>部门编号：</span>
            <%--限制只能输入正整数，部门编号最多为6位数--%>
            <asp:TextBox ID="Txt_classidADD" placeholder="请输入部门编号！" runat="server" CssClass="SRK" Style="font-size: 15px;" MaxLength="6"></asp:TextBox>
            
            <span class="TKKJ1">部门名称：</span>
            <asp:TextBox ID="Txt_classnameADD" placeholder="请输入部门名称！" runat="server" CssClass="SRK" Style="font-size: 15px;"></asp:TextBox>
            
        </p>
        <%--创建时间，部门需求人数--%>
        <p style="height: 80px; font-size: 28px;">
            <span>创建时间：</span>
            <asp:TextBox ID="Txt_classtimeADD" placeholder="请选择部门创建时间！" runat="server" CssClass="SRK" onclick="WdatePicker()" Style="font-size: 15px;"></asp:TextBox>
            
            <span style="position: relative; left: 100px;">
                <asp:Label ID="Label3" runat="server" Text="已有部门编号："></asp:Label>
                <asp:DropDownList ID="DropDownList1" CssClass="SRK" Style="font-size:15px;"  runat="server"></asp:DropDownList></span>
        </p>
        <%--部门已有人数，部门备注--%>
        <p style="height: 80px; font-size: 28px;">
            <%--部门备注十个字以内--%>
            <span class="TKKJLAST">部门备注：</span>
            <asp:TextBox ID="Txt_classcommentADD" placeholder="请输入部门备注！" runat="server" CssClass="SRK" Style="font-size: 15px;" MaxLength="10"></asp:TextBox>
            
            <span Style="position:relative;left:90px;">
                <asp:Label ID="Label1" runat="server" Text="已有部门名称："></asp:Label>
                <asp:DropDownList ID="DropDownList2" CssClass="SRK" Style="font-size:15px;" runat="server"></asp:DropDownList>
            <%--<span>部门已有人数：</span>--%>
            <%--限制只能输入正整数，部门已有人数不能为负数--%>
          <%--  <asp:TextBox ID="Txt_classrecruitsedADD" placeholder="请输入部门已有人数！" runat="server" CssClass="SRK" Style="font-size: 15px;" ReadOnly="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Txt_classrecruitsedADD" ErrorMessage="请勿留空!" ForeColor="Red" Font-Size="24px"></asp:RequiredFieldValidator>--%>
           <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Txt_classrecruitsedADD"
                ErrorMessage="请输入正整数!" ForeColor="Red" Font-Size="24px" ValidationExpression="^([1-9]\d*|[0]{1,1})$" Style="position: relative; bottom: 35px; right: 290px;"></asp:RegularExpressionValidator>--%>
            <%--<span style="position: relative; left: 100px;">
                <asp:Label ID="Label1" runat="server" Text="已有部门编号："></asp:Label>
                <asp:DropDownList ID="DropDownList1" CssClass="SRK" Style="font-size:15px;"  runat="server"></asp:DropDownList></span>--%>
        </p>
       
        <%--下方按钮--%>
        <%--增加按钮--%>
        <asp:Button ID="BTN_ADD" class="ADDAN" runat="server" Style="height: 40px; width: 100px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="增加" OnClick="BTN_ADD_Click" BorderStyle="None" />
        <%--重置按钮--%>
        <asp:Button ID="BTN_CZ" class="CZAN" runat="server" Style="height: 40px; width: 100px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="重置" OnClick="BTN_CZ_Click" />
        <%--返回主界面按钮--%>
        <asp:Button ID="BTN_ADDBACKMAIN" class="FHZJMAN" runat="server" Style="height: 40px; width: 200px; font-size: 24px; border-radius: 15px; background-color: #2a4073; color: white; margin-left: 60px;" Text="返回主界面" OnClick="BTN_ADDBACKMAIN_Click" />
    </div>
</asp:Content>
