using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class PostBLL
    {
        //增加
        public static bool AddPost(Post postbllzj)
        {
            return PostDAL.PostAdd(postbllzj);
        }
        //删除
        public static bool DeletePost(Post postbllsc)
        {
            return PostDAL.PostDelete(postbllsc);
        }
        //修改
        public static bool UpdatePost(Post postbllxg)
        {
            return PostDAL.PostUpdate(postbllxg);
        }
        //查询
        public static List<Post> SelectPost()
        {
            return PostDAL.PostSelect();
        }
        public static List<Post> GetAllPost(string sql)
        {
            return PostDAL.PostSelect(sql);
        }
    }
}
