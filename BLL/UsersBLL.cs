using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
using Model;

namespace BLL
{
   public class UsersBLL
    {
        public static List<Users> SelectUsers(Users users) {
            return UsersDAL.UsersSelect(users);
        }
        //增
        public static bool Inert(Users users)
        {
            return UsersDAL.InsertU(users);
        }
        //删
        public static bool Delete(Users users)
        {
            return UsersDAL.DeleteU(users);
        }
        //查所有的账号信息
        public static List<Users> GetAllUsers()
        {
            return UsersDAL.SelectU();
        }
      
        //根据特定语句查账号信息
        public static List<Users> GetAllUsers(string sql)
        {
            return UsersDAL.SelectU(sql);
        }
        //根据ID查账号信息
        public static Users GetUserByID(int userID)
        {
            Model.Users user = new Model.Users();
            string sql = $"select * from Users where UserID='{userID}'";
            if (GetAllUsers(sql).Count() > 0)
            {
                user = GetAllUsers(sql)[0];
            }
            return user;
        }
        //改
        public static bool UpdateU(Users users)
        {
            return UsersDAL.UpdateU(users);
        }
    }
}
