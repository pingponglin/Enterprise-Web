using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace ZY.Staff
{
    public partial class StaffAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*部门*/
                DropDownList2.DataSource = BLL.StaffBLL.SelALLClass();
                DropDownList2.DataValueField = "ClassID";
                DropDownList2.DataTextField = "ClassName";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
                /*职位*/
                DropDownList3.DataSource = BLL.StaffBLL.SelALLPost();
                DropDownList3.DataValueField = "PostID";
                DropDownList3.DataTextField = "PostName";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            TextBox3.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            ddlSex.SelectedIndex = 0;
            /*职位*/
            DropDownList3.DataSource = BLL.StaffBLL.SelALLPost();
            DropDownList3.DataValueField = "PostID";
            DropDownList3.DataTextField = "PostName";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            DropDownList3.SelectedIndex = 0;
        }
        /*返回*/
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Staff/StaffHome.aspx");
        }
        //添加新员工
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == " " || ddlSex.SelectedItem.Text == "*请选择*" || TextBox3.Text == " " || DropDownList1.SelectedItem.Text == "*请选择*" || TextBox5.Text == " " || TextBox6.Text == " " || DropDownList2.SelectedItem.Text == "*请选择*" || DropDownList3.SelectedItem.Text == "*请选择*")
            {
                Response.Write("<script>alert('请输入完整信息')</script>");
            }
            else
            {
                if (TextBox5.Text.Trim().Length!=18)
                {
                    Response.Write("<script>alert('身份证位数输入不正确')</script>");
                }
                else
                {
                    Model.Entry staff = new Model.Entry();
                    staff.EntryName = TextBox1.Text;
                    staff.EntryGender = ddlSex.Text;
                    staff.EntryAge = int.Parse(TextBox3.Text);
                    staff.EntrySchool = DropDownList1.Text;
                    staff.EntryTime = DateTime.Now;
                    staff.EntryIDcard = TextBox5.Text;
                    staff.EntryPhone = TextBox6.Text;
                    staff.ClassID = int.Parse(DropDownList2.SelectedItem.Value);
                    staff.PostID = int.Parse(DropDownList3.SelectedItem.Value);
                    if (BLL.StaffBLL.AddStaff(staff))
                    {
                        Response.Write("<script>alert('添加成功');location.href='StaffHome.aspx'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('添加失败，请联系管理员');location.href='StaffHome.aspx'</script>");
                    }
                }
            }
        }
        //职位随部门改动
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
        //部门随职位改动
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
    }
}