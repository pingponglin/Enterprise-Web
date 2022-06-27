using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace ZY.Class
{
    
    public partial class EditPost : System.Web.UI.Page
    {
        public static string postname;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int PostID = int.Parse(Request.QueryString["PostID"].ToString());
                Model.Post postPL = GetDeptByID(PostID);
                if (postPL != null)
                {
                    DropDownList1.DataSource = DAL.ClassDAL.ClassSelect();
                    DropDownList1.DataTextField = "ClassName";
                    DropDownList1.DataValueField = "ClassID";
                    DropDownList1.DataBind();

                    Txt_PostIDUPDATE.Text = postPL.PostID.ToString();
                    Txt_PostNameUPDATE.Text = postPL.PostName;
                    Txt_PostSalaryUPDATE.Text = postPL.PostSalary.ToString();
                    
                    Txt_classRecruitsedUPDATE.Text = postPL.PostRecruitsed.ToString();
                    Txt_PostCommentUPDATE.Text = postPL.PostComment.ToString();
                    DropDownList1.DataValueField = postPL.ClassID.ToString();
                }
            }
            DropDownList2.DataSource = DAL.PostDAL.PostSelect();
            DropDownList2.DataTextField = "PostID";
            DropDownList2.DataValueField = "PostID";
            DropDownList2.DataBind();

        }
        private Model.Post GetDeptByID(int PostID)
        {
            //获取
            Model.Post postUPDATEGDBI = new Model.Post();
            string sql = $"select * from Post where PostID='{PostID}'";
            if (PostBLL.GetAllPost(sql).Count() > 0)
            {
                postUPDATEGDBI = PostBLL.GetAllPost(sql)[0];
            }
            return postUPDATEGDBI;
        }
        //修改并保存
        protected void BTN_UPDATE_Click(object sender, EventArgs e)
        {

            Post postUPDATEBTN = new Post();
            //获取修改信息
           
            if (Txt_PostIDUPDATE.Text==""|| Txt_PostNameUPDATE.Text==""||Txt_PostSalaryUPDATE.Text==""|| Txt_PostCommentUPDATE.Text=="")
            {
                Response.Write("<script>alert('请输入完整信息');</script>");
            }
            else
            {
                postUPDATEBTN.PostID = int.Parse(Txt_PostIDUPDATE.Text);
                postUPDATEBTN.PostName = Txt_PostNameUPDATE.Text;
                postUPDATEBTN.PostSalary = int.Parse(Txt_PostSalaryUPDATE.Text);
                postUPDATEBTN.PostRecruitsed = int.Parse(Txt_classRecruitsedUPDATE.Text);
                postUPDATEBTN.PostComment = Txt_PostCommentUPDATE.Text;
                postUPDATEBTN.ClassID = int.Parse(DropDownList1.SelectedValue);
                postname = DAL.PostDAL.SelectPostName1(postUPDATEBTN.PostID);
                if (postUPDATEBTN.PostSalary<0)
                {
                    Response.Write("<script>alert('薪水不能为负值');</script>");
                }
                else
                {
                    if (postname == postUPDATEBTN.PostName)
                    {
                        if (PostBLL.UpdatePost(postUPDATEBTN))
                        {
                            //提示信息
                            Response.Write("<script>alert('修改成功');location.href='/Class/PostMain.aspx'</script>");
                        }
                        else
                        {
                            //提示信息
                            Response.Write("<script>alert('修改失败，请联系管理员');location.href='/Class/PostMain.aspx'</script>");
                        }
                    }
                    else
                    {
                        if (DAL.PostDAL.SelectPostUpd(postUPDATEBTN.PostName).Count > 0)
                        {
                            Response.Write("<script>alert('已存在该职位');</script>");
                        }
                        else
                        {
                            if (PostBLL.UpdatePost(postUPDATEBTN))
                            {
                                //提示信息
                                Response.Write("<script>alert('修改成功');location.href='/Class/PostMain.aspx'</script>");
                            }
                            else
                            {
                                //提示信息
                                Response.Write("<script>alert('修改失败，请联系管理员');location.href='/Class/PostMain.aspx'</script>");
                            }
                        }
                    }
                }
            }
        }

        protected void BTN_EDITBACKMAIN_Click(object sender, EventArgs e)
        {
            //返回主界面，提示信息
            Response.Redirect("/Class/PostMain.aspx");
        }
    }
}