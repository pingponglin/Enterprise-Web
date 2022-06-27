using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MoneyDAL
    {
        //增
        public static bool InsertM(Money money)
        {
            //string sql = $"insert into Money values ('{money.MoneyID}','{money.MoneyTime}','{money.MoneyMain}','{money.MoneyWork}','{money.MoneyCheck}','{money.MoneyAbsent}','{money.MoneySafe}','{money.MoneySum}','{money.StaffName}')";
            string sql = $"insert into Money values ('{money.MoneyTime}','{money.MoneyWork}','{money.MoneyCheck}','{money.MoneyAbsent}','{money.MoneySafe}','{money.MoneySum}','{money.EntryID}','{money.PostID}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static bool Inserts(Money money) {
            string sql = $"insert into Money values ('{money.MoneyTime}',' ',' ',' ',' ',' ',' ','{money.EntryID}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        //删
        public static bool DeleteM(Money money)
        {
            string sql = $"delete from Money where MoneyID='{money.MoneyID}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //根据id查询
        public static List<Money> SelectID(Model.Money money1)
        {
            List<Money> list = new List<Money>();//所有的薪资信息
            string sql = $"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and m.MoneyID={money1.MoneyID}";
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Money money = new Money();
                money.MoneyID = int.Parse(dt.Rows[i]["MoneyID"].ToString());
                money.MoneyTime = DateTime.Parse(dt.Rows[i]["MoneyTime"].ToString());
                money.PostSalary = int.Parse(dt.Rows[i]["PostSalary"].ToString());
                money.MoneyWork = int.Parse(dt.Rows[i]["MoneyWork"].ToString());

                money.MoneyCheck = int.Parse(dt.Rows[i]["MoneyCheck"].ToString());
                money.MoneyAbsent = int.Parse(dt.Rows[i]["MoneyAbsent"].ToString());
                money.MoneySafe = int.Parse(dt.Rows[i]["MoneySafe"].ToString());
                money.MoneySum = int.Parse(dt.Rows[i]["MoneySum"].ToString());
                money.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                money.EntryName = dt.Rows[i]["EntryName"].ToString();
                money.EntryState = dt.Rows[i]["EntryState"].ToString();
                money.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(money);
            }
            return list;
        }

        //查
        public static List<Money> SelectM()
        {
            List<Money> list = new List<Money>();//所有的薪资信息
            string sql = $"select*from Entry e,Money m,Post p where e.EntryID=m.EntryID and m.PostID=p.PostID and e.EntryState='已入职' order by m.MoneyTime desc";
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Money money = new Money();
                money.MoneyID = int.Parse(dt.Rows[i]["MoneyID"].ToString());
                money.MoneyTime = DateTime.Parse(dt.Rows[i]["MoneyTime"].ToString());
                money.PostSalary = int.Parse(dt.Rows[i]["PostSalary"].ToString());
                money.MoneyWork = int.Parse(dt.Rows[i]["MoneyWork"].ToString());
                
                money.MoneyCheck = int.Parse(dt.Rows[i]["MoneyCheck"].ToString());
                money.MoneyAbsent = int.Parse(dt.Rows[i]["MoneyAbsent"].ToString());
                money.MoneySafe = int.Parse(dt.Rows[i]["MoneySafe"].ToString());
                money.MoneySum = int.Parse(dt.Rows[i]["MoneySum"].ToString());
                money.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                money.EntryName = dt.Rows[i]["EntryName"].ToString();
                money.EntryState = dt.Rows[i]["EntryState"].ToString();
                money.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(money);
            }
            return list;
        }

        public static List<Money> SelectM(string sql)
        {
            List<Money> list = new List<Money>();//所有的薪资信息
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Money money = new Money();
                money.MoneyID = int.Parse(dt.Rows[i]["MoneyID"].ToString());
                money.MoneyTime = DateTime.Parse(dt.Rows[i]["MoneyTime"].ToString());
                money.PostSalary = int.Parse(dt.Rows[i]["PostSalary"].ToString());
                money.MoneyWork = int.Parse(dt.Rows[i]["MoneyWork"].ToString());
                
                money.MoneyCheck = int.Parse(dt.Rows[i]["MoneyCheck"].ToString());
                money.MoneyAbsent = int.Parse(dt.Rows[i]["MoneyAbsent"].ToString());
                money.MoneySafe = int.Parse(dt.Rows[i]["MoneySafe"].ToString());
                money.MoneySum = int.Parse(dt.Rows[i]["MoneySum"].ToString());
                money.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                money.EntryName = dt.Rows[i]["EntryName"].ToString();
                money.EntryState = dt.Rows[i]["EntryState"].ToString();
                money.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(money);
            }
            return list;
        }
       
        public static List<Money> SelectS(string sql)
        {

            List<Money> list = new List<Money>();//所有的薪资信息
            
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Money money = new Money();
                money.MoneyID = int.Parse(dt.Rows[i]["MoneyID"].ToString());
                money.MoneyTime = DateTime.Parse(dt.Rows[i]["MoneyTime"].ToString());
                money.PostSalary = int.Parse(dt.Rows[i]["PostSalary"].ToString());
                money.MoneyWork = int.Parse(dt.Rows[i]["MoneyWork"].ToString());
                money.MoneyCheck = int.Parse(dt.Rows[i]["MoneyCheck"].ToString());
                money.MoneyAbsent = int.Parse(dt.Rows[i]["MoneyAbsent"].ToString());
                money.MoneySafe = int.Parse(dt.Rows[i]["MoneySafe"].ToString());
                money.MoneySum = int.Parse(dt.Rows[i]["MoneySum"].ToString());
                money.EntryID = int.Parse(dt.Rows[i]["EntryID"].ToString());
                money.EntryName = dt.Rows[i]["EntryName"].ToString();
                money.EntryState = dt.Rows[i]["EntryState"].ToString();
                money.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(money);
            }
            return list;
        }
        
        public static List<Money> Select(string sql)
        {
            List<Money> list = new List<Money>();//所有的薪资信息
            
            DataTable dt = DBHelper.GetDataTable(sql);//对表中所有的行进行遍历
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Money money = new Money();
                money.MoneyID = int.Parse(dt.Rows[i]["MoneyID"].ToString());
                money.MoneyTime = DateTime.Parse(dt.Rows[i]["MoneyTime"].ToString());
                money.PostSalary = int.Parse(dt.Rows[i]["PostSalary"].ToString());
                money.MoneyWork = int.Parse(dt.Rows[i]["MoneyWork"].ToString());
                money.MoneyCheck = int.Parse(dt.Rows[i]["MoneyCheck"].ToString());
                money.MoneyAbsent = int.Parse(dt.Rows[i]["MoneyAbsent"].ToString());
                money.MoneySafe = int.Parse(dt.Rows[i]["MoneySafe"].ToString());
                money.MoneySum = int.Parse(dt.Rows[i]["MoneySum"].ToString());
                money.EntryName = dt.Rows[i]["EntryName"].ToString();
                money.EntryState = dt.Rows[i]["EntryState"].ToString();
                money.PostName = dt.Rows[i]["PostName"].ToString();
                list.Add(money);
            }
            return list;
        }

        //改
        public static bool UpdateM(Money money)
        {
            string sql= $"update Money set MoneyTime='{money.MoneyTime}',MoneyWork='{money.MoneyWork}',MoneyAbsent='{money.MoneyAbsent}',MoneySafe='{money.MoneySafe}',MoneySum='{money.MoneySum}'where EntryID={money.EntryID}";
            
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static bool UpdateM(string sql)
        {
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
