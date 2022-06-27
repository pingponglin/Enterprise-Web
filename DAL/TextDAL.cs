using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TextDAL
    {
        //添加
        public static bool TextAdd(string TextName,string TextIDcard,DateTime time, int TextPostID,int TextClassID,int TextNewPostID,int TextNewClassID)
        {
            string sql = $"insert into Text values('{TextName}','{TextIDcard}','{time}','{TextPostID}','{TextClassID}','{TextNewPostID}','{TextNewClassID}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //查询所有的调岗记录
        public static List<Model.Text> SelAllText()
        {
            string sql = $"select * from Text";
            List<Model.Text> list = new List<Model.Text>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Model.Text text = new Model.Text();
                text.TextName = dt.Rows[i]["TextName"].ToString();
                text.TextIDcard = dt.Rows[i]["TextIDcard"].ToString();
                text.TextTime= DateTime.Parse(dt.Rows[i]["TextTime"].ToString());
                text.TextPostID = DAL.StaffDAL.SelPost(int.Parse(dt.Rows[i]["TextPostID"].ToString()));
                text.TextClassID = DAL.StaffDAL.SelClass(int.Parse(dt.Rows[i]["TextClassID"].ToString()));
                text.TextNewPostID = DAL.StaffDAL.SelPost(int.Parse(dt.Rows[i]["TextNewPostID"].ToString()));
                text.TextNewClassID = DAL.StaffDAL.SelClass(int.Parse(dt.Rows[i]["TextNewClassID"].ToString()));
                list.Add(text);
            }
            return list;
        }
        //根据身份证号查询所有的调岗记录
        public static List<Model.Text> SelIDcardText(string IDcard)
        {
            string sql = $"select * from Text where TextIDcard='{IDcard}'";
            List<Model.Text> list = new List<Model.Text>();
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Model.Text text = new Model.Text();
                text.TextName = dt.Rows[i]["TextName"].ToString();
                text.TextIDcard = dt.Rows[i]["TextIDcard"].ToString();
                text.TextTime = DateTime.Parse(dt.Rows[i]["TextTime"].ToString());
                text.TextPostID = DAL.StaffDAL.SelPost(int.Parse(dt.Rows[i]["TextPostID"].ToString()));
                text.TextClassID = DAL.StaffDAL.SelClass(int.Parse(dt.Rows[i]["TextClassID"].ToString()));
                text.TextNewPostID = DAL.StaffDAL.SelPost(int.Parse(dt.Rows[i]["TextNewPostID"].ToString()));
                text.TextNewClassID = DAL.StaffDAL.SelClass(int.Parse(dt.Rows[i]["TextNewClassID"].ToString()));
                list.Add(text);
            }
            return list;
        }
    }
}
