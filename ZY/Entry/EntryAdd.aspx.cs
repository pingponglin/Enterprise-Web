using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Entry
{
    public partial class EntryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ///*部门*/
                DropDownList2.DataSource = BLL.StaffBLL.SelALLClass();
                DropDownList2.DataValueField = "ClassID";
                DropDownList2.DataTextField = "ClassName";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
                ///*职位*/
                DropDownList3.DataSource = BLL.StaffBLL.SelALLPost();
                DropDownList3.DataValueField = "PostID";
                DropDownList3.DataTextField = "PostName";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
            }
        }

            protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedIndex == 0)
            {
                DropDownList3.DataSource = BLL.StaffBLL.SelALLPost();
                DropDownList3.DataValueField = "PostID";
                DropDownList3.DataTextField = "PostName";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
            }
            else
            {
                Model.Class @class = new Model.Class();
                @class.ClassID = int.Parse(DropDownList2.SelectedItem.Value);
                DropDownList3.DataSource = BLL.StaffBLL.SelALLPost(@class);
                DropDownList3.DataValueField = "PostID";
                DropDownList3.DataTextField = "PostName";
                DropDownList3.DataBind();
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedIndex == 0)
            {
                DropDownList2.DataSource = BLL.StaffBLL.SelALLClass();
                DropDownList2.DataValueField = "ClassID";
                DropDownList2.DataTextField = "ClassName";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
            }
            else
            {
                Post post = new Post();
                post.PostID = int.Parse(DropDownList3.SelectedItem.Value);
                post.ClassID = BLL.StaffBLL.SelALLClassID(post);
                DropDownList2.DataSource = BLL.StaffBLL.SelALLClass(post);
                DropDownList2.DataValueField = "ClassID";
                DropDownList2.DataTextField = "ClassName";
                DropDownList2.DataBind();
            }
        }
        //重置
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            TextBox3.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            ddlSex.SelectedIndex = 0;
            DropDownList1.SelectedIndex = 0;
            DropDownList2.DataSource = BLL.StaffBLL.SelALLClass();
            DropDownList2.DataValueField = "ClassID";
            DropDownList2.DataTextField = "ClassName";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
            DropDownList3.DataSource = BLL.StaffBLL.SelALLPost();
            DropDownList3.DataValueField = "PostID";
            DropDownList3.DataTextField = "PostName";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
        }
        //添加
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string gender = ddlSex.Text;
            string age = TextBox3.Text;
            string school = DropDownList1.SelectedItem.Value;
            string idcard = TextBox5.Text;
            string phone = TextBox6.Text;
            string clas = DropDownList2.SelectedItem.Value;
            string post = DropDownList3.SelectedItem.Value;
            if (name==" "||gender==" "||age==" "||school== "*请选择*"||idcard==" "||phone==" "||clas== ""||post== "")
            {
                Response.Write("<script>alert('请输入完整信息')</script>");
            }
            else
            {
                if (TextBox5.Text.Trim().Length != 18)
                {
                    Response.Write("<script>alert('身份证位数输入不正确')</script>");
                }
                else
                {
                    Model.Entry entry = new Model.Entry();
                    entry.EntryName = name;
                    entry.EntryGender = gender;
                    entry.EntryAge = int.Parse(age);
                    entry.EntrySchool = school;
                    entry.EntryTime = DateTime.Now;
                    entry.EntryIDcard = idcard;
                    entry.EntryPhone = phone;
                    entry.ClassID = int.Parse(clas);
                    entry.PostID = int.Parse(post);
                    DAL.EntryDAL.Addjia(entry);
                    Response.Write("<script>alert('添加成功');location.href='EntryHome.aspx'</script>");
                }
            }
        }
        //返回
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EntryHome.aspx");
        }
    }
}