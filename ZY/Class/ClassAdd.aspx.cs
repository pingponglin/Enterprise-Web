using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;

namespace ZY.Class
{
    public partial class ClassAdd1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxCheckIsNull();
            DropDownList1.DataSource = DAL.ClassDAL.ClassSelect();
            DropDownList1.DataTextField = "ClassID";
            DropDownList1.DataValueField = "ClassID";
            DropDownList1.DataBind();
            DropDownList2.DataSource = DAL.ClassDAL.ClassSelect();
            DropDownList2.DataTextField = "ClassName";
            DropDownList2.DataValueField = "ClassName";
            DropDownList2.DataBind();
        }
        //新增部门
        protected void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (Txt_classidADD.Text==""|| Txt_classnameADD.Text==""|| Txt_classtimeADD.Text==""|| Txt_classcommentADD.Text=="")
            {
                Response.Write("<script>alert('请输入完整信息！')</script>");
            }
            else
            {
                //获取信息
                int ClassID = int.Parse(Txt_classidADD.Text);
                string ClassName = Txt_classnameADD.Text;
                DateTime ClassTime = DateTime.Parse(Txt_classtimeADD.Text);
                int ClassRecruitsed = 0;
                string ClassComment = Txt_classcommentADD.Text;
                string sql = $"select * from Class where ClassID={ClassID}";
                string sql1 = $"select * from Class where ClassName='{ClassName}'";
                if (DAL.ClassDAL.ClassSelect1(sql).Count > 0 || DAL.ClassDAL.ClassSelect1(sql1).Count > 0)
                {
                    Response.Write("<script>alert('添加失败，请勿添加相同部门编号或相同部门名称！')</script>");
                }
                else
                {
                    Model.Class classadd = new Model.Class();
                    classadd.ClassID = ClassID;
                    classadd.ClassName = ClassName;
                    classadd.ClassTime = ClassTime;
                    classadd.ClassRecruitsed = ClassRecruitsed;
                    classadd.ClassComment = ClassComment;
                    if (ClassBLL.AddClass(classadd))
                    {
                        //提示信息
                        Response.Write("<script>alert('添加成功');location.href='/Class/ClassMain.aspx'</script>");
                    }
                    else
                    {
                        //提示信息
                        Response.Write("<script>alert('添加失败');</script>");
                    }
                }
            }
        }
            
            //string id = null;
            //string sql = $"select ClassID from Class";
            //var ETCLID = DAL.ClassDAL.ClassSelect1(sql);
            //DataTable dt = DBHelper.GetDataTable(sql);
            //foreach (var item in ETCLID)
            //{
            //        id = item.ClassID.ToString();
            //}
            //if (int.Parse(id) == ClassID)
            //{
            //    Response.Write("<script>alert('添加失败，请勿添加相同部门编号');location.href='/Class/ClassMain.aspx'</script>");
            //}
            //else
            //{
            //    if (ClassBLL.AddClass(classadd))
            //    {
                 
            //    }
            //    else
            //    {
            //     //提示信息
            //     Response.Write("<script>alert('添加失败');location.href='/Class/ClassMain.aspx'</script>");
            //    }
            //}
            //else (ClassBLL.AddClass(classadd))
            //{
            //    
            //}

        

        protected void BTN_ADDBACKMAIN_Click(object sender, EventArgs e)
        {
            //返回主界面，并提示信息
            Response.Redirect("/Class/ClassMain.aspx");
        }

        protected void BTN_CZ_Click(object sender, EventArgs e)
        {
            //刷新
            Response.Write("<script>location.href='/Class/ClassAdd.aspx'</script>");
        }
        private bool TextBoxCheckIsNull()
        {
            bool flag = true;
            foreach (Control control in this.Txt_classnameADD.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty((control as TextBox).Text))
                    {
                        Txt_classnameADD.Text = "";
                        Response.Write("alert('shijainbudui')");
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }
    }
}