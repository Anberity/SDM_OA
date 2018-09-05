using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class daytotal : System.Web.UI.Page
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

        Look st = new Look();
        string year = DateTime.Now.Year.ToString();//当前年份

        //月汇总
        string TableName1 = "Login";//表名1
        string TableName2 = "Summary";//表名2

        string[] MonthSourceList = { "Login.name", "Summary.work_day" };//查看列名
        string[] MonthSelectList = { "Summary.year", "Summary.month", "Login.username" };//限定列名
        try
        {
            string[] MonthSelectValue = { year, HttpContext.Current.Session["months"].ToString(), "Summary.username" };//限定列值

            //连接数据查看并显示在网页
            SqlCommand MonthCmd = st.lookSelectAll2(TableName1, TableName2, MonthSourceList, MonthSelectList, MonthSelectValue);

            //年汇总
            string TableName3 = "Summary_Month";//表名
            string[] YearSourceList = { "month", "summary" };//查看列名
            string[] YearSelectList = { "year" };//限定列名
            string[] YearSelectValue = { HttpContext.Current.Session["years"].ToString() };//限定列值
            SqlCommand YearCmd = st.lookSelectAll3(TableName3, YearSourceList, YearSelectList, YearSelectValue);
            if (MonthCmd != null || YearCmd != null)
            {
                Month_Repeater.DataSource = MonthCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Month_Repeater.DataBind();

                Year_Repeater.DataSource = YearCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                Year_Repeater.DataBind();
            }
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
        }
    }


    //关闭事件
    protected void close_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close()</script>");
    }

    //月份
    protected void submit_Click(object sender, EventArgs e)
    {
        sqlTable ste = new sqlTable();
        string monthm = Request.Form["month"].ToString();
        HttpContext.Current.Session["months"] = monthm;//月份
        string tableName = "Summary_Month";
        string[] mysql = new string[1];
        string[] list = { "year", "month" };
        string[] source = { DateTime.Now.Year.ToString(), monthm };
        string[] columns = { "summary" };
        ste.select_delete(tableName, mysql, list, source, columns);
        HttpContext.Current.Session["numberMonth"] = mysql[0];
        Page_Load(sender, e);
        
    }

    //年份
    protected void confirm_Click(object sender, EventArgs e)
    {
        sqlTable ste = new sqlTable();
        string yeary = Request.Form["year"].ToString();
        HttpContext.Current.Session["years"] = yeary;//月份
        string tableName = "Summary_Year";
        string[] mysql = new string[1];
        string[] list = { "year" };
        string[] source = { yeary };
        string[] columns = { "Ysummary" };
        ste.select_delete(tableName, mysql, list, source, columns);
        HttpContext.Current.Session["numberYear"] = mysql[0];
        Page_Load(sender, e);
        
    }
}