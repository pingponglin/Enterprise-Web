<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="LeaveHome.aspx.cs" Inherits="ZY.Leave.LeaveHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
        .top{
             background-color:white;
            height:40px;
            width:98%;
            margin-top:10px;
            margin-left:10px;
        }
        .center{
            background-color:white;
            height:40px;
            width:98%;
            margin-top:10px;
            margin-left:10px;
        }
        .add{
            margin-left:10px;
            margin-top:7px;
            height:30px;
            width:90px;
            border-radius:5px;
            cursor:pointer;
            border-color:white;
            background-color:#337AB7;
            color:white;
        }
        .add0,.add1,.add2{
            background-color:white;
            width:100px;
            height:40px;
            color:gray;
            margin-left:20px;
            border:none;
            border-color:white;
            cursor:pointer;
        }
        .buttom{
            margin-left:10px;
            margin-top:2px;
            width:1276px;
        }
        .s{
             margin-left:800px;
             line-height:44px;
        }
        .sousuo{
            height:25px;
            width:230px;
           
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
        .cz{
            background-color:#5CB85C;
            width:50px;
            height:30px;
            border:none;
            margin-left:60px;
            color:white;
            border-radius:5px;
            cursor:pointer;
        }
        .color1{
            background-color:lightgray;
            box-shadow:0px 0px 5px gray;
        }
        .GridView1,.GridView2{
            cursor:pointer;
        }
    </style>
     <script src="../JS/jquery-3.5.1.js"></script>
    <script>
        $(function () {
            //鼠标移入事件
            $('.link').mouseover(function () {
                $(this).addClass('color1');
            })
           //鼠标移除事件
            $('.link').mouseout(function () {
                $(this).removeClass('color1');
            })
            $('.add,.cz').mouseover(function () {
                $(this).addClass('color1');
            })
             $('.add,.cz').mouseout(function () {
                $(this).removeClass('color1');
            })
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sum">
        <div class="top">
            <asp:Label ID="Label1" runat="server" CssClass="s" Text="输入身份证号："></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="sousuo" runat="server"></asp:TextBox><asp:LinkButton ID="LinkButton1" CssClass="link" runat="server" OnClick="LinkButton1_Click" ><asp:Image ID="Image1" CssClass="linkimg" runat="server" ImageUrl="~/Image/search.png" /></asp:LinkButton>
            <asp:Button ID="Button3" CssClass="cz" runat="server" Text="重置" OnClick="Button3_Click" />
        </div>
        <div class="center">
            <asp:Button ID="Button6" CssClass="add0" runat="server" Text="所有员工" OnClick="Button6_Click" />
            <asp:Button ID="Button4" CssClass="add1" runat="server" Text="离职员工" OnClick="Button4_Click" />
            <asp:Button ID="Button5" CssClass="add2" runat="server" Text="辞退员工"  BorderColor="White" OnClick="Button5_Click"/>
        </div>
        <div class="buttom">
             <asp:GridView ID="GridView0" CssClass="GridView1" runat="server" AutoGenerateColumns="False" Font-Bold="False" BorderColor="Silver" AllowPaging="True" OnPageIndexChanging="GridView0_PageIndexChanging" OnRowDataBound="GridView0_RowDataBound">
        <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField DataField="Fuhao" HeaderText="□">
            <ControlStyle Font-Size="X-Large" />
            <FooterStyle Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <HeaderStyle Font-Bold="True" Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="编号" DataField="EntryID" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="姓名" DataField="EntryName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="性别" DataField="EntryGender" >
            <ItemStyle Width="70px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="EntryAge" >
            <ItemStyle Width="70px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="学历" DataField="EntrySchool" >
            <ItemStyle Width="70px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="EntryTime" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="EntryIDcard" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="EntryPhone" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" CssClass="cz" runat="server" CausesValidation="false" OnCommand="Button1_Command" CommandArgument='<%# Eval("EntryID") %>' OnClientClick="return confirm('确定该员工离职吗?')" CommandName="" Text="离职" />
                </ItemTemplate>
                <ControlStyle BackColor="#5BC0DE" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="None" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Outset" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
             <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" CssClass="cz" runat="server" CausesValidation="false" CommandName="" CommandArgument='<%# Eval("EntryID") %>' OnClientClick="return confirm('确定辞退该员工吗?')" OnCommand="Button2_Command" Text="辞退" />
                </ItemTemplate>
                <ControlStyle BackColor="orange" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle ForeColor="#FF6600" />
        <HeaderStyle Font-Bold="False" Font-Overline="False" Font-Size="Small" Height="40px" BackColor="#CCCCCC" Font-Names="Sitka Display" HorizontalAlign="Center" VerticalAlign="Middle" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" />
        <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#FF6699" />
</asp:GridView>
            <asp:GridView ID="GridView1" CssClass="GridView1" runat="server" AutoGenerateColumns="False" Font-Bold="False" BorderColor="Silver" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
        <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField DataField="Fuhao" HeaderText="□">
            <ControlStyle Font-Size="X-Large" />
            <FooterStyle Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <HeaderStyle Font-Bold="True" Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="编号" DataField="EntryID" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="姓名" DataField="EntryName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="性别" DataField="EntryGender" >
            <ItemStyle Width="70px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="EntryAge" >
            <ItemStyle Width="70px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="学历" DataField="EntrySchool" >
            <ItemStyle Width="70px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="EntryTime" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="EntryIDcard" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="EntryPhone" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" CssClass="cz" runat="server" CausesValidation="false" CommandArgument='<%# Eval("EntryID") %>' CommandName="" OnCommand="Button1_Command1" OnClientClick="return confirm('确定由离职转为辞退吗？')" Text="转为辞退" />
                </ItemTemplate>
                <ControlStyle BackColor="#5BC0DE" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="None" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Outset" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
             <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" CssClass="cz" runat="server" CausesValidation="false" CommandName="" CommandArgument='<%# Eval("EntryID") %>' OnCommand="Button2_Command1" OnClientClick="return confirm('确定取消离职吗?')" Text="取消离职" />
                </ItemTemplate>
                <ControlStyle BackColor="red" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle ForeColor="#FF6600" />
        <HeaderStyle Font-Bold="False" Font-Overline="False" Font-Size="Small" Height="40px" BackColor="#CCCCCC" Font-Names="Sitka Display" HorizontalAlign="Center" VerticalAlign="Middle" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" />
        <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#FF6699" />
</asp:GridView>
            <asp:GridView ID="GridView2" CssClass="GridView2" runat="server" AutoGenerateColumns="False" Font-Bold="False" BorderColor="Silver" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" OnRowDataBound="GridView2_RowDataBound">
        <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField DataField="Fuhao" HeaderText="□">
            <ControlStyle Font-Size="X-Large" />
            <FooterStyle Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <HeaderStyle Font-Bold="True" Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="编号" DataField="EntryID" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="姓名" DataField="EntryName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="性别" DataField="EntryGender" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="EntryAge" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="学历" DataField="EntrySchool" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="EntryTime" >
            <ItemStyle Width="180px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="EntryIDcard" >
            <ItemStyle Width="188px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="EntryPhone" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" CssClass="cz" runat="server" CausesValidation="false" CommandArgument='<%# Eval("EntryID") %>' CommandName="" OnCommand="Button1_Command2" OnClientClick="return confirm('确定由辞退转为离职吗？')" Text="转为离职" />
                </ItemTemplate>
                <ControlStyle BackColor="#5BC0DE" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="None" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Outset" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" CssClass="cz" runat="server" CausesValidation="false" OnCommand="Button1_Command3" CommandArgument='<%# Eval("EntryID") %>' CommandName="" OnClientClick="return confirm('确定取消辞退吗?')" Text="取消辞退" />
                </ItemTemplate>
                <ControlStyle BackColor="red" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="None" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Outset" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle ForeColor="#FF6600" />
        <HeaderStyle Font-Bold="False" Font-Overline="False" Font-Size="Small" Height="40px" BackColor="#CCCCCC" Font-Names="Sitka Display" HorizontalAlign="Center" VerticalAlign="Middle" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" />
        <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#FF6699" />
</asp:GridView>
        </div>
    </div>
</asp:Content>
