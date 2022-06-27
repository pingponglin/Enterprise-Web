using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZY.Work
{
    public partial class WorkUpd : System.Web.UI.Page
    {
        public static int staffid;//全局变量
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
                //初始化
                staffid = int.Parse(Session["EntryID"].ToString());//获取编号
                Label2.Text = DAL.EntryDAL.SelALLEntryID(staffid)[0].EntryName;
                Label6.Text = DAL.EntryDAL.SelALLEntryID(staffid)[0].EntryTime.ToString();
                Label4.Text = DAL.EntryDAL.SelALLEntryID(staffid)[0].EntryIDcard;
                Label8.Text = DAL.EntryDAL.SelALLEntryID(staffid)[0].EntryPhone;
                DropDownList2.SelectedValue = DAL.EntryDAL.SelALLEntryID(staffid)[0].ClassID.ToString();
                DropDownList3.SelectedValue = DAL.EntryDAL.SelALLEntryID(staffid)[0].PostID.ToString();
            }
        }
        //职位随着部门改变
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
        //部门随着职位改变
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
        //返回
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkHome.aspx");
        }
        //修改
        protected void Button1_Click(object sender, EventArgs e)
        {
            //修改的员工编号
            int EntryID = staffid;
            //修改的员工名称
            string name = DAL.EntryDAL.SelALLEntryID(EntryID)[0].EntryName;
            //修改前的部门编号
            int ClassID = DAL.EntryDAL.SelALLEntryID(EntryID)[0].ClassID;
            //修改前的职位编号
            int PostID= DAL.EntryDAL.SelALLEntryID(EntryID)[0].PostID;
            //修改员工的身份证号
            string IDcard= DAL.EntryDAL.SelALLEntryID(EntryID)[0].EntryIDcard;
            //调岗的试卷
            DateTime time = DateTime.Now;
            if (DropDownList2.SelectedItem.Value==""|| DropDownList3.SelectedItem.Value == ""||string.IsNullOrEmpty(DropDownList2.SelectedItem.Value)|| string.IsNullOrEmpty(DropDownList3.SelectedItem.Value))
            {
                Response.Write("<script>alert('请输入完整信息')</script>");
            }
            else
            {
                int NewClassID = int.Parse(DropDownList2.SelectedItem.Value);//修改后的部门编号
                int NewPostID = int.Parse(DropDownList3.SelectedItem.Value);//修改后的职位编号
                //修改部门职位
                DAL.EntryDAL.UpdTwo(EntryID, NewClassID, NewPostID);
                //添加到Text表
                DAL.TextDAL.TextAdd(name, IDcard,time, PostID, ClassID, NewPostID, NewClassID);
                Response.Write("<script>alert('调岗成功');location.href='WorkHome.aspx'</script>");
                //修改部门人数(+)
                DAL.EntryDAL.UpdClass1(NewClassID);
                //修改职位人数(+)
                DAL.EntryDAL.UpdPost1(NewPostID);
                //修改部门人数(-)
                DAL.EntryDAL.UpdClass2(ClassID);
                //修改职位人数(-)
                DAL.EntryDAL.UpdPost2(PostID);
            }
        }
    }
}