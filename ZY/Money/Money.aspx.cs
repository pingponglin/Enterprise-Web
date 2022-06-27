using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Money
{
    public partial class Money : System.Web.UI.Page
    {
        public static int num=1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.labPage.Text = "1";
                this.contrlRepeater();
                //string a = Session["StaffID"].ToString();
                //if (Session["StaffID"].ToString() != "")
                //{
                //string sql = string.Format("select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职' order by m.MoneyTime desc");
                //rptMoney.DataSource = DAL.MoneyDAL.SelectM(sql);//获取所有的部门信息
                //rptMoney.DataBind(); 
            }  
        }
        
        protected void LinkButton1_Command2(object sender, CommandEventArgs e)
        {
      
            int moneyID = int.Parse(e.CommandArgument.ToString());
           
            Model.Money money = new Model.Money();
            money.MoneyID = moneyID;
            var data = DAL.MoneyDAL.SelectID(money);
            foreach (var item in data)
            {
                t_EntryName.Text = item.EntryName.ToString();
                t_postid.Text = item.PostName.ToString();
                t_PostSalary.Text = item.PostSalary.ToString();
                t_EntryState.Text = item.EntryState.ToString();
                t_MoneyTime.Text = item.MoneyTime.ToString();
                t_MoneyWork.Text = item.MoneyWork.ToString();
                t_MoneyCheck.Text = item.MoneyCheck.ToString();
                t_MoneyAbsent.Text = item.MoneyAbsent.ToString();
                t_MoneySafe.Text = item.MoneySafe.ToString();
                t_MoneySum.Text = item.MoneySum.ToString();

            }
            ClientScript.RegisterStartupScript(this.GetType(), "T", "<script>T();</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string sql = $"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryName='{t_EntryName.Text}'";
            Model.Money money = new Model.Money();
            var data = DAL.MoneyDAL.SelectM(sql);
            foreach (var item in data)
            {
                int id = item.EntryID;
                money.EntryID = id;
                money.MoneyTime = DateTime.Parse(t_MoneyTime.Text.ToString());
                money.MoneyWork = int.Parse(t_MoneyWork.Text.ToString());
                money.MoneyCheck = int.Parse(t_MoneyCheck.Text.ToString());
                money.MoneyAbsent = int.Parse(t_MoneyAbsent.Text.ToString());
                money.MoneySafe = int.Parse(t_MoneySafe.Text.ToString());
                money.MoneySum = int.Parse(t_MoneySum.Text.ToString());
                if (DAL.MoneyDAL.UpdateM(money))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "M", "<script>M();</script>");
                    Response.Write("<script>location.href='/Money/Money.aspx'</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "M1", "<script>M1();</script>");
                }
            }
        }
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            int moneyID = int.Parse(e.CommandArgument.ToString());
            int moneyWork1 = 0;//加班费
            int moneyCheck1 = 500;//考勤
            int moneyAbsent1 = 0;//缺勤
            int MoneySafe = 500;//保险金
            int a=0;//加班费
            int b = 0;//考勤
            int c = 0;//缺勤
            int salary = 0;//基本工资
            int sum = 0;//实发工资
            int sum1 = 0;
            Model.Money money = new Model.Money();
            money.MoneyID = moneyID;
           var d=DAL.MoneyDAL.SelectID(money);
            foreach (var item in d)
            {
                a = item.MoneyWork;
                b = item.MoneyCheck;
                c = item.MoneyAbsent;
                salary=int.Parse(item.PostSalary.ToString());
            }
            //加班
            for (int i = 0; i < a; i++)
            {
                if (a!= -1)
                {
                 moneyWork1+=1000;   
                }
            }
            //考勤
            for (int i = 0; i < b; i++)
            {
                if (b != -1)
                {
                    moneyCheck1 = 500;

                }
            }
            for (int i = 0; i < c; i++)
            {
                if (c != -1)
                {
                    moneyAbsent1 += 100;
                    if (c >= 3)
                    {
                        moneyCheck1 = 0;
                    }
                    else
                    {
moneyCheck1 = moneyCheck1- moneyAbsent1;
                    }
                    
                }
            }
            if (c!=0)
            {

            }
            sum = moneyWork1 + moneyCheck1-MoneySafe+salary;
            string sql = $"update Money set MoneySum='{sum}'where MoneyID={moneyID}";
            if (DAL.MoneyDAL.UpdateM(sql))
            {
                Response.Write("<script>location.href='/Money/Money.aspx'</script>");
            }
        }
        //获取指字符个数的字符
        public string cuts(string aa, int bb)
        {
            if (aa.Length <= bb)
            {
                return aa;
            }
            else
            {
                return aa.Substring(0, bb);
            }
        }
        //Repeater分页控制显示方法
        public void contrlRepeater()
        {
            if (TextBox1.Text==""&&TextBox2.Text=="")
            {
                DataTable dt = DAL.DBHelper.GetDataTable($"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职'");
                PagedDataSource pds = new PagedDataSource();
                pds.DataSource = dt.DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 5;
                pds.CurrentPageIndex = num-1;
                rptMoney.DataSource = pds;
                LabCountPage.Text = pds.PageCount.ToString();
                labPage.Text = (pds.CurrentPageIndex + 1).ToString();
                this.lbtnpritPage.Enabled = true;
                this.lbtnNextPage.Enabled = true;
                if (pds.CurrentPageIndex < 1)
                {
                    this.lbtnpritPage.Enabled = false;
                }
                if (pds.CurrentPageIndex == pds.PageCount - 1)
                {
                    this.lbtnNextPage.Enabled = false;
                }
                rptMoney.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = null;
                //根据姓名查
                if (TextBox1.Text.Trim() != "" && TextBox2.Text.Trim() == "")
                {
                    dt = DAL.DBHelper.GetDataTable($"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职'and e.EntryName like'%{TextBox1.Text}%'");
                }
                //根据职位来查
                else if (TextBox1.Text.Trim() == "" && TextBox2.Text.Trim() != "")
                {
                    dt = DAL.DBHelper.GetDataTable($"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职'and p.PostName like'%{TextBox2.Text}%'");
                }
                //根据姓名和职位来查
                else
                {
                    dt = DAL.DBHelper.GetDataTable($"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职'and e.EntryName like'%{TextBox1.Text}%' and p.PostName like'%{TextBox2.Text}%'");
                }
                PagedDataSource pds = new PagedDataSource();
                pds.DataSource = dt.DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 5;
                pds.CurrentPageIndex = num - 1;
                rptMoney.DataSource = pds;
                LabCountPage.Text = pds.PageCount.ToString();
                labPage.Text = (pds.CurrentPageIndex + 1).ToString();
                this.lbtnpritPage.Enabled = true;
                this.lbtnNextPage.Enabled = true;
                if (pds.CurrentPageIndex < 1)
                {
                    this.lbtnpritPage.Enabled = false;
                }
                if (pds.CurrentPageIndex == pds.PageCount - 1)
                {
                    this.lbtnNextPage.Enabled = false;
                }
                rptMoney.DataBind();
            }
        }      
        //上一页
        protected void lbtnpritPage_Click(object sender, EventArgs e)
        {
            this.labPage.Text = num.ToString();
            num = num - 1;
            this.contrlRepeater();
        }

        //下一页
        protected void lbtnNextPage_Click(object sender, EventArgs e)
        {
            this.labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) + 1);
            num = num + 1;
            this.contrlRepeater();
        }
        //查询
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() == "" && TextBox2.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入搜索关键字')</script>");
               
            }
            else
            {
                this.labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) - 1);
                this.contrlRepeater();
            }
            }
        //查所有薪资数据
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            DataTable dt = DAL.DBHelper.GetDataTable($"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职'");
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 5;
            pds.CurrentPageIndex = num - 1;
            rptMoney.DataSource = pds;
            LabCountPage.Text = pds.PageCount.ToString();
            labPage.Text = (pds.CurrentPageIndex + 1).ToString();
            this.lbtnpritPage.Enabled = true;
            this.lbtnNextPage.Enabled = true;
            if (pds.CurrentPageIndex < 1)
            {
                this.lbtnpritPage.Enabled = false;
            }
            if (pds.CurrentPageIndex == pds.PageCount - 1)
            {
                this.lbtnNextPage.Enabled = false;
            }
            rptMoney.DataBind();
        }
    }
}