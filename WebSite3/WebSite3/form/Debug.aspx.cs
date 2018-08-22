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
        sqlTable st = new sqlTable();
        int number = 0;//填写序号
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();
        string team = HttpContext.Current.Session["team"].ToString();

        //网页输入
        string New_add_engineName = add_engineName.Text.Trim();//项目名称
        string New_add_enginePlace = add_enginePlace.Text.Trim();//项目地点
        string New_add_manageDays = add_manageDays.Text.Trim();//本月工程管理天数
        string New_add_debugDays = add_debugDays.Text.Trim();//本月调试天数
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
        string[] list = { "year", "month", "username", "team", "number", "projectname", "site", "manageday", "debugday", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_engineName, New_add_enginePlace, New_add_manageDays, New_add_debugDays, New_add_remarks };

        //插入
        int res = st.table_insert("Debug", list, source);
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
        String New_add_engineName = add_engineName.Text.Trim();//项目名称
        String New_add_enginePlace = add_enginePlace.Text.Trim();//项目地点
        String New_add_manageDays = add_manageDays.Text.Trim();//本月工程管理天数
        String New_add_debugDays = add_debugDays.Text.Trim();//本月调试天数
        String New_add_remarks = add_remarks.Text.Trim();//备注

        //更新列名以及数据源
        string[] list = { "projectname", "site", "manageday", "debugday", "remark" };
        string[] source = { New_add_engineName, New_add_enginePlace, New_add_manageDays, New_add_debugDays, New_add_remarks };
        
        //查找列名以及数据源
        string[] selectList = { "year", "month", "username", "number" };
        string[] selectSource = { year, month, username, New_add_index };

        int res = st.table_update("Debug", list, source, selectList, selectSource);
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