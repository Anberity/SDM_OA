﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public static string pusername = "";
    public static string puserpwd = "";
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
        pusername = rut[0][1];//获取用户名
        puserpwd = rut[0][2];//获取密码

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
}