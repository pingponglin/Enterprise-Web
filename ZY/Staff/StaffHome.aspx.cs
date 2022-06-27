using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace ZY.Staff
{
    public partial class StaffHome : System.Web.UI.Page
    {
        //全局变量
        private static int a;
        protected void Page_Load(object sender, EventArgs e)
        {
            //显示所有员工
            if (!IsPostBack)
            {
                GridView1.Style["display"] = "block";
                GridView2.Style["display"] = "none";
                GridView1.DataSource = DAL.StaffDAL.SelALLStaff1();
                GridView1.DataBind();
                Button4.Style["color"] = "orange";
                Button4.Style["font-weight"] = "800";
                Button5.Style["color"] = "gray";
                Button5.Style["font-weight"] = "100";
            }
        }
        //修改员工
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["EntryID"] = a;
            Response.Redirect("StaffUpd.aspx");
        }

        //查询
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim()==""&&TextBox2.Text.Trim()=="")
            {
                Response.Write("<script>alert('请输入搜索关键字')</script>");
                GridView1.DataSource = BLL.StaffBLL.SelALLStaff();
                GridView1.DataBind();
            }
            else
            {
                if (GridView1.Style["display"] == "block")
                {
                    string state = "实习员工";
                    //根据姓名查
                    if (TextBox1.Text.Trim() != "" && TextBox2.Text.Trim() == "")
                    {
                        Model.Entry staff = new Model.Entry();
                        staff.EntryName = TextBox1.Text.Trim();
                        staff.EntryState = state;
                        GridView1.DataSource = DAL.StaffDAL.SelALLNameStaff(staff);
                        GridView1.DataBind();
                    }
                    //根据身份证来查
                    else if (TextBox1.Text.Trim() == "" && TextBox2.Text.Trim() != "")
                    {
                        Model.Entry staff = new Model.Entry();
                        staff.EntryIDcard = TextBox2.Text.Trim();
                        staff.EntryState = state;
                        GridView1.DataSource = DAL.StaffDAL.SelALLIDStaff(staff);
                        GridView1.DataBind();
                    }
                    //根据姓名和身份证来查
                    else
                    {
                        Model.Entry staff = new Model.Entry();
                        staff.EntryName = TextBox1.Text;
                        staff.EntryIDcard = TextBox2.Text.Trim();
                        staff.EntryState = state;
                        GridView1.DataSource = DAL.StaffDAL.SelALLTwoStaff(staff);
                        GridView1.DataBind();
                    }
                }
                else
                {
                    string state = "正式员工";
                    //根据姓名查
                    if (TextBox1.Text.Trim() != "" && TextBox2.Text.Trim() == "")
                    {
                        Model.Entry staff = new Model.Entry();
                        staff.EntryName = TextBox1.Text.Trim();
                        staff.EntryState = state;
                        GridView2.DataSource = DAL.StaffDAL.SelALLNameStaff(staff);
                        GridView2.DataBind();
                    }
                    //根据身份证来查
                    else if (TextBox1.Text.Trim() == "" && TextBox2.Text.Trim() != "")
                    {
                        Model.Entry staff = new Model.Entry();
                        staff.EntryIDcard = TextBox2.Text.Trim();
                        staff.EntryState = state;
                        GridView2.DataSource = DAL.StaffDAL.SelALLIDStaff(staff);
                        GridView2.DataBind();
                    }
                    //根据姓名和身份证来查
                    else
                    {
                        Model.Entry staff = new Model.Entry();
                        staff.EntryName = TextBox1.Text;
                        staff.EntryIDcard = TextBox2.Text.Trim();
                        staff.EntryState = state;
                        GridView2.DataSource = DAL.StaffDAL.SelALLTwoStaff(staff);
                        GridView2.DataBind();
                    }
                }
            }
            
        }
        //重置
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (GridView1.Style["display"] == "block")
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                GridView1.DataSource = DAL.StaffDAL.SelALLStaff1();
                GridView1.DataBind();
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                GridView2.DataSource = DAL.StaffDAL.SelALLStaff2();
                GridView2.DataBind();
            }
        }
        //导出excel
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (GridView1.Style["display"] == "block")
            {
                string attachment = "attachment; filename=MyExcel" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", attachment);
                Response.Charset = "UTF-8";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.ContentType = "application/ms-excel";
                System.IO.StringWriter sw = new System.IO.StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                //for (int i = 0; i < GridView1.Rows.Count; i++)
                //{
                //    GridView1.Rows[0].Cells[0].Visible = false;//这是所要隐藏的列的位置
                //    GridView1.Rows[0].Cells[12].Visible = false;//这是所要隐藏的列的位置
                //}
                GridView1.RenderControl(htw);      
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
            else
            {
                string attachment = "attachment; filename=MyExcel" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", attachment);
                Response.Charset = "UTF-8";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.ContentType = "application/ms-excel";
                System.IO.StringWriter sw = new System.IO.StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                GridView2.RenderControl(htw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //如果不加这个重载方法导出会报错
        }

        protected void Button2_Command1(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["StaffID"] = a;
            DateTime date = new DateTime();
            string d = DateTime.Now.ToString();
            Model.Money money = new Model.Money();
            money.MoneyTime = DateTime.Parse(d);
            
            money.StaffID = a;
            if (DAL.MoneyDAL.Inserts(money))
            {
                Response.Write("<script>location.href='/Money/Money.aspx'; </script>");
            }
        }
        //实习员工
        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = DAL.StaffDAL.SelALLStaff1();
            GridView1.DataBind();
            GridView1.Style["display"] = "block";
            GridView2.Style["display"] = "none";
            Button4.Style["color"] = "orange";
            Button4.Style["font-weight"] = "800";
            Button5.Style["color"] = "gray";
            Button5.Style["font-weight"] = "100";
        }
        //正式员工
        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = DAL.StaffDAL.SelALLStaff2();
            GridView2.DataBind();
            GridView2.Style["display"] = "block";
            GridView1.Style["display"] = "none";
            Button5.Style["color"] = "orange";
            Button5.Style["font-weight"] = "800";
            Button4.Style["color"] = "gray";
            Button4.Style["font-weight"] = "100";
        }
        //员工转正
        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["EntryID"] = a;
            DAL.StaffDAL.UpdStaffZZ(a);
            GridView1.DataSource = DAL.StaffDAL.SelALLStaff1();
            GridView1.DataBind();
        }
        //修改正式员工
        protected void Button4_Command1(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["EntryID"] = a;
            Response.Redirect("StaffUpd.aspx");
        }
        //取消转正
        protected void Button2_Command2(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            DAL.StaffDAL.UpdStaffQX(a);
            GridView2.DataSource = DAL.StaffDAL.SelALLStaff2();
            GridView2.DataBind();
        }
        //分页
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView1.DataSource = DAL.StaffDAL.SelALLStaff1();
            GridView1.DataBind();
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView2.DataSource = DAL.StaffDAL.SelALLStaff2();
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