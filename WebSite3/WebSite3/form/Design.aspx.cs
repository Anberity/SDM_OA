using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form1 : System.Web.UI.Page
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
        String num = Request.Form["num"];
        String New_add_engine = add_engine.Text;//工程号
        String New_add_engineName = add_engineName.Text;//工程名称
        String New_add_paperPage = add_paperPage.Text;//图纸张数
        String New_add_al = add_al.Text;//折合Al
        String New_add_allDays = add_allDays.Text;//折合总工日数
        String New_add_finishedDays = add_finishedDays.Text;//本月完成工日数
        String New_add_usedDays = add_usedDays.Text;//技术方案工作量所用工日数
        String New_add_usedDays2 = add_usedDays2.Text;//基本设计工作量所用工日数
        String New_add_leaderDays = add_leaderDays.Text;//工日
        String New_add_remarks = add_remarks.Text;//备注

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader", "remark" };
        string[] source = { year, month, username, team, New_add_engine, New_add_engineName, New_add_paperPage, New_add_al, New_add_allDays, New_add_finishedDays, New_add_usedDays, New_add_usedDays2, New_add_leaderDays, New_add_remarks };

        //插入
        sqlTable st = new sqlTable();
        int res = st.table_insert_login("Design", list, source);
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