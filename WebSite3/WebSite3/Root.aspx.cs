using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Root : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        string[] value = new string[5];
        string[] list = { "power", "username", "password", "name", "team" };
        st.select_login("root", value, "Login", list);

        try
        {
            if (HttpContext.Current.Session["username"].ToString() != "root" || HttpContext.Current.Session["userpwd"].ToString() != value[2])
            {
                Response.Write(" <script> alert( '您无权访问此页面');window.location.href= 'Default.aspx ' </script> ");
            }
        }
        catch (Exception)
        {
            Response.Write(" <script> alert( '您无权访问此页面');window.location.href= 'Default.aspx ' </script> ");
        }

        string name = HttpContext.Current.Session["name"].ToString();
        Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); name.innerHTML='欢迎你，" + name + "'} </script> ");

        Look stl = new Look();

        string loginTableName = "Login";//表名
        string[] loginSourceList = { "username", "password", "name" };//查看列名

        //连接数据查看并显示在网页
        SqlCommand loginCmd = stl.lookSelectUser(loginTableName, loginSourceList);
        if (loginCmd != null)
        {
            Username_Repeater.DataSource = loginCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Username_Repeater.DataBind();
        }
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        String NewUserName = add_username.Text.ToString().Trim();//用户名
        String NewUserPass = add_userpass.Text.ToString().Trim();//密码
        String RealName = add_realname.Text.ToString().Trim();//真实姓名
        String Job = Request.Form["job"].ToString().Trim();//power
        String Master = Request.Form["master"].ToString().Trim();//副主任
        int power = 0;
        switch (Job)
        {
            case "职员":
                power = 18;
                break;
            case "2":
                switch (Master)
                {
                    case "项目管理副主任":
                        power = 2;
                        break;
                    case "设计管理副主任":
                        power = 3;
                        break;
                    case "编程管理副主任":
                        power = 4;
                        break;
                    case "软件管理副主任":
                        power = 5;
                        break;
                    case "仪表管理副主任":
                        power = 6;
                        break;
                }
                break;
            default:
                power = 1;
                break;
        }
        String Group = Request.Form["group"].ToString().Trim();//小组
        if (Group == "自动化")
        {
            Group = "1";
        }
        else if (Group == "软件")

        {
            Group = "2";
        }
        else if (Group == "营销")
        {
            Group = "3";
        }
        else if (Group== "管理层")
        {
            Group = "0";
        }
        //列名以及数据源
        string[] list = { "power", "username", "password", "name", "team" };
        string[] source = { power.ToString(), NewUserName, NewUserPass, RealName, Group };

        //插入
        if (NewUserName == "" || NewUserPass == "" || RealName == "")
        {
            Response.Write("<script>alert('请输入完整信息')</script>");
        }
        else
        {
            sqlTable st = new sqlTable();
            int res = st.table_insert("Login", list, source);
            if (res == 1)
            {
                Response.Write("<script>alert('成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('输入有误，请重新输入')</script>");
            }
        }

    }

    //删除
    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        string delUserName = del_username.Text.Trim();//用户名
        string delName = del_realname.Text.Trim();//姓名

        if (delUserName == "root")
        {
            Response.Write("<script>alert('ROOT用户不允许删除')</script>");
            return;
        }

        if (delUserName == "" && delName == "")
        {
            Response.Write("<script>alert('用户名，姓名不得为空')</script>");
        }
        else if (delUserName == "")
        {
            Response.Write("<script>alert('用户名不得为空')</script>");
        }
        else if (delName == "")
        {
            Response.Write("<script>alert('姓名不得为空')</script>");
        }

        string[] list = { "username", "name" };
        string[] source = { delUserName, delName };

        sqlTable st = new sqlTable();
        int res = st.table_delete("Login", list, source);

        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 2)
        {
            Response.Write("<script>alert('失败')</script>");
        }
        else if (res == 0)
        {
            Response.Write("<script>alert('失败')</script>");
        }

        Page_Load(sender, e);
    }

    //注销
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