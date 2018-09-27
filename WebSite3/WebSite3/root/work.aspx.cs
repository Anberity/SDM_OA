using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_work : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (HttpContext.Current.Session["username"].ToString() != "zdhqxc" || HttpContext.Current.Session["userpwd"].ToString() == "null")
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
        sqlTable st = new sqlTable();
        string tableName = "Login";
        string[] list = { "username", "password", "name", "on_job" };
        DataTable loginCmd = st.selectUser(tableName, list);
        if (loginCmd != null)
        {
            Username_Repeater.DataSource = loginCmd;
            Username_Repeater.DataBind();
        }
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Session["power"] = "null";//权限
        HttpContext.Current.Session["username"] = "null";//获取用户名
        HttpContext.Current.Session["userpwd"] = "null";//获取密码
        HttpContext.Current.Session["name"] = "null";//获取用户名字
        HttpContext.Current.Session["team"] = "null";//获取用户小组
        HttpContext.Current.Session["transfer"] = "null";//获取用户借调状态
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

    //员工离职状态
    protected void JobStatus_Click(object sender, EventArgs e)
    {
        string username = off_username.Text.Trim();//用户名
        string jobStatus = Request.Form["jobstatus"].ToString().Trim();//工作状态

        //查找是否有此用户
        string[] pwd = new string[1];
        string[] list01 = { "password" };
        sqlTable st = new sqlTable();
        st.select_onjob(username, pwd, "Login", list01);



        if (pwd[0] == "NULL" || pwd[0] == "null")
        {
            Response.Write("<script>alert('员工姓名输入有误，请重新输入')</script>");
        }
        else
        {
            //更新状态
            string[] list = { "on_job" };
            string[] source = { jobStatus };
            string[] selectList = { "name" };
            string[] selectSource = { username };
            int res = st.table_update("Login", list, source, selectList, selectSource);

            if (res == 1)
            {
                Response.Write("<script>alert('修改成功')</script>");
                Page_Load(sender, e);
            }
            else
            {
                Response.Write("<script>alert('语法错误')</script>");
            }
        }
    }
}