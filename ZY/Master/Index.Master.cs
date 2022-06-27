using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Master
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public static string image11="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = Session["name"].ToString();
                Repeater1.DataSource = DAL.UsersDAL.SelectU();
                Repeater1.DataBind();
                Model.Users users = new Model.Users();
               
                List<Model.Users> list = new List<Model.Users>();
                list = DAL.UsersDAL.SelectU1(Label1.Text);
                foreach (var item in list)
                {
                    TextBox1.Text = item.UserName.ToString();
                    TextBox2.Text = item.UserPwd.ToString();
                    TextBox3.Text = item.Jiajie.ToString();
                    TextBox4.Text = item.Image.ToString();
                    image11=".."+item.Image.ToString();
                    
                   
                    //头像上传
                    //获取上传文件名
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.Users users = new Model.Users();
            if (File_Image.FileName != "")
            {
                users.Image = "/Image/" + File_Image.FileName;
                //头像上传
                //获取上传文件名
                string filename = File_Image.FileName;
                File_Image.SaveAs(Server.MapPath("~/Image/") + filename);
                image11 = ".." + users.Image.ToString();
            }
            else
            {
                users.Image = TextBox4.Text;
            }
            users.UserName = TextBox1.Text;
            users.UserPwd = TextBox2.Text;
            users.Jiajie = TextBox3.Text;
            if (DAL.UsersDAL.UpdateU1(users))
            {
                TextBox4.Text = users.Image.ToString();
               Page.ClientScript.RegisterStartupScript(this.GetType(), "M", "<script>M();</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "M1", "<script>M1();</script>");
            }
        }
    }
}