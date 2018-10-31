using System;
using System.Collections.Generic;
using System.Data;
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

        string name = null;
        try
        {
            name = HttpContext.Current.Session["name"].ToString();
        }
        catch (Exception)
        {
            Response.Write(" <script> alert( '登录超时，请重新登录');window.location.href= 'Default.aspx ' </script> ");
        }
        Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); name.innerHTML='欢迎你，" + name + "'} </script> ");
    }

    //增加
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        String NewUserName = add_username.Text.ToString().Trim();//用户名
        String NewUserPass = add_userpass.Text.ToString().Trim();//密码
        String RealName = add_realname.Text.ToString().Trim();//真实姓名
        String Job = Request.Form["job"].ToString().Trim();//power
        String Master = Request.Form["master"].ToString().Trim();//副主任
        string peonumber = PeopleNumber.Text.ToString().Trim();//员工编号
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
        else if (Group == "管理层")
        {
            Group = "0";
        }
        //列名以及数据源
        string[] list = { "power", "username", "password", "name", "team", "transfer", "peoplenumber", "on_job" };
        string[] source = { power.ToString(), NewUserName, NewUserPass, RealName, Group, "0", peonumber, "1" };

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

    //离职
    protected void JobStatus_Click(object sender, EventArgs e)
    {
        string username = off_username.Text.Trim();//用户名
        string jobStatus = Request.Form["jobstatus"].ToString().Trim();//工作状态

        //查找是否有此用户
        string[] pwd = new string[1];
        string[] list01 = { "password" };
        sqlTable st = new sqlTable();
        st.select_login(username, pwd, "Login", list01);

        //更新状态
        string[] list = { "on_job" };
        string[] source = { jobStatus };
        string[] selectList = { "username" };
        string[] selectSource = { username };

        if (pwd[0] == "NULL" || pwd[0] == "null")
        {
            Response.Write("<script>alert('输入用户名有误，请重新输入')</script>");
        }
        else
        {
            int res = st.table_update("Login", list, source, selectList, selectSource);

            if (res == 1)
            {
                Response.Write("<script>alert('修改成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('语法错误')</script>");
            }
        }
    }

    //员工信息查询
    protected void Select_Click(object sender, EventArgs e)
    {
        string NewUserName = Username.Text.ToString().Trim();//用户名

        string[] value = new string[8];
        string[] list01 = { "power", "username", "password", "name", "team", "transfer", "peoplenumber", "on_job" };
        sqlTable st = new sqlTable();
        st.select_login(NewUserName, value, "Login", list01);

        if (value[0] == "18")
        {
            Post.Value = "18";
        }
        else if (value[0] == "1")
        {
            Post.Value = "1";
        }
        else if (value[0] == "2" || value[0] == "3" || value[0] == "4" || value[0] == "5" || value[0] == "6")
        {
            switch (value[0])
            {
                case "2":
                    Post.Value = "2";
                    fzr.Value = "2";
                    break;
                case "3":
                    Post.Value = "2";
                    fzr.Value = "3";
                    break;
                case "4":
                    Post.Value = "2";
                    fzr.Value = "4";
                    break;
                case "5":
                    Post.Value = "2";
                    fzr.Value = "5";
                    break;
                default:
                    Post.Value = "2";
                    fzr.Value = "6";
                    break;
            }
        }
        Username.Text = value[1];
        Pwd.Text = value[2];
        PeopleName.Text = value[3];
        group2.Value = value[4];
        if (value[5] == "1")
        {
            JieDiao.Text = "已借调";
        }
        else
        {
            JieDiao.Text = "未借调";
        }
        StaffNumber.Text = value[6];

        if (value[7] == "1")
        {
            OnJob.Text = "在职";
        }
        else
        {
            OnJob.Text = "已离职";
        }

    }

    //员工信息修改
    protected void Update_Click(object sender, EventArgs e)
    {
        string power = Request.Form["Post"].ToString().Trim();//职位
        if (power == "2")
        {
            power = Request.Form["fzr"].ToString().Trim();
        }
        string NewUserName = Username.Text.ToString().Trim();//用户名
        string NewUserPass = Pwd.Text.ToString().Trim();//密码
        string RealName = PeopleName.Text.ToString().Trim();//真实姓名
        string team = group2.Value;//获取小组
        string transfer = JieDiao.Text.ToString().Trim();//借调
        if (transfer == "已借调")
        {
            transfer = "1";
        }
        else
        {
            transfer = "0";
        }
        string peonumber = StaffNumber.Text.ToString().Trim();//员工编号
        string on_job = OnJob.Text.ToString().Trim();
        if (on_job == "在职")
        {
            on_job = "1";
        }
        else
        {
            on_job = "0";
        }

        sqlTable st = new sqlTable();
        string[] list01 = { "power", "password", "name", "team", "transfer", "peoplenumber", "on_job" };
        string[] list02 = { power, NewUserPass, RealName, team, transfer, peonumber, on_job };
        string[] list03 = { "username" };
        string[] list04 = { NewUserName };
        int res = st.table_update("Login", list01, list02, list03, list04);

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