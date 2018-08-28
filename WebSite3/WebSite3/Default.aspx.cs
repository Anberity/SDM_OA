using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpContext.Current.Session["power"] = "null";//权限
        HttpContext.Current.Session["username"] = "null";//获取用户名
        HttpContext.Current.Session["userpwd"] = "null";//获取密码
        HttpContext.Current.Session["name"] = "null";//获取用户名字
        HttpContext.Current.Session["team"] = "null";//获取用户小组
        HttpContext.Current.Session["number"] = 0;//获取用户小组
        HttpContext.Current.Session["yearh"] = DateTime.Now.Year.ToString();//历史年份
        HttpContext.Current.Session["monh"] = DateTime.Now.Month.ToString();//历史月份
    }

    protected void login_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        string[] value = new string[5];
        string[] list = { "power", "username", "password", "name", "team" };

        string username = UserName.Text.Trim();
        string password = Password.Text.Trim();
        if (username == "")
        {
            Response.Write(@"<script>alert('用户名不能为空！');</script>");
        }
        if (password == "")
        {
            Response.Write(@"<script>alert('密码不能为空！');</script>");
        }

        st.select_login(username, value, "Login", list);
        //session存储用户信息
        HttpContext.Current.Session["power"] = value[0];//权限
        HttpContext.Current.Session["username"] = value[1];//获取用户名
        HttpContext.Current.Session["userpwd"] = value[2];//获取密码
        HttpContext.Current.Session["name"] = value[3];//获取用户名字
        HttpContext.Current.Session["team"] = value[4];//获取用户小组
        HttpContext.Current.Session["number"] = 0;//获取用户小组

        // root 跳转
        if (username == value[1])
        {
            if (password == value[2])
            {
                if (int.Parse(value[0]) == 0)
                {
                    Response.Redirect("Root.aspx");
                }
                else if (int.Parse(value[0]) == 18)
                {
                    Response.Redirect("work.aspx");
                }
            }
            else
            {
                Response.Write(@"<script>alert('密码输入有误！');</script>");
            }
        }
        else
        {
            Response.Write(@"<script>alert('用户名输入有误！');</script>");
        }
    }



    protected void UserName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void changePass_Click(object sender, EventArgs e)
    {
        Response.Redirect("changePass.aspx");
    }
}