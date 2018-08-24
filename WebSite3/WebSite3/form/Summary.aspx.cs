using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();
        string team = HttpContext.Current.Session["team"].ToString();

        //网页输入
        //string New_add_workDays = add_workDays.Text.Trim();//本月工作日之和

        //列名以及数据源
        string[] list = { "year", "month", "username", "team" };
        string[] source = { year, month, username, team };
        string[] rest = { "" };
        string[] selectLitst = { "work_day" };
        //查找
        st.select_delete("Summary", rest, list, source, selectLitst);
        add_workDays.Text = rest[0];
    }
}