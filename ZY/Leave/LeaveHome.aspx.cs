using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Leave
{
    public partial class LeaveHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
                GridView0.DataBind();
                GridView0.Style["display"] = "block";
                GridView1.Style["display"] = "none";
                GridView2.Style["display"] = "none";
                Button6.Style["color"] = "orange";
                Button6.Style["font-weight"] = "800";
                Button4.Style["color"] = "gray";
                Button4.Style["font-weight"] = "100";
                Button5.Style["color"] = "gray";
                Button5.Style["font-weight"] = "100";
            }
        }
        //所有入职
        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
            GridView0.DataBind();
            GridView0.Style["display"] = "block";
            GridView1.Style["display"] = "none";
            GridView2.Style["display"] = "none";
            Button6.Style["color"] = "orange";
            Button6.Style["font-weight"] = "800";
            Button4.Style["color"] = "gray";
            Button4.Style["font-weight"] = "100";
            Button5.Style["color"] = "gray";
            Button5.Style["font-weight"] = "100";
        }
        //离职员工
        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = DAL.EntryDAL.SelALLEntry2();
            GridView1.DataBind();
            GridView1.Style["display"] = "block";
            GridView0.Style["display"] = "none";
            GridView2.Style["display"] = "none";
            Button4.Style["color"] = "orange";
            Button4.Style["font-weight"] = "800";
            Button6.Style["color"] = "gray";
            Button6.Style["font-weight"] = "100";
            Button5.Style["color"] = "gray";
            Button5.Style["font-weight"] = "100";
        }
        //辞退员工
        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = DAL.EntryDAL.SelALLEntry3();
            GridView2.DataBind();
            GridView2.Style["display"] = "block";
            GridView0.Style["display"] = "none";
            GridView1.Style["display"] = "none";
            Button5.Style["color"] = "orange";
            Button5.Style["font-weight"] = "800";
            Button6.Style["color"] = "gray";
            Button6.Style["font-weight"] = "100";
            Button4.Style["color"] = "gray";
            Button4.Style["font-weight"] = "100";
        }
        //搜索
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim()=="")
            {
                Response.Write("<script>alert('请输入身份证号')</script>");
            }
            else
            {
                if (GridView0.Style["display"] == "block")
                {
                    string num = TextBox1.Text;
                    GridView0.DataSource = DAL.EntryDAL.SelALLEntry00(int.Parse(num));
                    GridView0.DataBind();
                }
                else if (GridView1.Style["display"] == "block")
                {
                    string num = TextBox1.Text;
                    GridView1.DataSource = DAL.EntryDAL.SelALLEntry22(int.Parse(num));
                    GridView1.DataBind();
                }
                else
                {
                    string num = TextBox1.Text;
                    GridView2.DataSource = DAL.EntryDAL.SelALLEntry33(int.Parse(num));
                    GridView2.DataBind();
                }
            }
        }
        //重置
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (GridView0.Style["display"] == "block")
            {
                string num = TextBox1.Text;
                GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
                GridView0.DataBind();
            }
            else if (GridView1.Style["display"] == "block")
            {
                string num = TextBox1.Text;
                GridView1.DataSource = DAL.EntryDAL.SelALLEntry2();
                GridView1.DataBind();
            }
            else
            {
                string num = TextBox1.Text;
                GridView2.DataSource = DAL.EntryDAL.SelALLEntry3();
                GridView2.DataBind();
            }
        }
        //离职
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            //修改部门人数
            int ClassID = DAL.EntryDAL.ClassID(a);
            DAL.EntryDAL.UpdClass2(ClassID);
            //修改职位人数
            int PostID = DAL.EntryDAL.PostID(a);
            DAL.EntryDAL.UpdPost2(PostID);
            DAL.EntryDAL.AddLZ(a);
            GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
            GridView0.DataBind();
        }
        //辞退
        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            //修改部门人数
            int ClassID = DAL.EntryDAL.ClassID(a);
            DAL.EntryDAL.UpdClass2(ClassID);
            //修改职位人数
            int PostID = DAL.EntryDAL.PostID(a);
            DAL.EntryDAL.UpdPost2(PostID);
            DAL.EntryDAL.AddCT(a);
            GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
            GridView0.DataBind();
        }
        //由离职改为辞退
        protected void Button1_Command1(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            DAL.EntryDAL.AddCT(a);
            GridView1.DataSource = DAL.EntryDAL.SelALLEntry2();
            GridView1.DataBind();
        }
        //取消离职
        protected void Button2_Command1(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            //修改部门人数
            int ClassID = DAL.EntryDAL.ClassID(a);
            DAL.EntryDAL.UpdClass1(ClassID);
            //修改职位人数
            int PostID = DAL.EntryDAL.PostID(a);
            DAL.EntryDAL.UpdPost1(PostID);
            DAL.EntryDAL.DelLZ(a);
            GridView1.DataSource = DAL.EntryDAL.SelALLEntry2();
            GridView1.DataBind();
        }
        //由辞退改为离职
        protected void Button1_Command2(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            DAL.EntryDAL.AddLZ(a);
            GridView2.DataSource = DAL.EntryDAL.SelALLEntry3();
            GridView2.DataBind();
        }
        //取消辞退
        protected void Button1_Command3(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            //修改部门人数
            int ClassID = DAL.EntryDAL.ClassID(a);
            DAL.EntryDAL.UpdClass1(ClassID);
            //修改职位人数
            int PostID = DAL.EntryDAL.PostID(a);
            DAL.EntryDAL.UpdPost1(PostID);
            DAL.EntryDAL.DelCT(a);
            GridView2.DataSource = DAL.EntryDAL.SelALLEntry3();
            GridView2.DataBind();
        }

        protected void GridView0_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView0.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
            GridView0.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView1.DataSource = DAL.EntryDAL.SelALLEntry2();
            GridView1.DataBind();
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;//设置显示用户选择的页面
            GridView2.DataSource = DAL.EntryDAL.SelALLEntry3();
            GridView2.DataBind();
        }

        protected void GridView0_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#37B4F5';this.style.cursor='pointer'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
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