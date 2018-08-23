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

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();
        string team = HttpContext.Current.Session["team"].ToString();

        //网页输入
        string New_add_workDays = add_workDays.Text.Trim();//本月工作日之和

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "work_day" };
        string[] source = { year, month, username, team, New_add_workDays };

        //插入
        int res = st.table_insert("Summary", list, source);
        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }

    protected void modifybtn_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_workDays = add_workDays.Text.Trim();//本月工作日之和

        //更新列名以及数据源
        string[] list = { "work_day" };
        string[] source = { New_add_workDays };

        //查找列名以及数据源
        string[] selectList = { "year", "month", "username" };
        string[] selectSource = { year, month, username };

        //插入
        int res = st.table_update("Summary", list, source, selectList, selectSource);
        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }
}