using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Text
    {
        private int textID;
        private string textName;
        private string textIDcard;
        private DateTime textTime;
        private string textPostID;
        private string textNewPostID;
        private string textClassID;
        private string textNewClassID;

        public int TextID { get => textID; set => textID = value; }
        public string TextName { get => textName; set => textName = value; }
        public string TextIDcard { get => textIDcard; set => textIDcard = value; }
        public DateTime TextTime { get => textTime; set => textTime = value; }
        public string TextPostID { get => textPostID; set => textPostID = value; }
        public string TextNewPostID { get => textNewPostID; set => textNewPostID = value; }
        public string TextClassID { get => textClassID; set => textClassID = value; }
        public string TextNewClassID { get => textNewClassID; set => textNewClassID = value; }
    }
}
