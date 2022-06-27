using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using DAL;

namespace ZY
{
    public partial class Loging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //string uid = TextBox1.Text;
            //string pwd = TextBox2.Text;
            // Model.Users user = new Model.Users();
            // user.UserName = uid;
            // user.UserPwd = pwd;
            // List<Model.Users> list = new List<Model.Users>();
            // list = UsersBLL.SelectUsers(user);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name.Text) || !string.IsNullOrEmpty(t_pwd.Text))
            {
                //string zhanghao="";
                //string mima = "";
                Model.Users user = new Model.Users();
                user.UserName = name.Text;
                user.UserPwd = t_pwd.Text;
                List<Model.Users> list = new List<Model.Users>();
                list = UsersBLL.SelectUsers(user);
                //DataBind();
                if (list.Count > 0)
                {
                    Response.Write("<script>location.href='/Index.aspx'; </script>");
                    Session["name"] = name.Text;
                }
                else
                {
                    //Response.Write("<script>$('#Button1').click(function () {layer.open({content: '浏览器滚动条已锁',scrollbar: false});}); </script>");
                    //调用前段js方法
                    ClientScript.RegisterStartupScript(this.GetType(), "D", "<script>D();</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请输入用户名或者密码！') </script>");
            }
        }

       
    }
    }