﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        string NewUserName = add_username.Text;//用户名
        string NewUserPass = add_userpass.Text;//密码
        string newPass = add_newPass.Text;//新密码
        string confirm = add_confirm.Text;//确认新密码

        sqlTable st = new sqlTable();
        string[] value = new string[5];
        string[][] rut = { value };
        string[] list = { "power", "username", "password", "name", "team" };
        st.select_login(NewUserName, rut, "Login", list);
        //查找用户，修改密码
        if (rut[0][1] != "root")
        {

            if (NewUserName == rut[0][1])
            {
                if (NewUserPass == rut[0][2])
                {
                    if (newPass == confirm)
                    {
                        string[] newPwdList = { "password" };
                        string[] newPwdSource = { newPass };
                        string[] userNameList = { "username" };
                        string[] userNameSource = { NewUserName };
                        int res = st.table_update("Login", newPwdList, newPwdSource, userNameList, userNameSource);
                        Response.Write(" <script> alert( '修改成功！ ');window.location.href= 'Default.aspx ' </script> ");

                    }
                    else
                    {
                        Response.Write(@"<script>alert('新密码两次输入不一致,请重新输入！');</script>");
                    }
                }
                else
                {
                    Response.Write(@"<script>alert('原密码输入有误,请重新输入！');</script>");
                }
            }
            else
            {
                Response.Write(@"<script>alert('用户名输入有误,请重新输入！');</script>");
            }
        }
        else
        {
            Response.Write(@"<script>alert('ROOT用户名不可更改密码！');</script>");
        }
    }
}