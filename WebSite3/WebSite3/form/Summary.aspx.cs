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
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = Variable.username;
        string team = Variable.team;

        //网页输入
        String New_add_workDays = add_workDays.Text;//本月工作日之和

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "work_day" };
        string[] source = { year, month, username, team, New_add_workDays};

        //插入
        sqlTable st = new sqlTable();
        int res = st.table_insert_login("Summary", list, source);
        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
    }
}