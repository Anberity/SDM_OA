using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = "";
        
        try
        {
            if (HttpContext.Current.Session["username"].ToString() == "null" || HttpContext.Current.Session["userpwd"].ToString() == "null")
            {
                HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
            }
             username = HttpContext.Current.Session["username"].ToString();
            string name = HttpContext.Current.Session["name"].ToString();
            Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); name.innerHTML='欢迎你，" + name + "'} </script> ");
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
        }
        
        Look st = new Look();

        #region 设计工作量
        string designTableName = "Design";//表名
        string[] designSourceList = { "number", "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader", "remark" };//查看列名
        string[] designSelectList = { "year", "month", "username" };//限定列名
        string[] designSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand designCmd = st.lookSelect(designTableName, designSourceList, designSelectList, designSelectValue);
        if (designCmd != null)
        {
            Design_Repeater.DataSource = designCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Design_Repeater.DataBind();
        }
        #endregion

        #region 编程/画面工作量
        string programTableName = "Programing_Picture";//表名
        string[] programSourceList = { "number", "project_name", "digital_number", "analog_number", "programing_picture", "programing_day", "month_day", "remark" };//查看列名
        string[] programSelectList = { "year", "month", "username" };//限定列名
        string[] programSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand programCmd = st.lookSelect(programTableName, programSourceList, programSelectList, programSelectValue);
        if (programCmd != null)
        {
            Programming_Picture_Repeater.DataSource = programCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Programming_Picture_Repeater.DataBind();
        }
        #endregion

        #region 调试/工程管理工作量
        string debugTableName = "Debug";//表名
        string[] debugSourceList = { "number", "projectname", "site", "manageday", "debugday", "remark" };//查看列名
        string[] debugSelectList = { "year", "month", "username" };//限定列名
        string[] debugSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand debugCmd = st.lookSelect(debugTableName, debugSourceList, debugSelectList, debugSelectValue);
        if (debugCmd != null)
        {
            Debug_Repeater.DataSource = debugCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Debug_Repeater.DataBind();
        }
        #endregion

        #region 经营工作量
        string manageWorkingTableName = " Manage_Working";//表名
        string[] manageWorkingSourceList = { "number", "project_name", "xunjia_baojia", "tender", "sign", "toubiao", "equip", "test", "cuikuan", "contract", "other", "PM_day", "remark" };//查看列名
        string[] manageWorkingSelectList = { "year", "month", "username" };//限定列名
        string[] manageWorkingSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand manageWorkingCmd = st.lookSelect(manageWorkingTableName, manageWorkingSourceList, manageWorkingSelectList, manageWorkingSelectValue);
        if (manageWorkingCmd != null)
        {
            Manage_Working_Repeater.DataSource = manageWorkingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Manage_Working_Repeater.DataBind();
        }
        #endregion

        #region 日常管理工作量
        string DailyManageTableName = " Daily_Manage";//表名
        string[] DailyManageSourceList = { "number", "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "other", "month_day", "remark" };//查看列名
        string[] DailyManageSelectList = { "year", "month", "username" };//限定列名
        string[] DailyManageSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand DailyManageCmd = st.lookSelect(DailyManageTableName, DailyManageSourceList, DailyManageSelectList, DailyManageSelectValue);
        if (DailyManageCmd != null)
        {
            Daily_Manage_Repeater.DataSource = DailyManageCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Daily_Manage_Repeater.DataBind();
        }
        #endregion

        #region 零星工日
        string lingXingTableName = " LingXing";//表名
        string[] lingXingSourceList = { "number", "chuchai_day", "jiaoliu_day", "other_day", "remark" };//查看列名
        string[] lingXingSelectList = { "year", "month", "username" };//限定列名
        string[] lingXingSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand lingXingCmd = st.lookSelect(lingXingTableName, lingXingSourceList, lingXingSelectList, lingXingSelectValue);
        if (lingXingCmd != null)
        {
            LingXing_Repeater.DataSource = lingXingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            LingXing_Repeater.DataBind();
        }
        #endregion

        #region 本月工日之和
        string summaryTableName = "Summary";//表名
        string[] summarySourceList = { "work_day" };//查看列名
        string[] summarySelectList = { "year", "month", "username" };//限定列名
        string[] summarySelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand summaryCmd = st.lookSelect(summaryTableName, summarySourceList, summarySelectList, summarySelectValue);
        if (summaryCmd != null)
        {
            Summary_Repeater.DataSource = summaryCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Summary_Repeater.DataBind();
        }
        #endregion

    }

    protected void close_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close()</script>");
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
        HttpContext.Current.Session["numberMonth"] = "100";//月份汇总
        HttpContext.Current.Session["numberYear"] = "100";//年份汇总
        HttpContext.Current.Session["userYear"] = "100";//员工年份汇总
        HttpContext.Current.Response.Write(" <script>window.location.href= 'Default.aspx' </script> ");
    }
}