using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;
using DAL;

namespace ZY.Class
{
    public partial class PostMain : System.Web.UI.Page
    {
        public string name11 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
                List<Model.Post> postes = new List<Model.Post>();
                postes = BLL.PostBLL.SelectPost();
                string n = ""; string n1 = "";
                if (postes.Count != 0)
                {
                    for (int i = 0; i < postes.Count; i++)
                    {
                        if (i != postes.Count - 1 + 1)
                        {
                            n = postes[i].PostRecruitsed.ToString();
                            n1 = postes[i].PostName.ToString();
                            //name2 = classes[i + 1].ClassRecruits.ToString();
                            //name3 = classes[i + 2].ClassRecruits.ToString();
                            //name4 = classes[i + 3].ClassRecruits.ToString();
                            //name5 = classes[i + 4].ClassRecruits.ToString();
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
            }
        }
        private void Bind()
        {
         
            Repeater1.DataSource = DAL.PostDAL.PostSelect();
            Repeater1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            ////删除
            //int PostID = int.Parse(e.CommandArgument.ToString());
            //Post postcssc = new Post();
            //postcssc.PostID = PostID;
            //string sql = $"select PostID from Entry where Post ";
            
            
            //DataTable dt = DBHelper.GetDataTable(sql);
            //if (int.Parse(id)==PostID)
            //{
            //    Response.Write("<script>alert('删除失败,该职位下有员工！');location.href='/Class/PostMain.aspx'</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('删除成功');location.href='/Class/PostMain.aspx'</script>");
            //}
            ////DeptBLL.DeleteDept(new Model.Dept() { DeptId=deptID });
        }

        protected void btn_CX_Click(object sender, EventArgs e)
        {
            //根据关键字查询
            string keyStr = txt_CXSRK.Text;//获取用户输入的关键字
            string sql = $"select * from Post where PostName like'%{keyStr}%'";//查询语句
            Repeater1.DataSource = PostBLL.GetAllPost(sql);
            Repeater1.DataBind();
        }

        protected void btn_CZ_Click(object sender, EventArgs e)
        {
            //刷新
            Response.Write("<script>location.href='/Class/PostMain.aspx'</script>");
        }

        protected void btn_TJ_Click(object sender, EventArgs e)
        {
            //跳转到新增职位页面
            Response.Write("<script>location.href='/Class/PostAdd.aspx'</script>");
        }

        //protected void BTN_cxanpost_Click(object sender, EventArgs e)
        //{
        //    //根据关键字查询功能
        //    string keyStr = Txt_cxjskpost.Text;//获取用户输入的关键字
        //    string sql = $"select * from Post where PostName like'%{keyStr}%'";
        //    Repeater1.DataSource = PostBLL.GetAllPost(sql);
        //    Repeater1.DataBind();
        //}

        //protected void BTN_ChongZhi_Click(object sender, EventArgs e)
        //{
        //    Txt_cxjskpost.Text = "";
        //    Bind();
        //}
    }
}