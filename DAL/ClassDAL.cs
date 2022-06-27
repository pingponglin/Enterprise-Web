using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ClassDAL
    {
        //增加
        public static bool ClassAdd(Class classdalzj)
        {
            string sql = string.Format("insert Class Values('{0}','{1}','{2}','{3}','{4}')",classdalzj.ClassID,classdalzj.ClassName,classdalzj.ClassTime,classdalzj.ClassRecruitsed,classdalzj.ClassComment);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //删除
        public static bool classDelete(Class classdalsc)
        {
            string sql = string.Format("Delete from Class where ClassID={0}", classdalsc.ClassID);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //修改
        public static bool ClassUpdate(Class classdalxg)
        {
            string sql = string.Format("update Class set ClassName='{0}',ClassTime='{1}', ClassComment='{2}' where ClassID={3}", classdalxg.ClassName, classdalxg.ClassTime,classdalxg.ClassComment,classdalxg.ClassID);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //查询
        public static List<Class> ClassSelect()
        {
            string sql = $"select * from Class";
            List<Class> list = new List<Class>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Class classcx = new Class();
                classcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                classcx.ClassName = dt.Rows[i]["ClassName"].ToString();
                classcx.ClassTime = DateTime.Parse(dt.Rows[i]["ClassTime"].ToString());
                classcx.ClassRecruitsed = int.Parse(dt.Rows[i]["ClassRecruitsed"].ToString());
                classcx.ClassComment = dt.Rows[i]["ClassComment"].ToString();
                list.Add(classcx);
            }
            return list;
        }
        public static List<Class> ClassSelect(string sql)
        {

            List<Class> list = new List<Class>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Class classcx = new Class();
                classcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                classcx.ClassName = dt.Rows[i]["ClassName"].ToString();
                classcx.ClassTime = DateTime.Parse(dt.Rows[i]["ClassTime"].ToString());
                classcx.ClassRecruitsed = int.Parse(dt.Rows[i]["ClassRecruitsed"].ToString());
                classcx.ClassComment = dt.Rows[i]["ClassComment"].ToString();
                list.Add(classcx);
            }
            return list;
        }
        //对比查询
        public static List<Class> ClassSelect1(string sql)
        {
            
            List<Class> list = new List<Class>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Class classcx = new Class();
                classcx.ClassID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                classcx.ClassName = dt.Rows[i]["ClassName"].ToString();
                classcx.ClassTime = DateTime.Parse(dt.Rows[i]["ClassTime"].ToString());
                classcx.ClassRecruitsed = int.Parse(dt.Rows[i]["ClassRecruitsed"].ToString());
                classcx.ClassComment = dt.Rows[i]["ClassComment"].ToString();
                list.Add(classcx);
            }
            return list;
        }
        //根据部门编号查职位
        public static List<Post> SelPost(int classid)
        {
            string sql = $"select * from Post where ClassID={classid}";
            List<Post> list = new List<Post>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Post post = new Post();
                post.PostName= dt.Rows[i]["PostName"].ToString();
                list.Add(post);
            }
            return list;
        }
    }
}
