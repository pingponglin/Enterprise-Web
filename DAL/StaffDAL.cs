using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class StaffDAL
    {
        //查询所有实习员工
        public static List<Entry> SelALLStaff1()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID join Staff s on e.EntryID=s.EntryID where s.StaffState='实习员工' and e.EntryState='已入职'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry = new Entry();
                entry.Fuhao="□";
                entry.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                DateTime time=DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry.EntryTime = time;
                entry.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry.PostName = dt.Rows[i]["PostName"].ToString();
                //entry.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                list.Add(entry);
            }
            return list;
        }
        public static List<Entry> SelALLStaff11(Entry entry1)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID  where e.EntryID='{entry1.EntryID}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry = new Entry();
                entry.Fuhao = "□";
                entry.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                DateTime time = DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry.EntryTime = time;
                entry.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry.PostName = dt.Rows[i]["PostName"].ToString();
                //entry.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                list.Add(entry);
            }
            return list;
        }
        //查询所有正式员工
        public static List<Entry> SelALLStaff2()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID join Staff s on e.EntryID=s.EntryID where s.StaffState='正式员工' and e.EntryState='已入职'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry = new Entry();
                entry.Fuhao = "□";
                entry.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                DateTime time = DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry.EntryTime = time;
                entry.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry.PostName = dt.Rows[i]["PostName"].ToString();
                //entry.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                list.Add(entry);
            }
            return list;
        }
        //根据员工编号查询员工
        public static List<Entry> SelALLStaff(Entry entry)
        {
            string sql = $"select * from Entry s join Class c on s.ClassID=c.ClassID join Post p on s.PostID=p.PostID join Staff on s.EntryID=Staff.EntryID where s.EntryID='{entry.EntryID}' and s.EntryState='已入职'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry1 = new Entry();
                entry1.Fuhao = "□";
                entry1.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry1.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry1.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry1.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry1.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                entry1.EntryTime = DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry1.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry1.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry1.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry1.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(entry1);
            }
            return list;
        }
        //根据员工姓名查询员工
        public static List<Entry> SelALLNameStaff(Entry entry)
        {
            string sql = $"select * from Entry s join Class c on s.ClassID=c.ClassID join Post p on s.PostID=p.PostID join Staff on s.EntryID=Staff.EntryID where s.EntryName like'%{entry.EntryName}%' and Staff.StaffState='{entry.EntryState}' and s.EntryState='已入职'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry1 = new Entry();
                entry1.Fuhao = "□";
                entry1.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry1.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry1.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry1.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry1.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                entry1.EntryTime = DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry1.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry1.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry1.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry1.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(entry1);
            }
            return list;
        }
        //根据员工身份证查询员工
        public static List<Entry> SelALLIDStaff(Entry entry)
        {
            string sql = $"select * from Entry s join Class c on s.ClassID=c.ClassID join Post p on s.PostID=p.PostID join Staff on s.EntryID=Staff.EntryID where s.EntryIDcard='{entry.EntryIDcard}' and Staff.StaffState='{entry.EntryState}' and s.EntryState='已入职'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry1 = new Entry();
                entry1.Fuhao = "□";
                entry1.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry1.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry1.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry1.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry1.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                entry1.EntryTime = DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry1.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry1.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry1.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry1.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(entry1);
            }
            return list;
        }
        //根据员工姓名和身份证来查
        public static List<Entry> SelALLTwoStaff(Entry entry)
        {
            string sql = $"select * from Entry s join Class c on s.ClassID=c.ClassID join Post p on s.PostID=p.PostID join Staff on s.EntryID=Staff.EntryID where s.EntryIDcard='{entry.EntryIDcard}' and s.EntryName like'%{entry.EntryName}%' and Staff.StaffState='{entry.EntryState}' and s.EntryState='已入职'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry1 = new Entry();
                entry1.Fuhao = "□";
                entry1.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                entry1.EntryName = dt.Rows[i]["EntryName"].ToString();
                entry1.EntryGender = dt.Rows[i]["EntryGender"].ToString();
                entry1.EntryAge = int.Parse(dt.Rows[i]["Entryage"].ToString());
                entry1.EntrySchool = dt.Rows[i]["EntrySchool"].ToString();
                entry1.EntryTime = DateTime.Parse(dt.Rows[i]["EntryTime"].ToString());
                entry1.EntryIDcard = dt.Rows[i]["EntryIDcard"].ToString();
                entry1.EntryPhone = dt.Rows[i]["EntryPhone"].ToString();
                entry1.ClassName = dt.Rows[i]["ClassName"].ToString();
                entry1.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(entry1);
            }
            return list;
        }
        //根据部门名称查部门编号
        public static int SelClassID(Class @class)
        {
            string sql = $"select * from Class where ClassName='{@class.ClassName}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        //查询所有部门
        public static List<Class> SelALLClass()
        {
            string sql = $"select * from Class";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Class> list = new List<Class>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Class @class = new Class();
                @class.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                @class.ClassName = dt.Rows[i]["ClassName"].ToString();
                list.Add(@class);
            }
            return list;
        }
        //根据职位编号查部门编号
        public static int SelALLClassID(Post post)
        {
            string sql = $"select * from Post where postid='{post.PostID}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            return int.Parse(dt.Rows[0]["ClassID"].ToString());
        }
        //根据职位查询部门
        public static List<Class> SelALLClass(Post post)
        {
            string sql = $"select * from Class where ClassID='{post.ClassID}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Class> list = new List<Class>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Class @class = new Class();
                @class.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                @class.ClassName = dt.Rows[i]["ClassName"].ToString();
                list.Add(@class);
            }
            return list;
        }
        //查询所有职位
        public static List<Post> SelALLPost()
        {
            string sql = $"select * from Post";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Post> list = new List<Post>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post post = new Post();
                post.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                post.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(post);
            }
            return list;
        }
        //根据部门查询所有职位
        public static List<Post> SelALLPost(Class @class)
        {
            string sql = $"select * from Post where ClassID='{@class.ClassID}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Post> list = new List<Post>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post post = new Post();
                post.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                post.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(post);
            }
            return list;
        }
        //添加员工
        public static bool AddStaff(Entry entry)
        {
            string sql = $"insert into Entry values('{entry.EntryName}','{entry.EntryGender}','{entry.EntryAge}','{entry.EntrySchool}','{entry.EntryTime}','{entry.EntryIDcard}','{entry.EntryPhone}','{entry.ClassID}','{entry.PostID}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //删除员工
        public static bool DelStaff(Entry entry)
        {
            string sql = $"delete from Entry where EntryID='{entry.EntryID}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //修改员工
        public static bool UpdStaff(Entry entry)
        {
            string sql = $"update Entry set EntryName='{entry.EntryName}',EntryGender='{entry.EntryGender}',EntryAge='{entry.EntryAge}',EntrySchool='{entry.EntrySchool}',EntryTime='{entry.EntryTime}',EntryIDcard='{entry.EntryIDcard}',EntryPhone='{entry.EntryPhone}' where EntryID='{entry.EntryID}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //实习员工转正
        public static  bool UpdStaffZZ(int a)
        {
            string sql = $"update Staff set StaffState='正式员工' where EntryID='{a}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //取消转正
        public static bool UpdStaffQX(int a)
        {
            string sql = $"update Staff set StaffState='实习员工' where EntryID='{a}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //根据部门编号查部门名称
        public static string SelClass(int ClassID)
        {
            string sql = $"select * from Class where ClassID='{ClassID}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt.Rows[0]["ClassName"].ToString();
        }
        //根据职位编号查职位名称
        public static string SelPost(int PostID)
        {
            string sql = $"select * from Post where PostID='{PostID}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt.Rows[0]["PostName"].ToString();
        }
    }
}
