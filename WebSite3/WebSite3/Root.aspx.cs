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
        string[] list = { "power", "username", "password", "name", "team" };
        string[] source = { power.ToString(), NewUserName, NewUserPass, RealName, Group };
        if (NewUserName == "" || NewUserPass == "" || RealName == "")
        {
            Response.Write("<script>alert('请输入完整信息')</script>");
        }
        else
        {
            sqlTable st = new sqlTable();
            st.table_insert_login("Login", list, source);
            Response.Write("<script>alert('成功')</script>");
        }

    }
}