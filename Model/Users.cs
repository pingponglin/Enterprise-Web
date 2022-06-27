using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users
    {
        private int userID;//编号
        private string userName;//账号
        private string userPwd;//密码
        private string image;
        private string jiajie;
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPwd { get => userPwd; set => userPwd = value; }
        public string Jiajie { get => jiajie; set => jiajie = value; }
        public string Image { get => image; set => image = value; }
    }
}
