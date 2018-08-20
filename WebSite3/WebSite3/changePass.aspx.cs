using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String NewUserName = add_username.Text;//用户名
        String NewUserPass = add_userpass.Text;//密码
        String newPass = add_newPass.Text;//新密码
        String confirm = add_confirm.Text;//确认新密码
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}