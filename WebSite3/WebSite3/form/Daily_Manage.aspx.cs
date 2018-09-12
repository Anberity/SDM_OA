﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class form5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //增加事件
    protected void submit_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        int number = 0;//填写序号
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();
        string team = HttpContext.Current.Session["team"].ToString();


        //网页输入
        string New_add_index = add_index.Text.Trim(); //添加索引
        string New_add_management = add_management.Text.Trim();//部门内部日常管理
        string New_add_affair = add_affair.Text.Trim();//工会事务
        string New_add_affair2 = add_affair2.Text.Trim();//党组事务
        string New_add_affair3 = add_affair3.Text.Trim();//团组事务
        string New_add_examine = add_examine.Text.Trim();//体系内审/外审
        string New_add_check = add_check.Text.Trim();//考勤
        string New_add_others = add_others.Text.Trim();//其他报销
        string New_add_remarks = add_remarks.Text.Trim();//备注

        //全为空不允许填写
        if (New_add_management == "" && New_add_affair == "" && New_add_affair2 == "" && New_add_affair3 == "" && New_add_examine == "" && New_add_check == "" && New_add_others == "" && New_add_remarks == "")
        {
            Response.Write("<script>alert('插入工作量为空，请重新填写')</script>");
            return;
        }

        //当月日常工作总工日汇总
        float monthSum = 0;
        if (add_management.Text != "")
        {
            monthSum += float.Parse(New_add_management);
        }
        if (add_affair.Text != "")
        {
            monthSum += float.Parse(New_add_affair);
        }
        if (add_affair2.Text != "")
        {
            monthSum += float.Parse(New_add_affair2);
        }
        if (add_affair3.Text != "")
        {
            monthSum += float.Parse(New_add_affair3);
        }
        if (add_examine.Text != "")
        {
            monthSum += float.Parse(New_add_examine);
        }
        if (add_check.Text != "")
        {
            monthSum += float.Parse(New_add_check);
        }
        if (add_others.Text != "")
        {
            monthSum += float.Parse(New_add_others);
        }

        //number在原有基础上加1
        string list1 = "number";
        string[] value = new string[1];
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture" };

        st.select_number(list1, value, tableName, year, month, username);
        if (value[0] != "" && value[0] != "NULL" && value[0] != "null")
        {
            number = int.Parse(value[0]) + 1;
        }
        else
        {
            number = 1;
        }
        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "number", "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "other", "month_day", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_management, New_add_affair, New_add_affair2, New_add_affair3, New_add_examine, New_add_check, New_add_others, monthSum.ToString(), New_add_remarks };

        //插入
        int res = st.table_insert("Daily_Manage", list, source);

        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else if (res == 2)
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }

    // 修改事件
    protected void modifybtn_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_index = add_index.Text.Trim(); //添加索引
        string New_add_management = add_management.Text.Trim();//部门内部日常管理
        string New_add_affair = add_affair.Text.Trim();//工会事务
        string New_add_affair2 = add_affair2.Text.Trim();//党组事务
        string New_add_affair3 = add_affair3.Text.Trim();//团组事务
        string New_add_examine = add_examine.Text.Trim();//体系内审/外审
        string New_add_check = add_check.Text.Trim();//考勤
        string New_add_others = add_others.Text.Trim();//其他报销
        string New_add_remarks = add_remarks.Text.Trim();//备注

        //查找索引是否存在
        string[] listNumber = { "year", "month", "username", "number" };
        string[] sourceNumber = { year, month, username, New_add_index };
        string[] selectNumber = { "number" };
        string tableNameNumber = "Daily_Manage";
        string[] resNumber = new string[1];
        st.select_delete(tableNameNumber, resNumber, listNumber, sourceNumber, selectNumber);
        if (New_add_index != resNumber[0])
        {
            Response.Write("<script>alert('填写序号有误')</script>");
            return;
        }

        //当月总工日汇总
        float monthSum = 0;//修改汇总

        if (add_management.Text != "")
        {
            monthSum += float.Parse(New_add_management);
        }
        if (add_affair.Text != "")
        {
            monthSum += float.Parse(New_add_affair);
        }
        if (add_affair2.Text != "")
        {
            monthSum += float.Parse(New_add_affair2);
        }
        if (add_affair3.Text != "")
        {
            monthSum += float.Parse(New_add_affair3);
        }
        if (add_examine.Text != "")
        {
            monthSum += float.Parse(New_add_examine);
        }
        if (add_check.Text != "")
        {
            monthSum += float.Parse(New_add_check);
        }
        if (add_others.Text != "")
        {
            monthSum += float.Parse(New_add_others);
        }

        //更新列名以及数据源
        string[] list = { "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "other", "month_day", "remark" };
        string[] source = { New_add_management, New_add_affair, New_add_affair2, New_add_affair3, New_add_examine, New_add_check, New_add_others, monthSum.ToString(), New_add_remarks };

        //查找列名以及数据源
        string[] selectList = { "year", "month", "username", "number" };
        string[] selectSource = { year, month, username, New_add_index };

        //插入
        int res = st.table_update("Daily_Manage", list, source, selectList, selectSource);

        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else if (res == 2)
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }

    //删除事件
    protected void delete_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_index = add_index.Text.Trim(); //添加索引

        //查找索引是否存在
        string[] listNumber = { "year", "month", "username", "number" };
        string[] sourceNumber = { year, month, username, New_add_index };
        string[] selectNumber = { "number" };
        string tableNameNumber = "Daily_Manage";
        string[] resNumber = new string[1];
        st.select_delete(tableNameNumber, resNumber, listNumber, sourceNumber, selectNumber);
        if (New_add_index != resNumber[0])
        {
            Response.Write("<script>alert('填写序号有误')</script>");
            return;
        }

        //查找原来日常工作量当月汇总
        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        int res = st.table_delete("Daily_Manage", list5, source5);

        #region 修改number值
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture" };
        string[] columns = { "number" };
        String[,] temp = new String[30, 1];
        String[,] temp1 = new String[30, 1];
        string[] xianding = { "year", "month", "username" };
        string[] xdValue = { year, month, username };

        for (int k = 0; k < tableName.Length; k++)
        {
            for (int j = 0; j < temp.Length; j++)
            {
                temp[j, 0] = null;
            }
            //st.page_flash(temp, tableName[k], columns);//tableName[i]
            st.selecet_number(temp, tableName[k], columns, xianding, xdValue);
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                if (temp[i, 0] == null)
                {
                    break;
                }
                if (int.Parse(temp[i, 0]) > int.Parse(New_add_index))
                {
                    temp1[i, 0] = temp[i, 0];
                    temp[i, 0] = (int.Parse(temp[i, 0]) - 1).ToString();
                    string[] temp2 = new string[1];
                    temp2[0] = temp[i, 0];
                    string[] upsource = { year, month, username, temp1[i, 0] };
                    st.table_update(tableName[k], columns, temp2, list5, upsource);
                }
            }
        }
        #endregion

        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else if (res == 0)
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
        else if (res == 2)
        {
            Response.Write("<script>alert('语法错误')</script>");
        }
    }

    //修改内容拉取
    protected void add_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //网页输入
        string New_add_index = add_index.Text.Trim(); // 索引

        //获取年月日以及用户名
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //查找索引是否存在
        string[] listNumber = { "year", "month", "username", "number" };
        string[] sourceNumber = { year, month, username, New_add_index };
        string[] selectNumber = { "number" };
        string tableNameNumber = "Daily_Manage";
        string[] resNumber = new string[1];
        st.select_delete(tableNameNumber, resNumber, listNumber, sourceNumber, selectNumber);
        if (New_add_index != resNumber[0])
        {
            Response.Write("<script>alert('填写序号有误')</script>");
            return;
        }

        //查找原来日常工作量当月汇总
        string[] list = { "year", "month", "username", "number" };
        string[] source = { year, month, username, New_add_index };
        string[] select_List = { "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "other", "remark" };
        string[] data = new string[8];
        st.select_delete("Daily_Manage", data, list, source, select_List);

        //text框赋值
        add_management.Text = data[0];//部门内部日常管理
        add_affair.Text = data[1];//工会事务
        add_affair2.Text = data[2];//党组事务
        add_affair3.Text = data[3];//团组事务
        add_examine.Text = data[4];//体系内审/外审
        add_check.Text = data[5];//考勤
        add_others.Text = data[6];//其他报销
        add_remarks.Text = data[7];//备注

    }
}