using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
  public  class UsersDAL
    {
        public static List<Users> UsersSelect(Users user)
        {
            List<Users> list = new List<Users>();
            string sql = string.Format("select*from Users where UserName='{0}'and UserPwd='{1}'",user.UserName,user.UserPwd);
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users users = new Users();
                users.UserID = int.Parse(dt.Rows[i]["UserID"].ToString());
                users.UserName = dt.Rows[i]["UserName"].ToString();
                users.UserPwd = dt.Rows[i]["UserPwd"].ToString();
             
                list.Add(users);
            }
            return list;
        }
        //增
        public static bool InsertU(Users users)
        {
            string sql = $"insert into Users values ('{users.UserName}','{users.UserPwd}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //删
        public static bool DeleteU(Users users)
        {
            string sql = $"delete from Users where UserID='{users.UserID}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //查
        public static List<Users> SelectU()
        {
            List<Users> list = new List<Users>();//所有的部门信息
            string sql = $"select * from Users";
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users users = new Users();
                users.UserID = int.Parse(dt.Rows[i]["UserID"].ToString());
                users.UserName = dt.Rows[i]["UserName"].ToString();
                users.UserPwd = dt.Rows[i]["UserPwd"].ToString();
                users.Image = dt.Rows[i]["Userimages"].ToString();
                users.Jiajie = dt.Rows[i]["Userjianjie"].ToString();
                list.Add(users);
            }
            return list;
        }
        public static List<Users> SelectU1(string name)
        {
            List<Users> list = new List<Users>();//所有的部门信息
            string sql = $"select * from Users where UserName='{name}'";
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users users = new Users();
                users.UserID = int.Parse(dt.Rows[i]["UserID"].ToString());
                users.UserName = dt.Rows[i]["UserName"].ToString();
                users.UserPwd = dt.Rows[i]["UserPwd"].ToString();
                users.Image = dt.Rows[i]["Userimages"].ToString();
                users.Jiajie = dt.Rows[i]["Userjianjie"].ToString();
                list.Add(users);
            }
            return list;
        }
        public static List<Users> SelectU(string sql)
        {
            List<Users> list = new List<Users>();//所有的部门信息
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users user = new Users();
                user.UserID = int.Parse(dt.Rows[i]["UserID"].ToString());
                user.UserName = dt.Rows[i]["UserName"].ToString();
                user.UserPwd = dt.Rows[i]["UserPwd"].ToString();
                list.Add(user);
            }
            return list;
        }
     
        //改
        public static bool UpdateU(Users users)
        {
            string sql = $"update Users set UserName='{users.UserName}',UserPwd='{users.UserPwd}' where UserID={users.UserID}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static bool UpdateU1(Users users)
        {
            string sql = $"update Users set UserName='{users.UserName}',UserPwd='{users.UserPwd}',Userimages='{users.Image}',Userjianjie='{users.Jiajie}' where UserName='{users.UserName}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
