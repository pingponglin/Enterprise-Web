using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ClassBLL
    {
        //增加
        public static bool AddClass(Class classbllzj)
        {
            return ClassDAL.ClassAdd(classbllzj);
        }
        //删除
        public static bool DeleteClass(Class classbllsc)
        {
            return ClassDAL.classDelete(classbllsc);
        }
        //修改
        public static bool UpdateClass(Class classbllxg)
        {
            return ClassDAL.ClassUpdate(classbllxg);
        }
        //查询
        public static List<Class> SelectClass()
        {
            return ClassDAL.ClassSelect();
        }
        public static List<Class> GetAllClass(string sql)
        {
            return ClassDAL.ClassSelect(sql);
        }
    }
}
