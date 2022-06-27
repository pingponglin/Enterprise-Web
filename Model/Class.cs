using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Class
    {
        private int classID;
        private string className;
        private DateTime classTime;
        private int classRecruits;
        private int classRecruitsed;
        private string classComment;

        public int ClassID { get => classID; set => classID = value; }
        public string ClassName { get => className; set => className = value; }
        public DateTime ClassTime { get => classTime; set => classTime = value; }
        public int ClassRecruits { get => classRecruits; set => classRecruits = value; }
        public int ClassRecruitsed { get => classRecruitsed; set => classRecruitsed = value; }
        public string ClassComment { get => classComment; set => classComment = value; }
    }
}
