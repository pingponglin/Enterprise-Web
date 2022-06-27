using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Money
    {
        private int moneyID;//编号
        private DateTime moneyTime;//时间
        private decimal moneyMain;
        private int moneyWork;
        private int moneyYear;
        private int moneyCheck;
        private int moneyAbsent;
        private int moneySafe;
        private int moneySum;
        private string postName;
        private string entryState;
        private string entryName;
        private int entryID;
        private int staffID;
        private int postSalary;
        private int postID;



        public int MoneyID { get => moneyID; set => moneyID = value; }
        public DateTime MoneyTime { get => moneyTime; set => moneyTime = value; }
        public decimal MoneyMain { get => moneyMain; set => moneyMain = value; }
        public int MoneyWork { get => moneyWork; set => moneyWork = value; }
        public int MoneyYear { get => moneyYear; set => moneyYear = value; }
        public int MoneyCheck { get => moneyCheck; set => moneyCheck = value; }
        public int MoneyAbsent { get => moneyAbsent; set => moneyAbsent = value; }
        public int MoneySafe { get => moneySafe; set => moneySafe = value; }
        public int MoneySum { get => moneySum; set => moneySum = value; }
        public int EntryID { get => entryID; set => entryID = value; }
        public string PostName { get => postName; set => postName = value; }
        public string EntryState { get => entryState; set => entryState = value; }
        public string EntryName { get => entryName; set => entryName = value; }
        public int PostSalary { get => postSalary; set => postSalary = value; }
        public int PostID { get => postID; set => postID = value; }
        public int StaffID { get => staffID; set => staffID = value; }
    }
}
