using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form2 : System.Web.UI.Page
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
        String New_add_engineName = add_engineName.Text;//项目名称
        String New_add_onOffNum = add_onOffNum.Text;//总开关量点数
        String New_add_modeNum = add_modeNum.Text;//总模拟量点数
        String New_add_program = add_program.Text;//编程/画面
        String New_add_allDays = add_allDays.Text;//总工日数
        String New_add_finishedDays = add_finishedDays.Text;//本月完成工日数
        String New_add_remarks = add_remarks.Text;//备注

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
        string[] list = { "year", "month", "username", "team", "number", "project_name", "digital_number", "analog_number", "programing_picture", "programing_day", "month_day", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_engineName, New_add_onOffNum, New_add_modeNum, New_add_program, New_add_allDays, New_add_finishedDays, New_add_remarks };

        //插入
        int res = st.table_insert("Programing_Picture", list, source);
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