<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Index.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ZY.Index1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <script src="../layer/layer.js"></script>
       <script>
           function y() {
               $(".container").css("display","none");
           }
           function y1() {
               $(".container").css("display", "block");
           }
       </script>
    <style>
        .m1 {
            width: 700px;
            height: 724px;
            background-color: white;
            position: relative;
            top: 6px;
            left: 18px;
            float:left;
            box-shadow:rgb(100, 99, 99) 0px 0px 8px;
        }

        .m2 {
            /*           clear:both;*/
            overflow:auto;
            width: 538px;
            height: 414px;
            background-color: white;
            position: relative;box-shadow:rgb(100, 99, 99) 0px 0px 8px;
            top: 6px;
            left: 37px;
        }

        .m3 { overflow:auto;
            width: 538px;
            height: 301px;
            background-color:white;box-shadow:rgb(100, 99, 99) 0px 0px 8px;
            position: relative;
            bottom:-17px;
            left: 37px;
        }
        .if {
        position:relative;
        top:0px;
        bottom:100px;
        
        }
         .calendar{
            width: 523px;
            height: 296px;
            background: white;
            box-shadow: 0px 1px 1px rgba(0,0,0,.1);
        }
 
        .title1{
            height: 70px;
            border-bottom: 1px solid rgba(0,0,0,.1);
            position: relative;
            text-align: center;
        }
 
        #calendar-title{
            font-size: 25px;
            text-transform: uppercase;
            font-family: Arial, Helvetica, sans-serif;
            padding: 0px 0 0 0;
        }
 
        #calendar-year{
            font-size: 15px;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
        }
 
        #pre{
            position: absolute;
            top: 0px;
            left: 0px;
            background: url(prev.png) no-repeat 50% 50%;
 
            /*没规定大小时，图片显示 0X0*/
            width: 60px;
            height: 70px;
            
        }
 
        #next{
            position: absolute;
            top: 0px;
            right: 0px;
            background: url(next.png) no-repeat 50% 50%;
            width: 60px;
            height: 70px;
        }  
 
        .body-list ul{
            font-size: 14px;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            width: 100%;
            box-sizing: border-box;
      
        }  
 
        .body-list ul li{
            list-style: none;
            /*
            display:inline-block; 
            width: 13.3%;
            */
 
            /*100/7 = 14.28%*/
            display: block;
            width: 14.28%;
            float: left;
 
            /*规定行高，垂直居中*/
            height: 36px;
            line-height: 36px;
            box-sizing: border-box;
            text-align: center;
            
        }
 
 
        .green{
            color:#6ac13c;
        }
 
        .lightgrey{ /*浅灰色显示过去的日期*/
	        color:#a8a8a8;
        }   
        .darkgrey{ /*深灰色显示将来的日期*/
	        color:#565656;
        }
 
        /*日期当天用绿色背景绿色文字加以显示*/
        .greenbox{
            border: 1px solid #6ac13c;
            background: #e9f8df;
        }
    </style>
    <script src="JS/jquery-3.5.1.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="m1">
         <div id="container" style="height: 100%"></div>
    </div>
    <div class="m2">
        <iframe allowtransparency="true" frameborder="0" width="385" height="96" scrolling="no" src="//tianqi.2345.com/plugin/widget/index.htm?s=1&z=1&t=0&v=0&d=3&bd=0&k=000000&f=&ltf=009944&htf=cc0000&q=1&e=1&a=1&c=54511&w=385&h=96&align=center" class="if"></iframe >
        <div class="calendar">
        <div class="title1">
            <h1 class="green" id="calendar-title">Month</h1>
            <h2 class="green" id="calendar-year">Year</h2>
            <a href="#" id="pre"><img src="Image/arrow-left.png" alt=""></a>
            <a href="#" id="next"><img src="Image/arrow-right.png" alt=""></a>
        </div>
 
        <div class="body">
            <div class="lightgrey body-list">
                <ul>
                    <li>日</li>
                    <li>一</li>
                    <li>二</li>
                    <li>三</li>
                    <li>四</li>
                    <li>五</li>
                    <li>六</li>
                    
                </ul>
 
            </div>
 
            <div class="darkgrey body-list">
                <ul id="days">
 
                </ul>
            </div>
        </div>
    </div>
 
    <script type="text/javascript">
        var month_olypic = [31,29,31,30,31,30,31,31,30,31,30,31];//闰年每个月份的天数
        var month_normal = [31,28,31,30,31,30,31,31,30,31,30,31];
        var month_name =["January","Febrary","March","April","May","June","July","Auguest","September","October","November","December"];
        //获取以上各个部分的id
        var holder = document.getElementById("days");
        var prev = document.getElementById("prev");
        var next = document.getElementById("next");
        var ctitle = document.getElementById("calendar-title");
        var cyear = document.getElementById("calendar-year");
        //获取当天的年月日
        var my_date = new Date();
        var my_year = my_date.getFullYear();//获取年份
        var my_month = my_date.getMonth(); //获取月份，一月份的下标为0
        var my_day = my_date.getDate();//获取当前日期
 
        //根据年月获取当月第一天是周几
        function dayStart(month,year){
            var tmpDate = new Date(year, month, 1);
            return (tmpDate.getDay());
        }
        //根据年份判断某月有多少天(11,2018),表示2018年12月
        function daysMonth(month, year){
            var tmp1 = year % 4;
            var tmp2 = year % 100;
            var tmp3 = year % 400;
 
            if((tmp1 == 0 && tmp2 != 0) || (tmp3 == 0)){
                return (month_olypic[month]);//闰年
            }else{
                return (month_normal[month]);//非闰年
            }
        }
        //js实现str插入li+class,不要忘了用innerhtml进行插入
        function refreshDate(){
            var str = "";
            //计算当月的天数和每月第一天都是周几，day_month和day_year都从上面获得
            var totalDay = daysMonth(my_month,my_year);
            var firstDay = dayStart(my_month, my_year);
            //添加每个月的空白部分
            for(var i = 0; i < firstDay; i++){
                str += "<li>"+"</li>";
            }
 
            //从一号开始添加知道totalDay，并为pre，next和当天添加样式
            var myclass;
            for(var i = 1; i <= totalDay; i++){
                //三种情况年份小，年分相等月份小，年月相等，天数小
                //点击pre和next之后，my_month和my_year会发生变化，将其与现在的直接获取的再进行比较
                //i与my_day进行比较,pre和next变化时，my_day是不变的
                console.log(my_year+" "+my_month+" "+my_day);
                console.log(my_date.getFullYear()+" "+my_date.getMonth()+" "+my_date.getDay());
                if((my_year < my_date.getFullYear())||(my_year == my_date.getFullYear() && my_month < my_date.getMonth()) || (my_year == my_date.getFullYear() && my_month == my_date.getMonth() && i < my_day)){
                    myclass = " class='lightgrey'";
                }else if(my_year == my_date.getFullYear() && my_month == my_date.getMonth() && i == my_day){
                    myclass = "class = 'green greenbox'";
                }else{
                    myclass = "class = 'darkgrey'";
                }
                str += "<li "+myclass+">"+i+"</li>";
            }
            holder.innerHTML = str;
            ctitle.innerHTML = month_name[my_month];
            cyear.innerHTML = my_year;
        }
        //调用refreshDate()函数，日历才会出现
        refreshDate();
        //实现onclick向前或向后移动
        pre.onclick = function(e){
            e.preventDefault();
            my_month--;
            if(my_month < 0){
                my_year--;
                my_month = 11; //即12月份
            }
            refreshDate();
        }
        
        next.onclick = function(e){
            e.preventDefault();
            my_month++;
            if(my_month > 11){
                my_month = 0;
                my_year++;
            }
            refreshDate();
        }
    </script>
    </div>
    <div class="m3">
         <div id="container1" style="height: 300px;width: 500px;">

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
                     ],<%--{ value: <%= name1 %>, name: '搜索引擎' },
                         { value: <%= name2 %>, name: '直接访问' },
                         { value: <%= name3 %>, name: '邮件营销' },
                         { value: <%= name4 %>, name: '联盟广告' },
                         { value: <%= name5 %>, name: '视频广告' },--%>
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
    <script>
        var dom = document.getElementById("container");
        var myChart = echarts.init(dom);
        var app = {};

        var option;



        var dataAxis = [<%= bu %>];
        var data = [<%= list %>];
        var yMax = 500;
        var dataShadow = [];

        for (var i = 0; i < data.length; i++) {
            dataShadow.push(yMax);
        }

        option = {
            title: {
                text: '职位薪水'
            },
            xAxis: {
                data: dataAxis,
                axisLabel: {
                    inside: true,
                    textStyle: {
                        color: '#fff'
                    }
                },
                axisTick: {
                    show: false
                },
                axisLine: {
                    show: false
                },
                z: 10
            },
            yAxis: {
                axisLine: {
                    show: false
                },
                axisTick: {
                    show: false
                },
                axisLabel: {
                    textStyle: {
                        color: '#999'
                    }
                }
            },
            dataZoom: [
                {
                    type: 'inside'
                }
            ],
            series: [
                {
                    type: 'bar',
                    showBackground: true,
                    itemStyle: {
                        color: new echarts.graphic.LinearGradient(
                            0, 0, 0, 1,
                            [
                                { offset: 0, color: '#83bff6' },
                                { offset: 0.5, color: '#188df0' },
                                { offset: 1, color: '#188df0' }
                            ]
                        )
                    },
                    emphasis: {
                        itemStyle: {
                            color: new echarts.graphic.LinearGradient(
                                0, 0, 0, 1,
                                [
                                    { offset: 0, color: '#2378f7' },
                                    { offset: 0.7, color: '#2378f7' },
                                    { offset: 1, color: '#83bff6' }
                                ]
                            )
                        }
                    },
                    data: data
                }
            ]
        };

        // Enable data zoom when user click bar.
        var zoomSize = 6;
        myChart.on('click', function (params) {
            console.log(dataAxis[Math.max(params.dataIndex - zoomSize / 2, 0)]);
            myChart.dispatchAction({
                type: 'dataZoom',
                startValue: dataAxis[Math.max(params.dataIndex - zoomSize / 2, 0)],
                endValue: dataAxis[Math.min(params.dataIndex + zoomSize / 2, data.length - 1)]
            });
        });

        if (option && typeof option === 'object') {
            myChart.setOption(option);
        }

    </script>
</asp:Content>
