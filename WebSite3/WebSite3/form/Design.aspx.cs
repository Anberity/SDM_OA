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
        sqlTable st = new sqlTable();
        int number = 0;//填写序号
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();
        string team = HttpContext.Current.Session["team"].ToString();

        //网页输入
        string num = Request.Form["num"];
        string New_add_engine = add_engine.Text.Trim();//工程号
        string New_add_engineName = add_engineName.Text.Trim();//工程名称
        string New_add_paperPage = add_paperPage.Text.Trim();//图纸张数
        string New_add_al = add_al.Text.Trim();//折合Al
        string New_add_allDays = add_allDays.Text.Trim();//折合总工日数
        string New_add_finishedDays = add_finishedDays.Text.Trim();//本月完成工日数
        string New_add_usedDays = add_usedDays.Text.Trim();//技术方案工作量所用工日数
        string New_add_usedDays2 = add_usedDays2.Text.Trim();//基本设计工作量所用工日数
        string New_add_leaderDays = add_leaderDays.Text.Trim();//工日
        string New_add_remarks = add_remarks.Text.Trim();//备注

        //number在原有基础上加1
        string list1 = "number";
        string[] value = new string[1];
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture", "Summary" };

        st.select_number(list1, value, tableName, year, month, username);
        if (value[0] != "NULL")
        {
            number = int.Parse(value[0]) + 1;
        }

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "number", "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_engine, New_add_engineName, New_add_paperPage, New_add_al, New_add_allDays, New_add_finishedDays, New_add_usedDays, New_add_usedDays2, New_add_leaderDays, New_add_remarks };

        //插入
        int res = st.table_insert("Design", list, source);
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
        string New_add_index = add_index.Text.Trim(); // 索引
        String New_add_engine = add_engine.Text.Trim();//工程号
        String New_add_engineName = add_engineName.Text.Trim();//工程名称
        String New_add_paperPage = add_paperPage.Text.Trim();//图纸张数
        String New_add_al = add_al.Text.Trim();//折合Al
        String New_add_allDays = add_allDays.Text.Trim();//折合总工日数
        String New_add_finishedDays = add_finishedDays.Text.Trim();//本月完成工日数
        String New_add_usedDays = add_usedDays.Text.Trim();//技术方案工作量所用工日数
        String New_add_usedDays2 = add_usedDays2.Text.Trim();//基本设计工作量所用工日数
        String New_add_leaderDays = add_leaderDays.Text.Trim();//工日
        String New_add_remarks = add_remarks.Text.Trim();//备注

        //更新列名以及数据源
        string[] list = { "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader", "remark" };
        string[] source = { New_add_engine, New_add_engineName, New_add_paperPage, New_add_al, New_add_allDays, New_add_finishedDays, New_add_usedDays, New_add_usedDays2, New_add_leaderDays, New_add_remarks };

        //查找列名以及数据源
        string[] selectList = { "year", "month", "username", "number" };
        string[] selectSource = { year, month, username, New_add_index };

        //插入
        int res = st.table_update("Design", list, source, selectList, selectSource);
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