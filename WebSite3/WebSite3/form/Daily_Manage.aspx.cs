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
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = Variable.username;
        string team = Variable.team;

        //网页输入
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


        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "tel", "meal", "other", "month_day", "remark" };
        string[] source = { year, month, username, team, New_add_management, New_add_affair, New_add_affair2, New_add_affair3, New_add_examine, New_add_check, New_add_tel, New_add_meal, New_add_others, New_add_statistics, New_add_remarks };

        //插入
        sqlTable st = new sqlTable();
        int res = st.table_insert("Daily_Manage", list, source);
        if (res==1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
    }
}