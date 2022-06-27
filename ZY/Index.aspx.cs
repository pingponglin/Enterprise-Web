using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;

namespace ZY
{
    public partial class Index1 : System.Web.UI.Page
    {
        public string list = "";
        public string bu = "";
        public string name11 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //部门名称和部门人数
                List<Model.Class> classes = new List<Model.Class>();
                classes = BLL.ClassBLL.SelectClass();
                string n=""; string n1 = "";
                //职位薪资姓名和部门
                var zhiwei = BLL.PostBLL.SelectPost();
                if (zhiwei.Count!=0)
                {
                    for (int i = 0; i < zhiwei.Count; i++)
                    {
                        if (i != zhiwei.Count - 1)
                        {
                            bu += "'" + zhiwei[i].PostName + "',";
                        }
                        else
                        {
                            bu += "'" + zhiwei[i].PostName + "'";
                        }

                    }
                    for (int i = 0; i < zhiwei.Count; i++)
                    {
                        if (i != classes.Count - 1)
                        {
                            list += "'" + zhiwei[i].PostSalary + "',";
                        }
                        else
                        {
                            list += "'" + zhiwei[i].PostSalary + "'";
                        }

                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "y", "<script>y();</script>");
                    bu = "";
                    list = "";
                }
                if (classes.Count != 0)
                {
                    for (int i = 0; i < classes.Count; i++)
                    {
                        if (i != classes.Count-1+1)
                        {
                             n = classes[i].ClassRecruitsed.ToString();
                            n1 = classes[i].ClassName.ToString();
                            name11 += "{ value:" + $"{n}" + ", name: '"+$"{n1}"+"' },";
                        }
                        else
                        {
                            name11 += "{ value:" + $"{n}" + ",  name: '" + $"{n1}" + "' }";
                        }
                    }
                }
                else
                {
                    name11 = "";
                }
            }
        }
    }
}
                