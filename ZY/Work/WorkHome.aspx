<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="WorkHome.aspx.cs" Inherits="ZY.Work.WorkHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/jquery-3.5.1.js"></script>
    <script>
         $(function () {
            $('.cz').mouseover(function () {
                $(this).addClass('color1');
            })
             $('.cz').mouseout(function () {
                $(this).removeClass('color1');
            })
        })
    </script>
    <style>
         .top{
            background-color:white;
            height:40px;
            width:98%;
            margin-top:10px;
            margin-left:10px;
        }
         .center{
            margin-left:10px;
            margin-top:10px;
            width:1276px;
            height:400px;
            box-shadow:0 0 5px grey;
        }
        .GridView1{
            cursor:pointer;
        }
        .s{
             margin-left:680px;
             line-height:44px;
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
         .sousuo{
            height:30px;
            width:230px;
        }
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
        .color1{
            background-color:lightgray;
            box-shadow:0px 0px 5px gray;
        }
        .add1{
            background-color:white;
            width:100px;
            height:40px;
            color:gray;
            margin-left:20px;
            border:none;
            border-color:white;
            cursor:pointer;
        }
        .ss{
            color:orange;
            font-weight:800;
        }
        .bottom{
            display:flex;
            height:420px;
        }
        .left{
            width:600px;
            height:400px;
            margin-top:10px;
            margin-left:60px;
        }
        #container1{
            margin-left:80px;
        }
         #container2{
            margin-left:80px;
        }
         .right{
            width:600px;
            height:400px;
            margin-left:570px;
            margin-top:470px;
        }
         .bottom p{
              color:gray;
              margin-left:10px;
         }
    </style>
    <script src="../JS/jquery-3.5.1.js"></script>
    <script>
        $(function () {
            $('.add1').mouseover(function () {
                $(this).addClass('ss');
            })
            $('.add1').mouseout(function () {
                $(this).removeClass('ss');
            })
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="top">
         <asp:Button ID="Button2" CssClass="add1" runat="server" Text="调岗记录" OnClick="Button2_Click" />
            <asp:Label ID="Label1" runat="server" CssClass="s" Text="输入身份证号："></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="sousuo" runat="server"></asp:TextBox><asp:LinkButton ID="LinkButton1" CssClass="link" runat="server" OnClick="LinkButton1_Click"><asp:Image ID="Image1" CssClass="linkimg" runat="server" ImageUrl="~/Image/search.png" /></asp:LinkButton>
            <asp:Button ID="Button3" CssClass="cz" runat="server" Text="重置" OnClick="Button3_Click" />
        </div>
    <div class="center">
         <asp:GridView ID="GridView0" CssClass="GridView1" runat="server" AutoGenerateColumns="False" Font-Bold="False" BorderColor="Silver" AllowPaging="True" OnRowDataBound="GridView0_RowDataBound">
        <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField HeaderText="编号" DataField="EntryID" >
            <ItemStyle Width="60px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="姓名" DataField="EntryName" >
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="入职时间" DataField="EntryTime" >
            <ItemStyle Width="270px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="身份证号" DataField="EntryIDcard" >
            <ItemStyle Width="270px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="联系电话" DataField="EntryPhone" >
            <ItemStyle Width="270px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="部门" DataField="ClassName" >
            <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="职位" DataField="PostName" >
            <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button1" CssClass="cz" runat="server" CausesValidation="false" CommandArgument='<%# Eval("EntryID") %>'  CommandName="" OnCommand="Button1_Command" Text="调岗" />
                </ItemTemplate>
                <ControlStyle BackColor="#5BC0DE" CssClass="btn1" Font-Bold="False" ForeColor="White" Height="40px" Width="110px" BorderColor="White" BorderStyle="Solid" />
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
    <div class="bottom">
        <div class="left"><p>部门人数统计图</p>
            <div id="container1" style="height: 300px;width: 500px;">
         </div>
        </div>
        <div class="right"><p>职位人数统计图</p>
            <div id="container2" style="height: 300px;width: 500px;">
        </div>
        </div>
    </div>
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/echarts@5/dist/echarts.min.js"></script>
    <script type="text/javascript">
         var dom = document.getElementById("container1");
         var myChart = echarts.init(dom);
         var app = {};
         var option;
         option = {
             tooltip: {
                 trigger: 'item'
             },
             legend: {
                 orient: 'vertical',
                 left: 'left',
             },
             series: [
                 {
                     name: '访问来源',
                     type: 'pie',
                     radius: '50%',
                     data: [
                         <%= name11%>
                     ],
                     emphasis: {
                         itemStyle: {
                             shadowBlur: 10,
                             shadowOffsetX: 0,
                             shadowColor: 'rgba(0, 0, 0, 0.5)'
                         }
                     }
                 }
             ]
         };
         if (option && typeof option === 'object') {
             myChart.setOption(option);
        }
        //节点
        var dom2 = document.getElementById("container2");
         var myChart2 = echarts.init(dom2);
         var app = {};
         var option2;
         option2 = {
             tooltip: {
                 trigger: 'item'
             },
             legend: {
                 orient: 'vertical',
                 left: 'left',
             },
             series: [
                 {
                     name: '访问来源',
                     type: 'pie',
                     radius: '50%',
                     data: [
                         <%= name12%>
                     ],
                     emphasis: {
                         itemStyle: {
                             shadowBlur: 10,
                             shadowOffsetX: 0,
                             shadowColor: 'rgba(0, 0, 0, 0.5)'
                         }
                     }
                 }
             ]
         };
         if (option2 && typeof option2 === 'object') {
             myChart2.setOption(option2);
         }
     </script>
</asp:Content>
