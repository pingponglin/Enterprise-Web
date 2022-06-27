using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Train
    {
        private int trainID;//编号
        private string trainName;//培训人
        private string trainTheme;//培训主题
        private DateTime trainTime;//培训时间
        private string trainAddress;//培训地点
        private int trainNum;//培训人数
        private int staffID;//培训学员编号

        public int TrainID { get => trainID; set => trainID = value; }
        public string TrainName { get => trainName; set => trainName = value; }
        public string TrainTheme { get => trainTheme; set => trainTheme = value; }
        public DateTime TrainTime { get => trainTime; set => trainTime = value; }
        public string TrainAddress { get => trainAddress; set => trainAddress = value; }
        public int TrainNum { get => trainNum; set => trainNum = value; }
        public int StaffID { get => staffID; set => staffID = value; }
    }
}
