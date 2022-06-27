using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntryDAL
    {
        //查询所有已入职员工
        public static List<Entry> SelALLEntry0()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已入职'";
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
        //根据EntryID查询所有已入职员工
        public static List<Entry> SelALLEntryID(int entryid)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已入职' and e.EntryID='{entryid}'";
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
                entry.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                entry.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                list.Add(entry);
            }
            return list;
        }
        //根据身份证查询所有已入职员工
        public static List<Entry> SelALLEntry00(int num)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已入职' and e.EntryIDcard='{num}'";
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
        //查询所有待入职员工
        public static List<Entry> SelALLEntry()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='待入职'";
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
        //查询所有已入职员工
        public static List<Entry> SelALLEntry1()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已入职'";
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
        //查询所有离职员工
        public static List<Entry> SelALLEntry2()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已离职'";
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
        //根据身份证查询所有已离职员工
        public static List<Entry> SelALLEntry22(int num)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已离职' and e.EntryIDcard='{num}'";
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
        //查询所有已辞退员工
        public static List<Entry> SelALLEntry3()
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已辞退'";
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
        //根据身份证查询所有已辞退员工
        public static List<Entry> SelALLEntry33(int num)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已辞退' and e.EntryIDcard='{num}'";
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
        public static List<Entry> SelALLEntry1(string num)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryState='已辞退' and e.EntryIDcard='{num}'";
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
        //根据sql语句差
        public static List<Entry> SelIdCardEntry(string sql)
        {
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Entry> list = new List<Entry>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Entry entry = new Entry();
                entry.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                list.Add(entry);
            }
            return list;
        }
        //根据身份证查询员工
        public static List<Entry> SelIdCardEntry(string idcard,string state)
        {
            string sql = $"select * from  Entry e join Class c on e.ClassID=c.ClassID join Post p on e.PostID=p.PostID where e.EntryIDcard='{idcard}' and e.EntryState='{state}'";
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
        //添加待入职人员
        public static bool Addjia(Model.Entry entry)
        {
            string sql = $"insert into Entry values('{entry.EntryName}','{entry.EntryGender}','{entry.EntryAge}','{entry.EntrySchool}','{entry.EntryTime}','{entry.EntryIDcard}','{entry.EntryPhone}','待入职','{entry.ClassID}','{entry.PostID}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //根据身份证查EntryID
        //Staff表加数据
        public static bool Addjia1(int num)
        {
            string sql = $"insert into Staff values('{num}','实习员工')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //添加已入职员工
        public static bool AddTrue(int num)
        {
            string sql = $"update Entry set EntryState='已入职' where EntryID='{num}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static bool AddStaff(int EntryID)
        {
            string sql = $"insert into Staff values('{EntryID}','实习员工')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //取消已入职员工
        public static bool AddFalse(int num)
        {
            string sql = $"update Entry set EntryState='待入职' where EntryID='{num}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static bool AjjStaff(int EntryID)
        {
            string sql = $"delete from Staff where EntryID='{EntryID}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //添加离职员工
        public static bool AddLZ(int a)
        {
            string sql = $"update Entry set EntryState='已离职'where EntryID='{a}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //添加辞退员工
        public static bool AddCT(int a)
        {
            string sql = $"update Entry set EntryState='已辞退'where EntryID='{a}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //取消离职
        public static bool DelLZ(int a)
        {
            string sql = $"update Entry set EntryState='已入职'where EntryID='{a}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //取消辞退
        public static bool DelCT(int a)
        {
            string sql = $"update Entry set EntryState='已入职'where EntryID='{a}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //根据EntryID修改部门职位
        public static bool UpdTwo(int EntryID,int ClassID,int PostID)
        {
            string sql = $"update Entry set ClassID='{ClassID}',PostID='{PostID}' where EntryID='{EntryID}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //根据EntryID查ClassID
        public static int ClassID(int EntryID)
        {
            string sql = $"select ClassID from Entry where EntryID={EntryID}";
            DataTable dt = DBHelper.GetDataTable(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        //修改部门人数（+）
        public static bool UpdClass1(int a)
        {
            string sql = $"update Class set ClassRecruitsed+=1 where ClassID={a}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //修改部门人数（-）
        public static bool UpdClass2(int a)
        {
            string sql = $"update Class set ClassRecruitsed-=1 where ClassID={a}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //根据EntryID查PostID
        public static int PostID(int EntryID)
        {
            string sql = $"select PostID from Entry where EntryID={EntryID}";
            DataTable dt = DBHelper.GetDataTable(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        //修改职位人数（+）
        public static bool UpdPost1(int a)
        {
            string sql = $"update Post set PostRecruitsed+=1 where PostID={a}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //修改职位人数（-）
        public static bool UpdPost2(int a)
        {
            string sql = $"update Post set PostRecruitsed-=1 where PostID={a}";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
