using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form3 : System.Web.UI.Page
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
        String New_add_engineName = add_engineName.Text;//项目名称
        String New_add_enginePlace = add_enginePlace.Text;//项目地点
        String New_add_manageDays = add_manageDays.Text;//本月工程管理天数
        String New_add_debugDays = add_debugDays.Text;//本月调试天数
        String New_add_remarks = add_remarks.Text;//备注

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "projectname", "site", "manageday", "debugday", "remark" };
        string[] source = { year, month, username, team, New_add_engineName, New_add_enginePlace, New_add_manageDays, New_add_debugDays, New_add_remarks };

        //插入
        sqlTable st = new sqlTable();
        int res = st.table_insert("Debug", list, source);
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