using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Entry
{
    public partial class EntryHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //显示所有待入职员工
            if (!IsPostBack)
            {
                GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
                GridView1.DataBind();
                GridView1.Style["display"] = "block";
                GridView2.Style["display"] = "none";
                Button4.Style["color"] = "orange";
                Button4.Style["font-weight"] = "800";
                Button5.Style["color"] = "gray";
                Button5.Style["font-weight"] = "100";
            }
        }
        //显示所有待入职员工
        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
            GridView1.DataBind();
            GridView1.Style["display"] = "block";
            GridView2.Style["display"] = "none";
            Button4.Style["color"] = "orange";
            Button4.Style["font-weight"] = "800";
            Button5.Style["color"] = "gray";
            Button5.Style["font-weight"] = "100";
        }
        //显示所有已入职员工
        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = DAL.EntryDAL.SelALLEntry1();
            GridView2.DataBind();
            GridView1.Style["display"] = "none";
            GridView2.Style["display"] = "block";
            Button5.Style["color"] = "orange";
            Button5.Style["font-weight"] = "800";
            Button4.Style["color"] = "gray";
            Button4.Style["font-weight"] = "100";
        }
        //新增入职
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EntryAdd.aspx");
        }
        //根据身份证搜搜员工
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string idcard = TextBox1.Text.Trim();
            if (idcard=="")
            {
                Response.Write("<script>alert('请输入身份证号')</script>");
            }
            else
            {
                if (GridView1.Style["display"] == "block")
                {
                    string state = "待入职";
                    if (DAL.EntryDAL.SelIdCardEntry(idcard,state).Count>0)
                    {
                        GridView1.DataSource = DAL.EntryDAL.SelIdCardEntry(idcard,state);
                        GridView1.DataBind();
                        GridView1.Style["display"] = "block";
                        GridView2.Style["display"] = "none";
                    }
                    else
                    {
                        Response.Write("<script>alert('待入职员工中不存在此人')</script>");
                    }
                }
                else
                {
                    string state = "已入职";
                    if (DAL.EntryDAL.SelIdCardEntry(idcard,state).Count > 0)
                    {
                        GridView2.DataSource = DAL.EntryDAL.SelIdCardEntry(idcard,state);
                        GridView2.DataBind();
                        GridView2.Style["display"] = "block";
                        GridView1.Style["display"] = "none";
                    }
                    else
                    {
                        Response.Write("<script>alert('入职员工中不存在此人')</script>");
                    }
                }
            }
        }
        //重置
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (GridView1.Style["display"] == "block")
            {
                TextBox1.Text = " ";
                GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
                GridView1.DataBind();
                GridView1.Style["display"] = "block";
                GridView2.Style["display"] = "none";
            }
            else
            {
                TextBox1.Text = " ";
                GridView2.DataSource = DAL.EntryDAL.SelALLEntry1();
                GridView2.DataBind();
                GridView2.Style["display"] = "block";
                GridView1.Style["display"] = "none";
            }
        }
        //入职
        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());
            if (DAL.EntryDAL.AddTrue(a))
            {
                Response.Write("<script>alert('入职成功')</script>");
                GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
                GridView1.DataBind();
                GridView2.DataSource = DAL.EntryDAL.SelALLEntry1();
                GridView2.DataBind();
                DAL.EntryDAL.AddStaff(a);
                //修改部门人数
                int ClassID = DAL.EntryDAL.ClassID(a);
                DAL.EntryDAL.UpdClass1(ClassID);
                //修改职位人数
                int PostID = DAL.EntryDAL.PostID(a);
                DAL.EntryDAL.UpdPost1(PostID);
                //根据点击入职把员添加到薪资里面去
                Model.Money money = new Model.Money();
                money.EntryID = a;
                List<Model.Entry> entries = new List<Model.Entry>();
                entries = DAL.EntryDAL.SelALLEntryID(a);
                foreach (var item in entries)
                {
                    money.PostID = item.PostID;
                }
                money.MoneyTime = DateTime.Parse(DateTime.Now.ToString());
                money.MoneyWork = 0;
                money.MoneyCheck = 500;
                money.MoneyAbsent = 0;
                money.MoneySafe = 500;
                money.MoneySum = 0;
                DAL.MoneyDAL.InsertM(money);
            }
        }
        //取消入职
        protected void Button2_Command1(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());
            if (DAL.EntryDAL.AddFalse(a))
            {
                Response.Write("<script>alert('取消入职成功')</script>");
                GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
                GridView1.DataBind();
                GridView2.DataSource = DAL.EntryDAL.SelALLEntry1();
                GridView2.DataBind();
                DAL.EntryDAL.AjjStaff(a);
                //修改部门人数
                int ClassID = DAL.EntryDAL.ClassID(a);
                DAL.EntryDAL.UpdClass2(ClassID);
                //修改职位人数
                int PostID = DAL.EntryDAL.PostID(a);
                DAL.EntryDAL.UpdPost2(PostID);
            }
        }
        //删除
        protected void Button3_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Model.Entry entry = new Model.Entry();
            entry.EntryID = a;
            if (DAL.StaffDAL.DelStaff(entry))
            {
                Response.Write("<script>alert('删除成功')</script>");
                GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
                GridView1.DataBind();
            }
        }
        //修改1
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["EntryID"] = a;
            Response.Redirect("/Staff/StaffUpd1.aspx");
        }
        //修改2
        protected void Button1_Command1(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["EntryID"] = a;
            Response.Redirect("/Staff/StaffUpd1.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView1.DataSource = DAL.EntryDAL.SelALLEntry();
            GridView1.DataBind();
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView2.DataSource = DAL.EntryDAL.SelALLEntry1();
            GridView2.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#37B4F5';this.style.cursor='pointer'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#37B4F5';this.style.cursor='pointer'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
        }
    }
}