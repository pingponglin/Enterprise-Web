using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class PostDAL
    {
        //增加
        public static bool PostAdd(Post postdalzj)
        {
            string sql = string.Format("insert Post Values('{0}','{1}','{2}','{3}','{4}','{5}')",postdalzj.PostID,postdalzj.PostName,postdalzj.PostSalary,postdalzj.PostRecruitsed,postdalzj.PostComment,postdalzj.ClassID);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //删除
        public static bool PostDelete(Post postdalsc)
        {
            string sql = string.Format("Delete from Post where PostID={0}", postdalsc.PostID);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //修改
        public static bool PostUpdate(Post postdalxg)
        {
            string sql = string.Format("update Post set PostName='{0}',PostSalary='{1}',PostRecruitsed='{2}',PostComment='{3}',ClassID='{4}' where PostID={5}", postdalxg.PostName,postdalxg.PostSalary,postdalxg.PostRecruitsed,postdalxg.PostComment,postdalxg.ClassID,postdalxg.PostID);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //查询
        public static List<Post> PostSelect()
        {
            string sql = $"select * from Post";
            List<Post> list = new List<Post>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post postcx = new Post();
                postcx.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                postcx.PostName = dt.Rows[i]["PostName"].ToString();
                postcx.PostSalary = decimal.Parse(dt.Rows[i]["PostSalary"].ToString());
                
                postcx.PostRecruitsed = int.Parse(dt.Rows[i]["PostRecruitsed"].ToString());
                postcx.PostComment = dt.Rows[i]["PostComment"].ToString();
                postcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                list.Add(postcx);
            }
            return list;
        }
        public static List<Post> PostSelect(string sql)
        {
          
            List<Post> list = new List<Post>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post postcx = new Post();
                postcx.PostID = int.Parse(dt.Rows[i]["PostID"].ToString());
                postcx.PostName = dt.Rows[i]["PostName"].ToString();
                postcx.PostSalary = decimal.Parse(dt.Rows[i]["PostSalary"].ToString());
                
                postcx.PostRecruitsed = int.Parse(dt.Rows[i]["PostRecruitsed"].ToString());
                postcx.PostComment = dt.Rows[i]["PostComment"].ToString();
                postcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                list.Add(postcx);
            }
            return list;
        }
        public static List<Post> PostSelect1(string sql)
        {

            List<Post> list = new List<Post>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post postcx = new Post();
                postcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                list.Add(postcx);
            }
            return list;
        }
        public static List<Post> SelectPostID(int postid)
        {
            List<Post> list = new List<Post>();
            string sql = $"select * from Post where PostID={postid}";
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post postcx = new Post();
                postcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                list.Add(postcx);
            }
            return list;
        }
        public static List<Post> SelectPostName(string postname)
        {
            List<Post> list = new List<Post>();
            string sql = $"select * from Post where PostName='{postname}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post postcx = new Post();
                postcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                list.Add(postcx);
            }
            return list;
        }
        public static List<Post> SelectPostUpd(string postname)
        {
            string sql = $"select * from Post where PostName='{postname}'";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Post> posts = new List<Post>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post postcx = new Post();
                postcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                posts.Add(postcx);
            }
            return posts;
        }
        //根据ID查Name
        public static string SelectPostName1(int postid)
        {
            string sql = $"select PostName from Post where PostID={postid}";
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt.Rows[0][0].ToString();
        }
    }
}
