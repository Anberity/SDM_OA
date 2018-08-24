﻿using System;
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

    //增加事件
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
        string New_add_management = add_management.Text.Trim();//部门内部日常管理
        string New_add_affair = add_affair.Text.Trim();//工会事务
        string New_add_affair2 = add_affair2.Text.Trim();//党组事务
        string New_add_affair3 = add_affair3.Text.Trim();//团组事务
        string New_add_examine = add_examine.Text.Trim();//体系内审/外审
        string New_add_check = add_check.Text.Trim();//考勤
        string New_add_tel = add_tel.Text.Trim();//电话费报销
        string New_add_meal = add_meal.Text.Trim();//餐费报销
        string New_add_others = add_others.Text.Trim();//其他报销
        string New_add_remarks = add_remarks.Text.Trim();//备注

        //当月日常工作总工时汇总
        float monthSum = 0;
        if (New_add_management != null)
        {
            monthSum += float.Parse(New_add_management);
        }
        if (New_add_affair != null)
        {
            monthSum += float.Parse(New_add_affair);
        }
        if (New_add_affair2 != null)
        {
            monthSum += float.Parse(New_add_affair2);
        }
        if (New_add_affair3 != null)
        {
            monthSum += float.Parse(New_add_affair3);
        }
        if (New_add_examine != null)
        {
            monthSum += float.Parse(New_add_examine);
        }
        if (New_add_check != null)
        {
            monthSum += float.Parse(New_add_check);
        }
        if (New_add_tel != null)
        {
            monthSum += float.Parse(New_add_tel);
        }
        if (New_add_meal != null)
        {
            monthSum += float.Parse(New_add_meal);
        }
        if (New_add_others != null)
        {
            monthSum += float.Parse(New_add_others);
        }

        //number在原有基础上加1
        string list1 = "number";
        string[] value = new string[1];
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture" };

        st.select_number(list1, value, tableName, year, month, username);
        if (value[0] != "NULL")
        {
            number = int.Parse(value[0]) + 1;
        }

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "number", "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "tel", "meal", "other", "month_day", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_management, New_add_affair, New_add_affair2, New_add_affair3, New_add_examine, New_add_check, New_add_tel, New_add_meal, New_add_others, monthSum.ToString(), New_add_remarks };

        //插入
        int res = st.table_insert("Daily_Manage", list, source);

        //更新本月总工日
        //查找列名以及数据源
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
        string[] select_List = { "work_day" };
        string[] data = new string[1];
        st.select_delete("Summary", data, list4, source4, select_List);
        float sum = 0;
        if (data[0] == null)
        {
            sum = 0;
        }
        else
        {
            sum = float.Parse(data[0]);
        }
        sum += monthSum;
        string[] list2 = { "work_day" };
        string[] source2 = { sum.ToString() };
        string[] list3 = { "year", "month", "username" };
        string[] source3 = { year, month, username };
        int res1 = st.table_update("Summary", list2, source2, list3, source3);

        if (res == 1 && res1 == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0 || res1 == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else if (res == 2 || res1 == 2)
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }

    // 修改事件
    protected void modifybtn_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_index = add_index.Text.Trim(); //添加索引
        string New_add_management = add_management.Text.Trim();//部门内部日常管理
        string New_add_affair = add_affair.Text.Trim();//工会事务
        string New_add_affair2 = add_affair2.Text.Trim();//党组事务
        string New_add_affair3 = add_affair3.Text.Trim();//团组事务
        string New_add_examine = add_examine.Text.Trim();//体系内审/外审
        string New_add_check = add_check.Text.Trim();//考勤
        string New_add_tel = add_tel.Text.Trim();//电话费报销
        string New_add_meal = add_meal.Text.Trim();//餐费报销
        string New_add_others = add_others.Text.Trim();//其他报销
        string New_add_remarks = add_remarks.Text.Trim();//备注

        //查找原来日常工作量当月汇总
        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        string[] select_List1 = { "month_day" };
        string[] data1 = new string[1];
        st.select_delete("Daily_Manage", data1, list5, source5, select_List1);
        float rest = 0;//原来的值
        if (data1[0] == null)
        {
            rest = 0;
        }
        else
        {
            rest = float.Parse(data1[0]);
        }


        //当月总工时汇总
        float monthSum = 0;//修改汇总
        
        if (New_add_management != null)
        {
            monthSum += float.Parse(New_add_management);
        }
        if (New_add_affair != null)
        {
            monthSum += float.Parse(New_add_affair);
        }
        if (New_add_affair2 != null)
        {
            monthSum += float.Parse(New_add_affair2);
        }
        if (New_add_affair3 != null)
        {
            monthSum += float.Parse(New_add_affair3);
        }
        if (New_add_examine != null)
        {
            monthSum += float.Parse(New_add_examine);
        }
        if (New_add_check != null)
        {
            monthSum += float.Parse(New_add_check);
        }
        if (New_add_tel != null)
        {
            monthSum += float.Parse(New_add_tel);
        }
        if (New_add_meal != null)
        {
            monthSum += float.Parse(New_add_meal);
        }
        if (New_add_others != null)
        {
            monthSum += float.Parse(New_add_others);
        }

        //更新列名以及数据源
        string[] list = { "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "tel", "meal", "other", "month_day", "remark" };
        string[] source = { New_add_management, New_add_affair, New_add_affair2, New_add_affair3, New_add_examine, New_add_check, New_add_tel, New_add_meal, New_add_others, monthSum.ToString(), New_add_remarks };

        //查找列名以及数据源
        string[] selectList = { "year", "month", "username", "number" };
        string[] selectSource = { year, month, username, New_add_index };

        //插入
        int res = st.table_update("Daily_Manage", list, source, selectList, selectSource);

        //更新本月总工日
        //查找原总工时
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
        string[] select_List = { "work_day" };
        string[] data = new string[1];
        st.select_delete("Summary", data, list4, source4, select_List);
        float sum = 0;
        if (data[0] == null)
        {
            sum = 0;
        }
        else
        {
            sum = int.Parse(data[0]);
        }
        sum = sum - rest + monthSum;
        string[] list1 = { "work_day" };
        string[] source1 = { sum.ToString() };
        string[] list2 = { "year", "month", "username" };
        string[] source2 = { year, month, username };
        int res1 = st.table_update("Summary", list1, source1, list2, source2);

        if (res == 1 && res1 == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0 || res1 == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else if (res == 2 || res1 == 2)
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }

    //删除事件
    protected void delete_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_index = add_index.Text.Trim(); //添加索引

        //查找原来日常工作量当月汇总
        string[] list = { "year", "month", "username", "number" };
        string[] source = { year, month, username, New_add_index };
        string[] select_List = { "month_day" };
        string[] data = new string[1];
        st.select_delete("Daily_Manage", data, list, source, select_List);
        float rest = 0;//原来的值
        if (data[0] == null)
        {
            rest = 0;
        }
        else
        {
            rest = float.Parse(data[0]);
        }

        //查找原总工时
        string[] list2 = { "year", "month", "username" };
        string[] source2 = { year, month, username };
        string[] select_List2 = { "work_day" };
        string[] data2 = new string[1];
        st.select_delete("Summary", data2, list2, source2, select_List2);
        float sum = 0;
        if (data2[0] == null)
        {
            sum = 0;
        }
        else
        {
            sum = float.Parse(data2[0]);
        }

        sum -= rest;

        //更新总工时
        string[] list3 = { "work_day" };
        string[] source3 = { sum.ToString() };
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
        int res = st.table_update("Summary", list3, source3, list4, source4);

        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        int res1 = st.table_delete("Daily_Manage", list5, source5);

        if (res == 1 && res1 == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0 || res1 == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else if (res == 2 || res1 == 2)
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }
}