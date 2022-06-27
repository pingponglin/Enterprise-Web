using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.IO;

namespace ZY.Class
{
    public partial class ClassMain : System.Web.UI.Page
    {
        public string name11 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
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
            Repeater1.DataSource = ClassBLL.SelectClass();
            Repeater1.DataBind();
        }

        protected void btn_TJ_Click(object sender, EventArgs e)
        {
            //跳转到新增部门页面
            Response.Write("<script>location.href='/Class/ClassAdd.aspx'</script>");
        }

        protected void btn_CZ_Click(object sender, EventArgs e)
        {
            //刷新
            Response.Write("<script>location.href='/Class/ClassMain.aspx'</script>");
        }

        protected void btn_CX_Click(object sender, EventArgs e)
        {
            string keyStr = txt_CXSRK.Text;//获取到用户输入的关键字
            string sql = $"select * from Class where ClassName like'%{keyStr}%'";//查询语句
            Repeater1.DataSource = ClassBLL.GetAllClass(sql);
            Repeater1.DataBind();
        }
        //删除部门
        protected void LinkButton1_Command1(object sender, CommandEventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "D", "<script>D();</script>");
            int ClassID = int.Parse(e.CommandArgument.ToString());
            Model.Class classcssc = new Model.Class();
            classcssc.ClassID = ClassID;
            if (DAL.ClassDAL.SelPost(ClassID).Count > 0)
            {
                Response.Write("<script>alert('该部门存在职位，不能删除');location.href='/Class/ClassMain.aspx'</script>");
            }
            else
            {
                if (ClassBLL.DeleteClass(classcssc))
                {
                    //提示信息
                    Response.Write("<script>alert('删除成功');location.href='/Class/ClassMain.aspx'</script>");
                }
                else
                {
                    //提示信息
                    Response.Write("<script>alert('删除失败,请联系管理员');location.href='/Class/ClassMain.aspx'</script>");
                }
            }
        }
    }
}