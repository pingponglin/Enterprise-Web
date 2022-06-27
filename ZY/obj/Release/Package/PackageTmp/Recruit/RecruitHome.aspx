<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="RecruitHome.aspx.cs" Inherits="ZY.Recruit.RecruitHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" CssClass="GridView1" runat="server" AutoGenerateColumns="False" Font-Bold="False" ForeColor="#666666" AllowCustomPaging="True" BackColor="White">
        <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField HeaderText="编号" DataField="StaffID" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="姓名" DataField="StaffName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="性别" DataField="StaffGender" >
            <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="StaffAge" >
            <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="学历" DataField="StaffSchool" >
            <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="StaffTime" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="StaffIDcard" >
            <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="StaffPhone" >
            <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="" Text="修改" />
                </ItemTemplate>
                <ControlStyle BackColor="#00CC66" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="100px" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" CausesValidation="false" CommandName="" OnClientClick="return confirm('确定删除吗?')" Text="删除" />
                </ItemTemplate>
                <ControlStyle BackColor="#6666FF" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle ForeColor="#FF6600" />
        <HeaderStyle Font-Bold="False" Font-Overline="False" Font-Size="Smaller" Height="40px" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" />
        <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#FF6699" />
</asp:GridView>
</asp:Content>
