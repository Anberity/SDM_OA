using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

public partial class personhistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (HttpContext.Current.Session["username"].ToString() == "null" || HttpContext.Current.Session["userpwd"].ToString() == "null")
            {
                HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
            }
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
        }

        string username = HttpContext.Current.Session["username"].ToString();
        Look st = new Look();

        #region 设计工作量
        string designTableName = "Design";//表名
        string[] designSourceList = { "number", "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader", "remark" };//查看列名
        string[] designSelectList = { "year", "month", "username" };//限定列名
        string[] designSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

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
        string[] programSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

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
        string[] debugSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

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
        string[] manageWorkingSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

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
        string[] DailyManageSourceList = { "number", "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "tel", "meal", "other", "month_day", "remark" };//查看列名
        string[] DailyManageSelectList = { "year", "month", "username" };//限定列名
        string[] DailyManageSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

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
        string[] lingXingSelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

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
        string[] summarySelectValue = { HttpContext.Current.Session["yearh"].ToString(), HttpContext.Current.Session["monh"].ToString(), username };//限定列值

        //连接数据查看并显示在网页
        SqlCommand summaryCmd = st.lookSelect(summaryTableName, summarySourceList, summarySelectList, summarySelectValue);
        if (summaryCmd != null)
        {
            Summary_Repeater.DataSource = summaryCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Summary_Repeater.DataBind();
        }
        #endregion
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
        //string newstr = string.Join("-", sArray); // "2018-8" 也可以不再拼接，看如何使用 代码无法检测还需试验
    }

    protected void close_Click(object sender, EventArgs e)
    {

    }
}