using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace ZY.Class
{
    public partial class PostAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = DAL.ClassDAL.ClassSelect();
                DropDownList1.DataTextField = "ClassName";
                DropDownList1.DataValueField = "ClassID";
                DropDownList1.DataBind();
                DropDownList2.DataSource = DAL.PostDAL.PostSelect();
                DropDownList2.DataTextField = "PostID";
                DropDownList2.DataValueField = "PostID";
                DropDownList2.DataBind();
            }
        }
        protected void BTN_ADD_Click(object sender, EventArgs e)
        {
            //新增职位
            if (Txt_postidADD.Text == ""|| Txt_postnameADD.Text == ""|| Txt_postsalaryADD.Text == ""||Txt_postcommentADD.Text == "")
            {
                Response.Write("<script>alert('请输入完整信息');</script>");
            }
            else
            {
                int PostID = int.Parse(Txt_postidADD.Text);
                string PostName = Txt_postnameADD.Text;
                int PostSalary = int.Parse(Txt_postsalaryADD.Text);
                int PostRecruitsed = 0;
                string PostComment = Txt_postcommentADD.Text;
                int ClassID = int.Parse(DropDownList1.SelectedValue);
                Model.Post postadd = new Model.Post();
                postadd.PostID = PostID;
                postadd.PostName = PostName;
                postadd.PostSalary = PostSalary;
                postadd.PostRecruitsed = PostRecruitsed;
                postadd.PostComment = PostComment;
                postadd.ClassID = ClassID;
                if (PostSalary<0)
                {
                    Response.Write("<script>alert('薪水不能为负值');</script>");
                }
                else
                {
                    if (DAL.PostDAL.SelectPostID(PostID).Count > 0)
                    {
                        Response.Write("<script>alert('已存在该职位编号或职位名称');</script>");
                    }
                    else if (DAL.PostDAL.SelectPostName(PostName).Count > 0)
                    {
                        Response.Write("<script>alert('已存在该职位编号或职位名称');</script>");
                    }
                    else
                    {
                        if (PostBLL.AddPost(postadd))
                        {
                            //提示信息
                            Response.Write("<script>alert('添加成功');location.href='/Class/PostMain.aspx'</script>");
                        }
                        else
                        {
                            //提示信息
                            Response.Write("<script>alert('添加失败，请联系管理员');location.href='/Class/PostMain.aspx'</script>");
                        }
                    }
                }
            }
        }

        protected void BTN_ADDBACKMAIN_Click(object sender, EventArgs e)
        {
            //返回主界面，提示信息
            Response.Redirect("/Class/PostMain.aspx");
        }

        protected void BTN_CZ_Click(object sender, EventArgs e)
        {
            //刷新
            Response.Write("<script>location.href='/Class/PostAdd.aspx'</script>");
        }

    }
}