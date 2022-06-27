<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="StaffHome.aspx.cs" Inherits="ZY.Staff.StaffHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .suosou{
            padding-top:5px;
            padding-bottom:5px;
             display:flex;
             background-color:white;
        }
         .a,.add{
           font-weight:900;
            cursor:pointer;
           margin-left:50px;
       }
       .GridView1,.GridView2{
             margin-top:10px;
             cursor:pointer;
             margin-left:10px;
             margin-top:2px;
             width:1276px;
       }
        .btn1{
             cursor:pointer;
        }
       .name{
           width:60px;
           height:37px;
           text-align:center;
           line-height:35px;
           color:gray;
           font-weight:500;
           border-top-left-radius:8px;
           border-bottom-left-radius:8px;
           margin-left:20px;
       }
       .id{
           width:100px;
           height:37px;
           text-align:center;
           line-height:35px;
           color:gray;
           font-weight:500;
           border-top-left-radius:8px;
           border-bottom-left-radius:8px;
           margin-left:20px;
           padding-left:5px;
       }
       .txtname{
           width:100px;
           height:37px;
           border-bottom-right-radius:8px;
           border-top-right-radius:8px;
       }
       .daohang{
           display:flex;
       }
       .daohang1{
           height:36px;
           width:70px;
           background-color:#337AB7;
           margin-left:20px;
           border-radius:6px;
           color:white;
           cursor:pointer;
       }
       .daohang5{
            width:130px;
            background-color:#5CB85C;
       }
       .img{
           position:absolute;
           width:25px;
           height:25px;
           margin-top:5px;
           margin-left:5px;
       }
       .daohang span{
           margin-left:27px;
           padding-top:7px;
           position:absolute;
       }
       .linkbtn{
           width:90px;
           height:36px;
           background-color:white;
       }
       .cz{
           border-radius:10px;
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
        .add1,.add2{
            background-color:white;
            width:100px;
            height:40px;
            color:gray;
            margin-left:20px;
            border:none;
            border-color:white;
            cursor:pointer;
        }
        .color1{
            background-color:lightgray;
            box-shadow:0px 0px 5px gray;
        }
    </style>
    <script src="../JS/jquery-3.5.1.js"></script>
    <script>
          
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
    <div class="sum">
         <div class="suosou">
             <asp:Label ID="Label1" runat="server" class="name" Text="姓名：" BackColor="#EEEEEE" BorderStyle="None" Font-Size="Medium"></asp:Label><asp:TextBox ID="TextBox1" CssClass="txtname" runat="server" BorderColor="#EEEEEE" BorderStyle="Solid"></asp:TextBox>
             <asp:Label ID="Label2" runat="server" class="id" Text="身份证号：" BackColor="#EEEEEE" BorderStyle="None" Font-Size="Medium"></asp:Label><asp:TextBox ID="TextBox2" CssClass="txtname" runat="server" BorderColor="#EEEEEE" BorderStyle="Solid"></asp:TextBox>
             <div class="daohang">
                 <asp:LinkButton ID="LinkButton1" CssClass="linkbtn" runat="server" OnClick="LinkButton1_Click" BorderStyle="None" BackColor="White"> <div class="daohang1 daohang2">
                     <asp:Image ID="Image1" CssClass="img" runat="server" ImageUrl="~/Image/search.png" /><span>查询</span></div></asp:LinkButton>
                 <asp:LinkButton ID="LinkButton2" CssClass="linkbtn" runat="server" BackColor="White" OnClick="LinkButton2_Click"> <div class="daohang1 daohang3">
                     <asp:Image ID="Image2" CssClass="img" runat="server" ImageUrl="~/Image/exchange rate.png" /><span>重置</span></div></asp:LinkButton>
                 <asp:LinkButton ID="LinkButton4" CssClass="linkbtn" runat="server" BackColor="White" OnClick="LinkButton4_Click"><div class="daohang1 daohang5">
                     <asp:Image ID="Image4" CssClass="img" runat="server" ImageUrl="~/Image/falling.png" /><span>导出到Excel</span></div></asp:LinkButton>
             </div>
    </div>
        <div class="center">
            <asp:Button ID="Button4" CssClass="add1" runat="server" Text="实习员工" OnClick="Button4_Click"/>
            <asp:Button ID="Button5" CssClass="add2" runat="server" Text="正式员工" BorderColor="White" OnClick="Button5_Click"/>
        </div>
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
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="EntryAge" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="学历" DataField="EntrySchool" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="EntryTime" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="EntryIDcard" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="EntryPhone" >
            <ItemStyle Width="163px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" CssClass="cz" runat="server" CausesValidation="false" OnCommand="Button1_Command" CommandArgument='<%# Eval("EntryID") %>' CommandName="" Text="修改" />
                </ItemTemplate>
                <ControlStyle BackColor="#5BC0DE" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="None" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Outset" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
              <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" CssClass="cz" runat="server" CausesValidation="false" CommandName="" CommandArgument='<%# Eval("EntryID") %>' OnClientClick="return confirm('确定转正该员工吗?')" OnCommand="Button2_Command" Text="转正" />
                </ItemTemplate>
                <ControlStyle BackColor="orange" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
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
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="EntryAge" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="学历" DataField="EntrySchool" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="EntryTime" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="EntryIDcard" >
            <ItemStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="EntryPhone" >
            <ItemStyle Width="163px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button4" CssClass="cz" runat="server" CausesValidation="false" OnCommand="Button4_Command1" CommandArgument='<%# Eval("EntryID") %>' CommandName="" Text="修改" />
                </ItemTemplate>
                <ControlStyle BackColor="#5BC0DE" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="None" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderStyle="Outset" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:TemplateField>
             <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" CssClass="cz" runat="server" CausesValidation="false" CommandName="" CommandArgument='<%# Eval("EntryID") %>' OnClientClick="return confirm('确定取消转正该员工吗?')" OnCommand="Button2_Command2" Text ="取消转正" />
                </ItemTemplate>
                <ControlStyle BackColor="orange" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle ForeColor="#FF6600" />
        <HeaderStyle Font-Bold="False" Font-Overline="False" Font-Size="Small" Height="40px" BackColor="#CCCCCC" Font-Names="Sitka Display" HorizontalAlign="Center" VerticalAlign="Middle" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" />
        <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#FF6699" />
</asp:GridView>
    </div>
</asp:Content>
