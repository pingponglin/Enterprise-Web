<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="Money.aspx.cs" Inherits="ZY.Money.Money" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../JS/jquery-3.5.1.js"></script>
    <link rel="stylesheet" href="../Font/table.css" />
    <link rel="stylesheet" type="text/css" href="../Font/style1.css" />

    <link rel="stylesheet" type="text/css" href="../Font/1.css" />
    <script src="../JS/bootstrap.min.js" type="text/javascript" charset="utf-8"></script>
    <script src="../JS/bootbox.min.js"></script>
    <script src="../layer/layer.js"></script>
    <script type="text/javascript" src="../JS/excel-gen.js"></script>
    <script type="text/javascript" src="../JS/jszip.min.js"></script>
    <script type="text/javascript" src="../JS/FileSaver.js"></script>
    <style>
        .l_y {
        position:relative;
        left:148px;
        }
        .daohang1 {
    height: 36px;
    width: 70px;
    background-color: #337AB7;
    border-radius: 6px;
    color: white;
    cursor: pointer;
        position: relative;
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
           border-top-right-radius:8px;width: 139px;
       }
    </style>
    <script>
        function M() {
            layer.open({
                content: '修改成功',
                scrollbar: false
            });
        }
        function M1() {
            layer.open({
                content: '修改失败',
                scrollbar: false
            });
        }
        function T() {
            $(".M_tang").css("display", "block");
            /*$(".fade:not(.show)").css("opacity", "5");*/
        }
    </script>
    <div style="background-color: white;position: relative;width: 1281px;/* height: 900px; */top: 11px;left: 9px;"><br />
        <div style="height: 14px;">
        <div style="float:left;position: relative;left: 286px;">
            
        <asp:Label ID="Label6" runat="server" class="name" Text="姓名：" BackColor="#EEEEEE" BorderStyle="None" style="color:black;"></asp:Label><asp:TextBox ID="TextBox1" CssClass="txtname" runat="server" BorderColor="#EEEEEE" BorderStyle="Solid"></asp:TextBox>
             <asp:Label ID="Label8" runat="server" class="id" Text="职位：" BackColor="#EEEEEE" BorderStyle="None" style="color:black;"></asp:Label><asp:TextBox ID="TextBox2" CssClass="txtname" runat="server" BorderColor="#EEEEEE" BorderStyle="Solid"></asp:TextBox>
        </div>
         <asp:LinkButton ID="LinkButton1" CssClass="linkbtn" runat="server" BorderStyle="None" BackColor="White" style="overflow:hidden;position: relative;left: 306px;" OnClick="LinkButton1_Click">
                 <div class="daohang1 daohang2">
                     <asp:Image ID="Image1" CssClass="img" runat="server" ImageUrl="~/Image/12.png" /><span style="position: relative;bottom: 9px;">查询</span></div></asp:LinkButton>
        <asp:Button ID="Button1" runat="server" Text="查询所有" style="position: relative;left: 316px;
    bottom: 10px;background-color: #337AB7;border-radius: 6px;border:0px solid;width: 93px;height: 37px;color: white;" OnClick="Button1_Click"/>
