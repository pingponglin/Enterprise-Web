using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffBLL
    {
        //查询所有员工
        public static List<Entry> SelALLStaff()
        {
            return DAL.StaffDAL.SelALLStaff1();   
        }
        //根据员工编号查询员工
        public static List<Entry> SelALLStaff(Entry staff)
        {
            return DAL.StaffDAL.SelALLStaff(staff);
        }
        //根据部门名称查部门编号
        public static int SelClassID(Class @class)
        {
            return DAL.StaffDAL.SelClassID(@class);
        }
         
            //查询所有部门
            public static List<Class> SelALLClass()
        {
            return DAL.StaffDAL.SelALLClass();
        }
        //查询所有部门
        public static List<Class> SelALLClass(Post post)
        {
            return DAL.StaffDAL.SelALLClass(post);
        }
        //根据职位编号查部门编号
        public static int SelALLClassID(Post post)
        {
            return DAL.StaffDAL.SelALLClassID(post);
        }
        //查询所有职位
        public static List<Post> SelALLPost()
        {
            return DAL.StaffDAL.SelALLPost();
        }
        //根据部门查询所有职位
        public static List<Post> SelALLPost(Class @class)
        {
            return DAL.StaffDAL.SelALLPost(@class);
         }
        //添加员工
            public static bool AddStaff(Entry staff)
        {
            return DAL.StaffDAL.AddStaff(staff);
        }
        //删除员工
        public static bool DelStaff(Entry staff)
        {
            return DAL.StaffDAL.DelStaff(staff);
        }
        //修改员工
        public static bool UpdStaff(Entry staff)
        {
            return DAL.StaffDAL.UpdStaff(staff);
        }
    }
}
