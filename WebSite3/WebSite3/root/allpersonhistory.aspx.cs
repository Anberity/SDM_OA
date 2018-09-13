﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_allpersonhistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (HttpContext.Current.Session["username"].ToString() == "null" || HttpContext.Current.Session["userpwd"].ToString() == "null")
            {
                HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= '../Default.aspx ' </script> ");
            }
            string name = HttpContext.Current.Session["name"].ToString();
            Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); name.innerHTML='欢迎你，" + name + "主任'} </script> ");
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= '../Default.aspx ' </script> ");
        }

        Look st = new Look();

        try
        {
            #region 设计工作量
            string designTableName1 = "Design";//表名1
            string designTableName2 = "Login";//表名2
            string[] designSourceList = { "Design.number", "Login.name", "Design.project_number", "Design.project_name", "Design.drawing_number", "Design.A1_number", "Design.zhehe_working_day", "Design.month_day", "Design.program_day", "Design.basic_design_day", "Design.leader", "Design.remark" };//查看列名
            string[] designSelectList = { "year", "month", "Design.username" };//限定列名
            string[] designSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand designCmd = st.lookSelectAll(designTableName1, designTableName2, designSourceList, designSelectList, designSelectValue);
            if (designCmd != null)
            {
                Design_Repeater.DataSource = designCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Design_Repeater.DataBind();
            }
            #endregion

            #region 编程/画面工作量
            string programTableName1 = "Programing_Picture";//表名1
            string programTableName2 = "Login";//表名2
            string[] programSourceList = { "Programing_Picture.number", "Login.name", "Programing_Picture.project_name", "Programing_Picture.digital_number", "Programing_Picture.analog_number", "Programing_Picture.programing_picture", "Programing_Picture.programing_day", "Programing_Picture.month_day", "Programing_Picture.remark" };//查看列名
            string[] programSelectList = { "year", "month", "Programing_Picture.username" };//限定列名
            string[] programSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand programCmd = st.lookSelectAll(programTableName1, programTableName2, programSourceList, programSelectList, programSelectValue);
            if (programCmd != null)
            {
                Programming_Picture_Repeater.DataSource = programCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Programming_Picture_Repeater.DataBind();
            }
            #endregion

            #region 调试/工程管理工作量
            string debugTableName1 = "Debug";//表名1
            string debugTableName2 = "Login";//表名2
            string[] debugSourceList = { "Debug.number", "Login.name", "Debug.projectname", "Debug.site", "Debug.manageday", "Debug.debugday", "Debug.remark" };//查看列名
            string[] debugSelectList = { "year", "month", "Debug.username" };//限定列名
            string[] debugSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand debugCmd = st.lookSelectAll(debugTableName1, debugTableName2, debugSourceList, debugSelectList, debugSelectValue);
            if (debugCmd != null)
            {
                Debug_Repeater.DataSource = debugCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Debug_Repeater.DataBind();
            }
            #endregion

            #region 经营工作量
            string manageWorkingTableName1 = "Manage_Working";//表名1
            string manageWorkingTableName2 = "Login";//表名2
            string[] manageWorkingSourceList = { "Manage_Working.number", "Login.name", "Manage_Working.project_name", "Manage_Working.xunjia_baojia", "Manage_Working.tender", "Manage_Working.sign", "Manage_Working.toubiao", "Manage_Working.equip", "Manage_Working.test", "Manage_Working.cuikuan", "Manage_Working.contract", "Manage_Working.other", "Manage_Working.PM_day", "Manage_Working.remark" };//查看列名
            string[] manageWorkingSelectList = { "year", "month", "Manage_Working.username" };//限定列名
            string[] manageWorkingSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand manageWorkingCmd = st.lookSelectAll(manageWorkingTableName1, manageWorkingTableName2, manageWorkingSourceList, manageWorkingSelectList, manageWorkingSelectValue);
            if (manageWorkingCmd != null)
            {
                Manage_Working_Repeater.DataSource = manageWorkingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Manage_Working_Repeater.DataBind();
            }
            #endregion

            #region 日常管理工作量
            string DailyManageTableName1 = "Daily_Manage";//表名1
            string DailyManageTableName2 = "Login";//表名2

            string[] DailyManageSourceList = { "Daily_Manage.number", "Login.name", "Daily_Manage.management", "Daily_Manage.affair_gonghui", "Daily_Manage.affair_dangzu", "Daily_Manage.affair_tuanzu", "Daily_Manage.examine", "Daily_Manage.kaoqin", "Daily_Manage.tel", "Daily_Manage.meal", "Daily_Manage.other", "Daily_Manage.month_day", "Daily_Manage.remark" };//查看列名
            string[] DailyManageSelectList = { "year", "month", "Daily_Manage.username" };//限定列名
            string[] DailyManageSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand DailyManageCmd = st.lookSelectAll(DailyManageTableName1, DailyManageTableName2, DailyManageSourceList, DailyManageSelectList, DailyManageSelectValue);
            if (DailyManageCmd != null)
            {
                Daily_Manage_Repeater.DataSource = DailyManageCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Daily_Manage_Repeater.DataBind();
            }
            #endregion

            #region 零星工日
            string lingXingTableName1 = "LingXing";//表名1
            string lingXingTableName2 = "Login";//表名2

            string[] lingXingSourceList = { "LingXing.number", "Login.name", "LingXing.chuchai_day", "LingXing.jiaoliu_day", "LingXing.other_day", "LingXing.remark" };//查看列名
            string[] lingXingSelectList = { "year", "month", "LingXing.username" };//限定列名
            string[] lingXingSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand lingXingCmd = st.lookSelectAll(lingXingTableName1, lingXingTableName2, lingXingSourceList, lingXingSelectList, lingXingSelectValue);
            if (lingXingCmd != null)
            {
                LingXing_Repeater.DataSource = lingXingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                LingXing_Repeater.DataBind();
            }
            #endregion

            #region 本月工日之和
            string summaryTableName1 = "Summary";//表名
            string summaryTableName2 = "Login";//表名2

            string[] summarySourceList = { "Summary.work_day", "Login.name" };//查看列名
            string[] summarySelectList = { "year", "month", "Summary.username" };//限定列名
            string[] summarySelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), "Login.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand summaryCmd = st.lookSelectAll(summaryTableName1, summaryTableName2, summarySourceList, summarySelectList, summarySelectValue);
            if (summaryCmd != null)
            {
                Summary_Repeater.DataSource = summaryCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Summary_Repeater.DataBind();
            }
            #endregion
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
        }
    }

    protected void close_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Session["yearh"] = DateTime.Now.Year.ToString();
        HttpContext.Current.Session["monh"] = DateTime.Now.Month.ToString();
        Response.Write("<script>window.close()</script>");
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string str = date.Text; // "2018-08"
        // 拆分开始日期
        string[] sArray = Regex.Split(str, "-", RegexOptions.IgnoreCase); //["2018","08"]

        Regex regNum = new Regex("^[0]");
        if (regNum.IsMatch(sArray[1]))
        {
            sArray[1] = sArray[1].Substring(1, 1); // "08" -> "8"

        }
        HttpContext.Current.Session["yearh"] = sArray[0];
        HttpContext.Current.Session["monh"] = sArray[1];
        Page_Load(sender, e);
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Session["power"] = "null";//权限
        HttpContext.Current.Session["username"] = "null";//获取用户名
        HttpContext.Current.Session["userpwd"] = "null";//获取密码
        HttpContext.Current.Session["name"] = "null";//获取用户名字
        HttpContext.Current.Session["team"] = "null";//获取用户小组
        HttpContext.Current.Session["yearh"] = DateTime.Now.Year.ToString();//历史年份
        HttpContext.Current.Session["monh"] = DateTime.Now.Month.ToString();//历史月份
        HttpContext.Current.Session["months"] = DateTime.Now.Month.ToString();//汇总查看月份
        HttpContext.Current.Session["years"] = DateTime.Now.Month.ToString();//汇总查看年份
        HttpContext.Current.Session["yearuser"] = DateTime.Now.Month.ToString();//按年查看员工汇总
        HttpContext.Current.Session["numberMonth"] = "0";//月份汇总
        HttpContext.Current.Session["numberYear"] = "0";//年份汇总
        HttpContext.Current.Session["userYear"] = "0";//员工年份汇总
        HttpContext.Current.Response.Write(" <script>window.location.href= '../Default.aspx' </script> ");
    }
}