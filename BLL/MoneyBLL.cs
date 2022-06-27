using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MoneyBLL
    {
        //增
        public static bool Inert(Money money)
        {
            return MoneyDAL.InsertM(money);
        }
        //删
        public static bool Delete(Money money)
        {
            return MoneyDAL.DeleteM(money);
        }
        //根据特定语句查账号信息
        public static List<Money> GetAllMoney(string sql)
        {
            return MoneyDAL.SelectS(sql);
        }
        //根据ID查账号信息
        public static Money GetMoneyByID(int moneyID)
        {
            Model.Money money = new Model.Money();
            string sql = $"select * from Money where MoneyID='{moneyID}'";
            if (GetAllMoney(sql).Count() > 0)
            {
                money = GetAllMoney(sql)[0];
            }
            return money;
        }

        
        public static List<Money> GettwoMoney(string sql)
        {
            return MoneyDAL.SelectS(sql);
        }

        public static List<Money> GettMoney(string sql)
        {
            return MoneyDAL.Select(sql);
        }
        //改
        public static bool UpdateM(Money money)
        {
            return MoneyDAL.UpdateM(money);
        }

        public static Money GetMoneyUpdate(DateTime moneytime)
        {
            Model.Money money = new Model.Money();
            string sql = $"select*from Entry e,Money m where e.EntryID=m.EntryID and m.MoneyTime='{moneytime}'";
            if (GetAllMoney(sql).Count() > 0)
            {
                money = GetAllMoney(sql)[0];
            }
            return money;
        }

    }
}
