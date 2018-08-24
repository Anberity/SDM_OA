﻿using System;
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
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture" };

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

        if (New_add_finishedDays != null)
        {
            sum += float.Parse(New_add_finishedDays);
        }
        if (New_add_usedDays != null)
        {
            sum += float.Parse(New_add_usedDays);
        }
        if (New_add_usedDays2 != null)
        {
            sum += float.Parse(New_add_usedDays2);
        }
        if (New_add_leaderDays != null)
        {
            sum += float.Parse(New_add_leaderDays);
        }

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

    //修改事件
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

        //新值
        float monthSum = 0;
        if (New_add_finishedDays != null)
        {
            monthSum += float.Parse(New_add_finishedDays);
        }
        if (New_add_usedDays != null)
        {
            monthSum += float.Parse(New_add_usedDays);
        }
        if (New_add_usedDays2 != null)
        {
            monthSum += float.Parse(New_add_usedDays2);
        }
        if (New_add_leaderDays != null)
        {
            monthSum += float.Parse(New_add_leaderDays);
        }

        //查找原来日常工作量当月汇总
        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        string[] select_List1 = { "month_day" };
        string[] data1 = new string[1];
        st.select_delete("Design", data1, list5, source5, select_List1);
        float rest = 0;//原来的值
        if (data1[0] == null)
        {
            rest = 0;
        }
        else
        {
            rest = float.Parse(data1[0]);
        }

        string[] select_List2 = { "program_day" };
        string[] data2 = new string[1];
        st.select_delete("Design", data2, list5, source5, select_List2);
        if (data2[0] == null)
        {
        }
        else
        {
            rest += float.Parse(data2[0]);
        }

        string[] select_List3 = { "basic_design_day" };
        string[] data3 = new string[1];
        st.select_delete("Design", data3, list5, source5, select_List3);
        if (data3[0] == null)
        {
        }
        else
        {
            rest += float.Parse(data3[0]);
        }

        string[] select_List4 = { "leader" };
        string[] data4 = new string[1];
        st.select_delete("Design", data4, list5, source5, select_List4);
        if (data4[0] == null)
        {
        }
        else
        {
            rest += float.Parse(data4[0]);
        }

        //更新列名以及数据源
        string[] list = { "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader", "remark" };
        string[] source = { New_add_engine, New_add_engineName, New_add_paperPage, New_add_al, New_add_allDays, New_add_finishedDays, New_add_usedDays, New_add_usedDays2, New_add_leaderDays, New_add_remarks };

        //查找列名以及数据源
        string[] selectList = { "year", "month", "username", "number" };
        string[] selectSource = { year, month, username, New_add_index };

        //插入
        int res = st.table_update("Design", list, source, selectList, selectSource);

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
        }
        else
        {
            sum = float.Parse(data[0]);
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
        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        string[] select_List1 = { "month_day" };
        string[] data1 = new string[1];
        st.select_delete("Design", data1, list5, source5, select_List1);
        float rest = 0;//原来的值
        if (data1[0] == null)
        {
            rest = 0;
        }
        else
        {
            rest = float.Parse(data1[0]);
        }

        string[] select_List2 = { "program_day" };
        string[] data2 = new string[1];
        st.select_delete("Design", data2, list5, source5, select_List2);
        if (data2[0] == null)
        {
        }
        else
        {
            rest += float.Parse(data2[0]);
        }

        string[] select_List3 = { "basic_design_day" };
        string[] data3 = new string[1];
        st.select_delete("Design", data3, list5, source5, select_List3);
        if (data3[0] == null)
        {
        }
        else
        {
            rest += float.Parse(data3[0]);
        }

        string[] select_List4 = { "leader" };
        string[] data4 = new string[1];
        st.select_delete("Design", data4, list5, source5, select_List4);
        if (data4[0] == null)
        {
        }
        else
        {
            rest += float.Parse(data4[0]);
        }


        //查找原总工时
        string[] list2 = { "year", "month", "username" };
        string[] source2 = { year, month, username };
        string[] select_List = { "work_day" };
        string[] data = new string[1];
        st.select_delete("Summary", data, list2, source2, select_List);
        float sum = 0;
        if (data[0] == null)
        {
            sum = 0;
        }
        else
        {
            sum = float.Parse(data[0]);
        }

        sum -= rest;

        //更新总工时
        string[] list3 = { "work_day" };
        string[] source3 = { sum.ToString() };
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
        int res = st.table_update("Summary", list3, source3, list4, source4);

        string[] list6 = { "year", "month", "username", "number" };
        string[] source6 = { year, month, username, New_add_index };
        int res1 = st.table_delete("Design", list6, source6);

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