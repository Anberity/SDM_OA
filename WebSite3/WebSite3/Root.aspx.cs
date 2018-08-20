using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Root : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
            default:
                power = 1;
                break;
        }
        String Group = Request.Form["group"].ToString().Trim();//小组
        if (Group == "自动化")
        {
            Group = "1";
        }
        else
        {
            Group = "2";
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

    //protected void Unnamed2_Click(object sender, EventArgs e)
    //{
    //    string delUserName = del_username.Text;//用户名
    //    string delName = del_realname.Text;//姓名

    //    string[] list = { "username", "name" };
    //    string[] source = { delUserName, delName };

    //    sqlTable st = new sqlTable();
    //    st.table_delete("Login", list, source);
    //}

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        string delUserName = del_username.Text;//用户名
        string delName = del_realname.Text;//姓名

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
            Response.Write("<script>alert('失败2')</script>");
        }
    }
}