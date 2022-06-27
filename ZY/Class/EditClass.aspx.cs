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
    public partial class EditClass : System.Web.UI.Page
    {
        public static int id;
        public static string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ClassID = int.Parse(Request.QueryString["ClassID"].ToString());
                Model.Class classCL = GetDeptByID(ClassID);
                id = ClassID;
                name = classCL.ClassName.ToString();
                if (classCL != null)
                {
                    Txt_classIDUPDATE.Text = classCL.ClassID.ToString();
                    Txt_classNameUPDATE.Text = classCL.ClassName.ToString();
                    Txt_classTimeUPDATE.Text = classCL.ClassTime.ToString();
                    
                    Txt_classRecruitsedUPDATE.Text = classCL.ClassRecruitsed.ToString();
                    Txt_classCommentUPDATE.Text = classCL.ClassComment.ToString();
                }
            }
            DropDownList1.DataSource = DAL.ClassDAL.ClassSelect();
            DropDownList1.DataTextField = "ClassID";
            DropDownList1.DataValueField = "ClassID";
            DropDownList1.DataBind();
            DropDownList2.DataSource = DAL.ClassDAL.ClassSelect();
            DropDownList2.DataTextField = "ClassName";
            DropDownList2.DataValueField = "ClassName";
            DropDownList2.DataBind();
        }
        private Model.Class GetDeptByID(int ClassID)
        {
            //获取
            Model.Class classUPDATEGDBI = new Model.Class();
            string sql = $"select * from Class where ClassID='{ClassID}'";
            if (ClassBLL.GetAllClass(sql).Count() > 0)
            {
                classUPDATEGDBI = ClassBLL.GetAllClass(sql)[0];
            }
            return classUPDATEGDBI;
        }
        //修改并保存
        protected void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            
  //          Model.Class classUPDATEBTN = new Model.Class();
            
  //          int id = ;
  //          string name = "";
  //          string sql = $"select * from Class where ClassID={classUPDATEBTN.ClassID}";
  //          var EDITCL = DAL.ClassDAL.ClassSelect1(sql);
  //          for (int i = 0; i < EDITCL.Count; i++)
  //          {
  //              if (i != -1)
  //              {
  //id = int.Parse(EDITCL[i].ClassID.ToString());
  //              name = EDITCL[i].ClassName.ToString();
  //              }

  //          }
  //          if (classUPDATEBTN.ClassID != id && classUPDATEBTN.ClassName != name)
  //          {
  //              //获取修改信息
  //          classUPDATEBTN.ClassID = int.Parse(Txt_classIDUPDATE.Text);
  //          classUPDATEBTN.ClassName = Txt_classNameUPDATE.Text;
  //          classUPDATEBTN.ClassTime = DateTime.Parse(Txt_classTimeUPDATE.Text);
            
  //          classUPDATEBTN.ClassRecruitsed = int.Parse(Txt_classRecruitsedUPDATE.Text);
  //          classUPDATEBTN.ClassComment = Txt_classCommentUPDATE.Text;
  //              if (ClassBLL.UpdateClass(classUPDATEBTN))
  //            {
  //              //提示信息
  //              Response.Write("<script>alert('保存成功');location.href='/Class/ClassMain.aspx'</script>");
  //            }
  //              else
  //            {
  //              //提示信息
  //              Response.Write("<script>alert('保存失败');location.href='/Class/ClassMain.aspx'</script>");
  //            }
  //          }
  //          else
  //          {
  //              //提示信息
  //              Response.Write("<script>alert('保存失败，请勿设置相同部门编号或部门名称！');location.href='/Class/ClassMain.aspx'</script>");
  //          }
            
        }

        protected void BTN_EDITBACKMAIN_Click(object sender, EventArgs e)
        {
            //返回主界面,提示信息
            Response.Redirect("/Class/ClassMain.aspx");
        }

        protected void BTN_UPDATE_Command(object sender, CommandEventArgs e)
        {
            if (Txt_classNameUPDATE.Text.Trim()=="" || Txt_classTimeUPDATE.Text.Trim()==""||Txt_classCommentUPDATE.Text.Trim()=="")
            {
                Response.Write("<script>alert('请输入完整信息！')</script>");
            }
            else
            {
                int classid = int.Parse(Txt_classIDUPDATE.Text);
                string classname = Txt_classNameUPDATE.Text;
                DateTime time = DateTime.Parse(Txt_classTimeUPDATE.Text);
                string comment = Txt_classCommentUPDATE.Text;
                string sql = $"select * from Class where ClassID={classid}";
                string sql1 = $"select * from Class where ClassName='{classname}'";
                if (classname != name)
                {
                    if (DAL.ClassDAL.ClassSelect1(sql1).Count > 0)
                    {
                        Response.Write("<script>alert('修改失败，请勿添加相同部门名称！')</script>");
                    }
                    else
                    {
                        Model.Class classadd = new Model.Class();
                        classadd.ClassID = classid;
                        classadd.ClassName = classname;
                        classadd.ClassTime = time;
                        classadd.ClassComment = comment;
                        if (ClassBLL.UpdateClass(classadd))
                        {
                            //提示信息
                            Response.Write("<script>alert('修改成功');location.href='/Class/ClassMain.aspx'</script>");
                        }
                        else
                        {
                            //提示信息
                            Response.Write("<script>alert('修改失败');</script>");
                        }
                    }
                }
                else
                {
                    Model.Class classadd = new Model.Class();
                    classadd.ClassID = classid;
                    classadd.ClassName = classname;
                    classadd.ClassTime = time;
                    classadd.ClassComment = comment;
                    if (ClassBLL.UpdateClass(classadd))
                    {
                        //提示信息
                        Response.Write("<script>alert('修改成功');location.href='/Class/ClassMain.aspx'</script>");
                    }
                    else
                    {
                        //提示信息
                        Response.Write("<script>alert('修改失败');</script>");
                    }
                }
            }
        }
    }
}