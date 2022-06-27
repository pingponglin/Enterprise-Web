using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Text
{
    public partial class TextHome : System.Web.UI.Page
    {
        public static int a;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = DAL.TextDAL.SelAllText();
                Repeater1.DataBind();
                a = 1;
                this.contrlRepeater();
                //if (DAL.TextDAL.SelAllText().Count%3==0)
                //{
                //    Panel1.Style["display"] = "block";
                //    Panel2.Style["display"] = "block";
                //    Panel3.Style["display"] = "block";
                //}
                //else if (DAL.TextDAL.SelAllText().Count % 2 == 0)
                //{
                //    Panel1.Style["display"] = "block";
                //    Panel2.Style["display"] = "block";
                //    Panel3.Style["display"] = "none";
                //}
                //else
                //{
                //    Panel1.Style["display"] = "block";
                //    Panel2.Style["display"] = "none";
                //    Panel3.Style["display"] = "none";
                //}
                //a = DAL.TextDAL.SelAllText().Count % 3;//占几个
                //b = DAL.TextDAL.SelAllText().Count / 3;//索引
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
            if (TextBox1.Text=="")
            {
                DataTable dt = DAL.DBHelper.GetDataTable($"select * from Text");
                PagedDataSource pds = new PagedDataSource();
                pds.DataSource = dt.DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 3;
                pds.CurrentPageIndex = a - 1;
                Repeater1.DataSource = pds;
                Button1.Enabled = true;
                Button2.Enabled = true;
                if (pds.CurrentPageIndex < 1)
                {
                    Button1.Enabled = false;
                }
                if (pds.CurrentPageIndex == pds.PageCount - 1)

                {
                    Button2.Enabled = false;
                }
                Repeater1.DataBind();
            }
            else
            {
                DataTable dt = DAL.DBHelper.GetDataTable($"select * from Text where TextIDcard='{TextBox1.Text}'");
                PagedDataSource pds = new PagedDataSource();
                pds.DataSource = dt.DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 3;
                pds.CurrentPageIndex = a - 1;
                Repeater1.DataSource = pds;
                Button1.Enabled = true;
                Button2.Enabled = true;
                if (pds.CurrentPageIndex < 1)
                {
                    Button1.Enabled = false;
                }
                if (pds.CurrentPageIndex == pds.PageCount - 1)
                {
                    Button2.Enabled = false;
                }
                Repeater1.DataBind();
            }
        }
        //返回
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Work/WorkHome.aspx");
        }
        //搜索
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim()=="")
            {
                Response.Write("<script>alert('请输入身份证号')</script>");
                this.contrlRepeater();
            }
            else
            {
                a = 1;
                this.contrlRepeater();
            }
        }
        //刷新
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            a = 1;
            this.contrlRepeater();
        }
        //上一页
        protected void Button1_Click(object sender, EventArgs e)
        {
            a = a - 1;
            this.contrlRepeater();
        }
        //下一页
        protected void Button2_Click(object sender, EventArgs e)
        {
            a = a + 1;
            this.contrlRepeater();
        }
    }
}