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

    }

    protected void login_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        string[] value = new string[5];
        string[][] rut = { value };
        string[] list = { "power", "username", "password", "name", "team" };

        string username = UserName.Text.Trim();
        string password = Password.Text.Trim();
        Session["username"] = username;
        Session["password"] = password;

        st.select_login(username, rut, "Login", list);

        //获取用户信息
        Variable.power = rut[0][0];//权限
        Variable.username = rut[0][1];//获取用户名
        Variable.userpwd = rut[0][2];//获取密码
        Variable.name = rut[0][3];//获取用户名字
        Variable.team = rut[0][4];//获取用户小组

        if (username == "")
        {
            Response.Write(@"<script>alert('用户名不能为空！');</script>");
        }
        if (password == "")
        {
            Response.Write(@"<script>alert('密码不能为空！');</script>");
        }

        // root 跳转
        if (rut[0][0] != "NULL")
        {
            if (int.Parse(rut[0][0]) == 0 && password == rut[0][2])
            {
                //Session["team"] = "自动化";
                //Session["power"] = "root";
                Response.Redirect("Root.aspx");

            }
            else if (int.Parse(rut[0][0]) == 18 && password == rut[0][2])
            {
                Response.Redirect("work.aspx");
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