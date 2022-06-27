using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Post
    {
        private int postID;
        private string postName;
        private decimal postSalary;
        private int postRecruitsed;
        private string postComment;
        private int classID;

        public int PostID { get => postID; set => postID = value; }
        public string PostName { get => postName; set => postName = value; }
        public decimal PostSalary { get => postSalary; set => postSalary = value; }
        public int PostRecruitsed { get => postRecruitsed; set => postRecruitsed = value; }
        public string PostComment { get => postComment; set => postComment = value; }
        public int ClassID { get => classID; set => classID = value; }
    }
}
