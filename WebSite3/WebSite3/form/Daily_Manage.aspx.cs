using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class form5 : System.Web.UI.Page
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
        string New_add_index = add_index.Text.Trim(); //添加索引
        String New_add_management = add_management.Text;//部门内部日常管理
        String New_add_affair = add_affair.Text;//工会事务
        String New_add_affair2 = add_affair2.Text;//党组事务
        String New_add_affair3 = add_affair3.Text;//团组事务
        String New_add_examine = add_examine.Text;//体系内审/外审
        String New_add_check = add_check.Text;//考勤
        String New_add_tel = add_tel.Text;//电话费报销
        String New_add_meal = add_meal.Text;//餐费报销
        String New_add_others = add_others.Text;//其他报销
        String New_add_statistics = add_statistics.Text;//每月工作量统计汇总
        String New_add_remarks = add_remarks.Text;//备注

        //number在原有基础上加1
        string list1 = "number";
        string[] value = new string[1];
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture", "Summary" };

        st.select_number(list1, value, tableName, year, month, username);
        if (value[0] != "NULL")
        {
            number = int.Parse(value[0])+1;
        }

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "number", "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "tel", "meal", "other", "month_day", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_management, New_add_affair, New_add_affair2, New_add_affair3, New_add_examine, New_add_check, New_add_tel, New_add_meal, New_add_others, New_add_statistics, New_add_remarks };

        //插入
        int res = st.table_insert("Daily_Manage", list, source);
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
    // 修改事件
    protected void modifybtn_Click(object sender, EventArgs e)
    {

    }
}