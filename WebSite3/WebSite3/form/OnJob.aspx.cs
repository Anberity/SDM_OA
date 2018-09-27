﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_OnJob : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //借调
    protected void add_Click(object sender, EventArgs e)
    {
        string branch = "借调至";
        branch += add_index.Text.Trim();//借调部门
        string username = HttpContext.Current.Session["username"].ToString();

        //查找借调状态
        string[] onJob = new string[1];
        string[] seList = { "transfer" };
        sqlTable st = new sqlTable();
        st.select_login(username, onJob, "Login", seList);

        if (onJob[0] == "1")
        {
            Response.Write("<script>alert('您已被借调至其他部门')</script>");
        }
        else if (onJob[0] == "0")
        {
            string[] bra = new string[1];

            string[] list = { "year", "month", "username" };
            string[] source = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username };

            st.select_easy(list, source, bra, "Jiediao", seList);

            if (bra[0] == "null" || bra[0] == null || bra[0] == "NULL")
            {
                string[] list02 = { "year", "month", "username", "team", "transfer", "ratio" };
                string t = HttpContext.Current.Session["team"].ToString();
                string[] source02 = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), username, t, branch, "无" };
                int res = st.table_insert("Jiediao", list02, source02);

                string[] soList = { "1" };
                string[] usese = { "username", "password" };
                string[] useso = { HttpContext.Current.Session["username"].ToString(), HttpContext.Current.Session["userpwd"].ToString() };
                int res2 = st.table_update("Login", seList, soList, usese, useso);

                #region 提示
                if (res == 1 && res2 == 1)
                {
                    Response.Write("<script>alert('借调成功')</script>");
                }
                else if (res == 0 || res2 == 0)
                {
                    Response.Write("<script>alert('数组长度不一致，请联系管理员')</script>");
                }
                else if (res == 2 || res2 == 2)
                {
                    Response.Write("<script>alert('程序异常，请联系管理员')</script>");
                }
                #endregion
            }
            else
            {
                string[] sour = { branch };
                int res = st.table_update("Jiediao", seList, sour, list, source);

                string[] soList = { "1" };
                string[] usese = { "username", "password" };
                string[] useso = { HttpContext.Current.Session["username"].ToString(), HttpContext.Current.Session["userpwd"].ToString() };
                int res2 = st.table_update("Login", seList, soList, usese, useso);

                #region 提示
                if (res == 1 && res2 == 1)
                {
                    Response.Write("<script>alert('借调成功')</script>");
                }
                else if (res == 0 || res2 == 0)
                {
                    Response.Write("<script>alert('数组长度不一致，请联系管理员')</script>");
                }
                else if (res == 2 || res2 == 2)
                {
                    Response.Write("<script>alert('程序异常，请联系管理员')</script>");
                }
                #endregion
            }
        }
        else
        {
            Response.Write("<script>alert('借调状态错误，请联系管理员')</script>");
        }
    }
}