using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class workbra : System.Web.UI.Page
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
            string[] selist = { "year", "month", "username" };
            string[] solist = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), HttpContext.Current.Session["username"].ToString() };
            string[] res = new string[1];
            string[] sellist = { "transfer" };
            sqlTable st = new sqlTable();
            st.select_easy(selist, solist, res, "Jiediao", sellist);
            string tran = res[0];
            Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); var tran=document.getElementById('tran'); name.innerHTML='欢迎你，" + name + "';tran.innerHTML='您已被" + tran + ",借调结束请点击下面按钮'} </script> ");
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
        }
    }

    //注销
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
        HttpContext.Current.Response.Write(" <script>window.location.href= 'Default.aspx' </script> ");
    }

    //借调结束
    protected void OnJob_Click(object sender, EventArgs e)
    {
        string username = HttpContext.Current.Session["username"].ToString();

        //查找借调状态
        string[] onJob = new string[1];
        string[] seList = { "transfer" };
        sqlTable st = new sqlTable();
        st.select_login(username, onJob, "Login", seList);

        if (onJob[0] == "0")
        {
            Response.Write("<script>alert('您未被调至其他部门')</script>");
        }
        else if (onJob[0] == "1")
        {
            string[] soList = { "0" };
            string[] usese = { "username", "password" };
            string[] useso = { HttpContext.Current.Session["username"].ToString(), HttpContext.Current.Session["userpwd"].ToString() };
            int res2 = st.table_update("Login", seList, soList, usese, useso);
        }

        Response.Write("<script>alert('借调结束')</script>");

    }
}