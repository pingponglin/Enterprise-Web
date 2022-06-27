using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Work
{
    public partial class WorkHome : System.Web.UI.Page
    {
        public string name11 = "";//注释
        public string name12 = "";//注释
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
            GridView0.DataBind();
            //注释
            List<Model.Class> classes = new List<Model.Class>();
            classes = BLL.ClassBLL.SelectClass();
            string n = ""; string n1 = "";
            if (classes.Count != 0)
            {
                for (int i = 0; i < classes.Count; i++)
                {
                    if (i != classes.Count - 1 + 1)
                    {
                        n = classes[i].ClassRecruitsed.ToString();
                        n1 = classes[i].ClassName.ToString();
                        name11 += "{ value:" + $"{n}" + ", name: '" + $"{n1}" + "' },";
                    }
                    else
                    {
                        name11 += "{ value:" + $"{n}" + ",  name: '" + $"{n1}" + "' }";
                    }
                }
            }
            else
            {
                name11 = "";
            }
            //注释2
            List<Model.Post> post = new List<Model.Post>();
            post = BLL.PostBLL.SelectPost();
            string n2 = ""; string n3 = "";
            if (post.Count != 0)
            {
                for (int i = 0; i < post.Count; i++)
                {
                    if (i != post.Count - 1 + 1)
                    {
                        n2= post[i].PostRecruitsed.ToString();
                        n3 = post[i].PostName.ToString();
                        name12 += "{ value:" + $"{n2}" + ", name: '" + $"{n3}" + "' },";
                    }
                    else
                    {
                        name12 += "{ value:" + $"{n2}" + ",  name: '" + $"{n3}" + "' }";
                    }
                }
            }
            else
            {
                name12 = "";
            }
        }
        //搜索
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入身份证号')</script>");
            }
            else
            {
                GridView0.DataSource = DAL.EntryDAL.SelALLEntry1(TextBox1.Text);
                GridView0.DataBind();
            }
        }
        //重置
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            GridView0.DataSource = DAL.EntryDAL.SelALLEntry0();
            GridView0.DataBind();
        }
        //调岗
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            int a = int.Parse(e.CommandArgument.ToString());//获取修改的员工编号
            Session["EntryID"] = a;
            Response.Redirect("WorkUpd.aspx");
        }
        //调岗记录
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Text/TextHome.aspx");
        }

        protected void GridView0_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#37B4F5';this.style.cursor='pointer'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
        }
    }
}