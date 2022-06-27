<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="ClassMain.aspx.cs" Inherits="ZY.Class.ClassMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="../Font/style11.css" />
    <link rel="stylesheet" type="text/css" href="../Font/1.css" />
    <script src="../JS/jquery-3.5.1.js"></script>
    <script src="../JS/bootstrap.min.js" type="text/javascript" charset="utf-8"></script>
    <script src="../JS/bootbox.min.js"></script>
    <script language="javascript" type="text/javascript" src="../My97DatePicker/WdatePicker.js"></script>
    <%--页面样式--%>
    <style>
        /*整体样式*/
        .ZhengTi {
            height: 700px;
            width: 1200px;
            background-color:;
            position: relative;
            left: px;
            top: 23px;
        }
        /*左上方div样式*/
        .ZuoShang {
            height: 650px;
            width: 800px;
            background-color: white;
            position: relative;
            left: 15px;
            top: 15px;
            border: 2px solid #ccc;
            border-radius: 25px;
            box-shadow: 10px 10px 5px #888888;
        }
        /*左上方表格标题样式*/
        .ZSBGBT{
            height:65px;
            font-size:30px;
            color:cornflowerblue;
            text-align:center;
        }
        /*查询*/
        .CXYS{
            margin-left:10px;
            height:50px;
            border-bottom:1px solid black;
        }
        .CXSRKYS:hover{
            box-shadow:1px 1px 10px #165e83;
        }
        /*添加*/
        .TJYS{
            margin-left:10px;
            margin-top:15px;
            height:30px;
        }
        /*表格样式*/
        .BGYS {
            margin: 0 auto;
            margin-top:15px;
            height: 280px;
            width: 780px;
            text-align: center;
        }
        /*表格表头样式*/
        .BGBTYS {
            font-size: 20px;
            color:mediumblue;
            font-weight:bold;
        }
        /*触碰样式*/
        /*表格所显示数据行样式*/
        .shujuhang{
            height:30px;
            border-bottom:1px solid black;
        }
        .shujuhang:hover{
            background-color:lightgoldenrodyellow;
        }
        /*删除按钮修改样式*/
        .SCANYS:hover {
            color: red;
        }
        /*右上方div样式*/
        .YouShang {
            height: 650px;
            width: 450px;
            background-color: lightyellow;
            position: relative;
            left: 835px;
            bottom: 635px;
            border: 2px solid #ccc;
            border-radius: 25px;
            box-shadow: 10px 10px 5px #888888;
        }

    </style>
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/echarts@5/dist/echarts.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--整体--%>
    <div class="ZhengTi">
        <%--左上--%>
        <div class="ZuoShang">
            <%--左上标题--%>
            <div class="ZSBGBT">部门信息展示</div>
            <%--查询--%>
            <div class="CXYS">请输入部门名称：
                <asp:TextBox ID="txt_CXSRK" class="CXSRKYS" runat="server" style="width:200px;border-radius:3px;"></asp:TextBox>
                <asp:Button ID="btn_CX" runat="server" Text="查询" BackColor="Transparent" BorderStyle="None" style="color:dodgerblue;width:50px;font-size:20px;" OnClick="btn_CX_Click"/>
                <asp:Button ID="btn_CZ" runat="server" Text="重置" BackColor="Transparent" BorderStyle="None" style="color:orangered;width:50px;font-size:20px;" OnClick="btn_CZ_Click"/>
                
            </div>
            <%--添加--%>
            <div class="TJYS">
                <asp:Button ID="btn_TJ" runat="server" Text="添加" BackColor="Transparent" BorderStyle="None" style="color:dodgerblue;font-size:20px;" OnClick="btn_TJ_Click"/>
            </div>
            <%--表格--%>
            <table class="BGYS">
                <thead>
                    <tr class="BGBTYS">
                        <%--表头--%>
                        <th>部门编号</th>
                        <th>部门名称</th>
                        <th>创建时间</th>
                        
                        <th>部门已有人数</th>
                        <th>部门备注</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr class="shujuhang" style="height:20px;">
                                <%--获取数据--%>
                                <td><%# Eval("ClassID")%></td>
                                <td><%# Eval("ClassName")%></td>
                                <td><%# Eval("ClassTime")%></td>
                                
                                <td><%# Eval("ClassRecruitsed")%></td>
                                <td><%# Eval("ClassComment")%></td>
                                <%--操作按钮--%>
                                <td><a href='EditClass.aspx?ClassID=<%# Eval("ClassID") %>' class="XGANYS">修改</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
        <%--右上--%>
        <div class="YouShang">
            <div id="container1" style="height: 300px; width: 500px;">
            </div>
            <div style="margin-top:35px;">
                <iframe allowtransparency="true" frameborder="0" width="420" height="420" scrolling="no" src="//tianqi.2345.com/plugin/widget/index.htm?s=1&z=1&t=1&v=0&d=5&bd=0&k=000000&f=&ltf=009944&htf=cc0000&q=1&e=1&a=1&c=57687&w=420&h=420&align=center"></iframe>
            </div>
        </div>
        
    </div>
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
    </script>
    <script src="../JS/mejs.js"></script>
</asp:Content>
