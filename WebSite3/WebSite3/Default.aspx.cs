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
        string username = UserName.Text.Trim();
        string password = Password.Text.Trim();
        Session["username"] = username;
        Session["password"] = password;
        if (username == "")
        {
            Response.Write(@"<script>alert('用户名不能为空！');</script>");
        }
        if (password == "")
        {
            Response.Write(@"<script>alert('密码不能为空！');</script>");
        }
        //st.page_flash(,"Login",)
        // root 跳转
        if(username == "root" && password == "root")
        {
            Session["team"] = "自动化";
            Session["power"] = "root";
            Response.Redirect("Root.aspx");
        }
    }



    protected void UserName_TextChanged(object sender, EventArgs e)
    {

    }
}