<div class="col-md-3" style="position: relative;left: 963px;bottom: 47px;width: 192px;">
					<button type="button" class="btn btn-success btn-block" id="generate-excel"><i class="fa fa-file-excel-o" aria-hidden="true"></i> 将表格转换为Excel</button>
				</div></div>
       <br /><br />
        
    <table id="test_table" style="position: relative; margin: 0 auto; width: 1232px;" class="gallery table table_list table_striped table-bordered border " id="tableList" cellpadding="0">
        <tr style="background-color: #CCCCCC">
            <td class="alt" style="border-color: Silver;">编号</td>
            <td class="alt" style="border-color: Silver;">员工姓名</td>
            <td class="alt" style="border-color: Silver;">职位</td>
            <td class="alt" style="border-color: Silver;">基本工资</td>
            <td class="alt" style="border-color: Silver;">员工状态</td>
            <td class="alt" style="border-color: Silver;">身份证</td>
            <td class="alt" style="border-color: Silver;">时间</td>
            <td class="alt" style="border-color: Silver;">加班费：/小时(1000)</td>
            <td class="alt" style="border-color: Silver;">全勤：/月(500)</td>
            <td class="alt" style="border-color: Silver;">缺勤：/次(100)</td>
            <td class="alt" style="border-color: Silver;">保险金(500)</td>
            <td class="alt" style="border-color: Silver;">实发工资</td>
            <td class="alt" style="width: 200px; border-color: Silver;">操作</td>
        </tr>
        <asp:Repeater ID="rptMoney" runat="server">
            <ItemTemplate>
                <tr class="center">
                    <td style="border-color: Silver;"><%# Eval("MoneyID")%></td>
                    <td style="border-color: Silver;"><%# Eval("EntryName")%></td>
                    <td style="border-color: Silver;"><%# Eval("PostName")%></td>
                    <td style="border-color: Silver;"><%# Eval("PostSalary")%></td>
                    <td style="border-color: Silver;"><%# Eval("EntryState")%></td>
                    <td style="border-color: Silver;"><%# Eval("EntryIDcard")%></td>
                    <td style="border-color: Silver;"><%# Eval("MoneyTime")%></td>
                    <td style="border-color: Silver;"><%# Eval("MoneyWork")%></td>
                    <td style="border-color: Silver;"><%# Eval("MoneyCheck")%></td>
                    <td style="border-color: Silver;"><%# Eval("MoneyAbsent")%></td>
                    <td style="border-color: Silver;"><%# Eval("MoneySafe")%></td>
                    <td style="border-color: Silver;"><%# Eval("MoneySum")%></td>
                    <td style="border-color: Silver;">
                        <div style="background-color: #5BC0DE;float:left; width: 87px;height: 32px;margin: 0 auto;">
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="M_t" Style="border: 0px solid; font-weight: normal;color: black;text-decoration: none;" OnClientClick="return confirm('确认修改？')" OnCommand="LinkButton1_Command2" CommandArgument='<%# Eval("MoneyID") %>'>修改</asp:LinkButton>
                        </div>
 
                        <div style="background-color: #5BC0DE;float:left; width: 87px;height: 32px;margin: 0 auto;margin-left:10px;">
                        <asp:LinkButton ID="LinkButton2" runat="server" Style="border: 0px solid; font-weight: normal;color: black;text-decoration: none;" OnCommand="LinkButton2_Command" CommandArgument='<%# Eval("MoneyID") %>'>结算</asp:LinkButton>
                        </div>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
          <div style="MARGIN: 0 auto;width: 377px;">
             <asp:LinkButton ID="lbtnpritPage" runat="server" OnClick="lbtnpritPage_Click">上一页</asp:LinkButton> 
             <asp:LinkButton ID="lbtnNextPage" runat="server" OnClick="lbtnNextPage_Click">下一页</asp:LinkButton><br />
             &nbsp;&nbsp;&nbsp;第<asp:Label ID="labPage" runat="server" Text="Label"></asp:Label>页/共<asp:Label ID="LabCountPage" runat="server" Text="Label"></asp:Label>页</div>
    </div>
  
    <div class="modal fade M_tang" id="renyuan">
        <div class="modal-dialog modal-lg modal_position">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">修改信息</h4>
                    <button type="button" class="close M_c1" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <p class="a">
                        <asp:Label ID="Label1" runat="server" Text="员工姓名:"></asp:Label><asp:TextBox ID="t_EntryName" CssClass="TextBox1" runat="server" ReadOnly="true" style="width: 180px;"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" CssClass="l_y" Text="职位:"></asp:Label>
                        <asp:TextBox ID="t_postid" CssClass="l_y" runat="server" ReadOnly="true" style="width: 180px;"></asp:TextBox>
                    </p>
                    <p class="b">
                        <asp:Label ID="Label3" runat="server" Text="基本工资:"></asp:Label><asp:TextBox ID="t_PostSalary" CssClass="TextBox3" runat="server" ReadOnly="true" style="width: 179px;"></asp:TextBox>
                        <asp:Label ID="Label4" runat="server" CssClass="l_y" Text="员工状态:"></asp:Label><asp:TextBox ID="t_EntryState" CssClass="l_y" runat="server" ReadOnly="true" style="width: 180px;"></asp:TextBox>
                    </p>
                    <p class="c">
                        <asp:Label ID="Label5" runat="server" Text="时间:"></asp:Label><asp:TextBox ID="t_MoneyTime" runat="server" style="width: 209px;" TextMode="Date"></asp:TextBox>
                        <asp:Label ID="Label10" runat="server" Text="考勤:/元" CssClass="l_y"></asp:Label><asp:TextBox ID="t_MoneyCheck" runat="server" CssClass="l_y" style="width: 191px;"></asp:TextBox>
                    </p>
                    <p class="post">
                        <asp:Label ID="Label7" runat="server" Text="加班费:/小时:"></asp:Label><asp:TextBox ID="t_MoneyWork" runat="server"></asp:TextBox>
                        <asp:Label ID="Label12" runat="server" Text="实发工资:" CssClass="l_y"></asp:Label><asp:TextBox ID="t_MoneySum" runat="server" CssClass="l_y" style="    width: 182px;"></asp:TextBox>
                    </p>
                    <p class="c">
                        <asp:Label ID="Label9" runat="server" Text="缺勤:/次"></asp:Label><asp:TextBox ID="t_MoneyAbsent" runat="server" style="width: 186px;"></asp:TextBox>
                        <asp:Label ID="Label11" runat="server" Text="保险金:" CssClass="l_y"></asp:Label><asp:TextBox ID="t_MoneySafe" runat="server" CssClass="l_y" style="width: 198px;"></asp:TextBox>
                    </p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary M_que2" style="background-color:white;" data-dismiss="modal">取消</button>

                    <asp:Button ID="Button3" Style="background-color: #3ea2ee;" runat="server" Text="确定" class="btn btn-secondary" OnClick="Button3_Click" />

                </div>
            </div>
        </div>
    </div>
    <script>
        $(".M_t").click(function () {
            $(".M_tang").css("display", "block");
            $(".fade:not(.show)").css("opacity", "5");
        })
        $(".M_c1").click(function () {
            $(".M_tang").css("display", "none");
        })
        $(".M_que2").click(function () {
            $(".M_tang").css("display", "none");
        })

    </script>
    	<script type="text/javascript">
            $(document).ready(function () {
                $("#generate-excel").click(function () {
                    var excel = new ExcelGen({ "src_id": "test_table", "show_header": true });
                    excel.generate();
                });
            })
            </script>
    <script src="../JS/mejs.js"></script>
</asp:Content>
