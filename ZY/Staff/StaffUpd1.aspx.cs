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
    public partial class StaffUpd1 : System.Web.UI.Page
    {
        public static int staffid;//全局变量
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ///*部门*/
                //DropDownList2.DataSource = BLL.StaffBLL.SelALLClass();
                //DropDownList2.DataValueField = "ClassID";
                //DropDownList2.DataTextField = "ClassName";
                //DropDownList2.DataBind();
                //DropDownList2.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
                ///*职位*/
                //DropDownList3.DataSource = BLL.StaffBLL.SelALLPost();
                //DropDownList3.DataValueField = "PostID";
                //DropDownList3.DataTextField = "PostName";
                //DropDownList3.DataBind();
                //DropDownList3.Items.Insert(0, new ListItem() { Text = "*请选择*", Value = "" });
                /*初始化*/
                staffid = int.Parse(Session["EntryID"].ToString());
                Model.Entry staff = new Model.Entry();
                staff.EntryID = staffid;
                TextBox1.Text = DAL.StaffDAL.SelALLStaff11(staff)[0].EntryName;
                ddlSex.Text = DAL.StaffDAL.SelALLStaff11(staff)[0].EntryGender;
                TextBox3.Text = DAL.StaffDAL.SelALLStaff11(staff)[0].EntryAge.ToString();
                DropDownList1.Text = DAL.StaffDAL.SelALLStaff11(staff)[0].EntrySchool;
                TextBox5.Text = DAL.StaffDAL.SelALLStaff11(staff)[0].EntryIDcard;
                TextBox6.Text = DAL.StaffDAL.SelALLStaff11(staff)[0].EntryPhone;
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
        }
        //修改
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || ddlSex.SelectedItem.Text == "*请选择*" || TextBox3.Text == "" || DropDownList1.SelectedItem.Text == "*请选择*" || TextBox5.Text == "" || TextBox6.Text == "")
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
                    Model.Entry staff = new Model.Entry();
                    staff.EntryID = staffid;
                    staff.EntryName = TextBox1.Text;
                    staff.EntryGender = ddlSex.Text;
                    staff.EntryAge = int.Parse(TextBox3.Text);
                    staff.EntrySchool = DropDownList1.Text;
                    staff.EntryTime = DateTime.Now;
                    staff.EntryIDcard = TextBox5.Text;
                    staff.EntryPhone = TextBox6.Text;
                    if (BLL.StaffBLL.UpdStaff(staff))
                    {
                        Response.Write("<script>alert('修改成功');location.href='/Entry/EntryHome.aspx'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('修改失败，请联系管理员');location.href='/Entry/EntryHome.aspx'</script>");
                    }
                }
            }
        }
        //返回
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Entry/EntryHome.aspx");
        }
        /*
        //职位随部门变化
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
        //部门随职位变换
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
            }*/
        }
    }