using System;
using System.Collections.Generic;
using System.Data;
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
            string name = HttpContext.Current.Session["name"].ToString();
            Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); name.innerHTML='欢迎你，" + name + "'} </script> ");
            sqlTable st = new sqlTable();
            string year = DateTime.Now.Year.ToString();//当前年份

            //月汇总
            string TableName1 = "Login";//表名1
            string TableName2 = "Summary";//表名2
            string[] MonthSourceList = { "Login.name", "Summary.work_day" };//查看列名
            string[] MonthSelectList = { "Summary.year", "Summary.month", "Login.username" };//限定列名
            string[] MonthSelectValue = { year, HttpContext.Current.Session["months"].ToString(), "Summary.username" };//限定列值
            DataTable MonthCmd = st.selectAll2(TableName1, TableName2, MonthSourceList, MonthSelectList, MonthSelectValue);

            //年汇总
            string TableName3 = "Summary_Month";//表名
            string[] YearSourceList = { "month", "summary" };//查看列名
            string[] YearSelectList = { "year" };//限定列名
            string[] YearSelectValue = { HttpContext.Current.Session["years"].ToString() };//限定列值
            DataTable YearCmd = st.selectAll3(TableName3, YearSourceList, YearSelectList, YearSelectValue);


            //按年查看员工汇总
            string TableName4 = "Summary_Year_User";//表名
            string[] UserSourceList = { "name", "summary_user" };//查看列名
            string[] UserSelectList = { "year" };//限定列名
            string[] UserSelectValue = { HttpContext.Current.Session["yearuser"].ToString() };//限定列值
            DataTable UserCmd = st.selectAll4(TableName4, UserSourceList, UserSelectList, UserSelectValue);
            try
            {


                if (MonthCmd != null || YearCmd != null || UserCmd != null)
                {
                    Month_Repeater.DataSource = MonthCmd;
                    Month_Repeater.DataBind();

                    Year_Repeater.DataSource = YearCmd;
                    Year_Repeater.DataBind();

                    Person_Repeater.DataSource = UserCmd;
                    Person_Repeater.DataBind();
                }
            }
            catch (Exception)
            {
                HttpContext.Current.Response.Write(" <script> alert( '语法错误！！！');window.location.href= 'Default.aspx ' </script> ");
            }
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！');window.location.href= 'Default.aspx ' </script> ");
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

    //按年查看员工汇总
    protected void person_submit_Click(object sender, EventArgs e)
    {
        sqlTable ste = new sqlTable();
        string yeary = Request.Form["person_year"].ToString();
        HttpContext.Current.Session["yearuser"] = yeary;
        string tableName = "Summary_Year";
        string[] mysql = new string[1];
        string[] list = { "year" };
        string[] source = { yeary };
        string[] columns = { "Ysummary" };
        ste.select_delete(tableName, mysql, list, source, columns);
        HttpContext.Current.Session["userYear"] = mysql[0];
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
        HttpContext.Current.Response.Write(" <script>window.location.href= 'Default.aspx' </script> ");
    }
}