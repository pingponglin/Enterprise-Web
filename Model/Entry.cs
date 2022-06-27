using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Entry
    {
        private string fuhao;
        private int entryID;//员工编号
        private string entryName;//员工姓名
        private string entryGender;//员工性别
        private int entryAge;//员工年龄
        private string entrySchool;//员工学历
        private DateTime entryTime;//入职时间
        private string entryState;//状态
        private string entryIDcard;//身份证号
        private string entryPhone;//联系电话
        private string className;//部门名称
        private int classID;//部门编号
        private int staffID;//入职员工编号
        private string postName;//职位名称
        private int postID;//职位编号

        public string Fuhao { get => fuhao; set => fuhao = value; }
        public int EntryID { get => entryID; set => entryID = value; }
        public string EntryName { get => entryName; set => entryName = value; }
        public string EntryGender { get => entryGender; set => entryGender = value; }
        public int EntryAge { get => entryAge; set => entryAge = value; }
        public string EntrySchool { get => entrySchool; set => entrySchool = value; }
        public DateTime EntryTime { get => entryTime; set => entryTime = value; }
        public string EntryIDcard { get => entryIDcard; set => entryIDcard = value; }
        public string EntryPhone { get => entryPhone; set => entryPhone = value; }
        public string ClassName { get => className; set => className = value; }
        public int ClassID { get => classID; set => classID = value; }
        public string PostName { get => postName; set => postName = value; }
        public int PostID { get => postID; set => postID = value; }
        public int StaffID { get => staffID; set => staffID = value; }
        public string EntryState { get => entryState; set => entryState = value; }
    }
}