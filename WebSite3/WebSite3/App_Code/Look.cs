using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Look 的摘要说明
/// </summary>
public class Look
{
    //连接数据库字符串//10_141_189_255;DESKTOP-JFMFAQ0
    string constr = "data source=DESKTOP-JFMFAQ0;initial catalog=OA;user id=sa;pwd=67712563";
    /// <summary>
    /// 循环查看
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="list">查看列名</param>
    /// <param name="list1">限定列名</param>
    /// <param name="value1">限定列值</param>
    /// <returns>返回查到的数据</returns>
    public SqlCommand lookSelect(string tableName, string[] list, string[] list1, string[] value1)
    {
        if (list.Length == 0)
        {
            return null;
        }
        
        //SQL查看语句拼接
        string sql = "SELECT ";
        foreach (string i in list)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1) + " FROM " + tableName + " WHERE ";

        if (list1.Length == 0 || list1.Length != value1.Length)
        {
            return null;
        }
        int num = Math.Min(list1.Length, value1.Length);
        for (int i = 0; i < num; i++)
        {
            sql += list1[i] + " = '" + value1[i] + "' AND ";
        }
        sql = sql.Substring(0, sql.Length - 5);
        if (tableName != "Summary")
        {
            sql += "ORDER BY CAST(number as int) ASC";
        }
        //连接数据库并发送SQL语句
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd;
    }

    /// <summary>
    /// 当月所有员工工作量拉取
    /// </summary>
    /// <param name="tableName1">表一</param>
    /// <param name="tableName2">表二</param>
    /// <param name="list">查看列名</param>
    /// <param name="list1">限定列名</param>
    /// <param name="value1">限定列值</param>
    /// <returns>返回数据</returns>
    public SqlCommand lookSelectAll(string tableName1, string tableName2, string[] list, string[] list1, string[] value1)
    {
        if (list.Length == 0)
        {
            return null;
        }

        //SQL查看语句拼接
        string sql = "SELECT ";
        foreach (string i in list)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1) + " FROM " + tableName1 + "," + tableName2 + " WHERE ";

        if (list1.Length == 0 || list1.Length != value1.Length)
        {
            return null;
        }
        int num = Math.Min(list1.Length, value1.Length);
        for (int i = 0; i < num - 1; i++)
        {
            sql += list1[i] + " = '" + value1[i] + "' AND ";
        }
        sql += list1[list1.Length - 1] + " = " + value1[value1.Length - 1];
        if (tableName1 != "Summary")
        {
            sql += " ORDER BY Login.name ASC,CAST(number as int) ASC";
        }
        //连接数据库并发送SQL语句
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd;
    }

    /// <summary>
    /// 月份查看
    /// </summary>
    /// <param name="tableName1">员工姓名存储表</param>
    /// <param name="tableName2">汇总存储表</param>
    /// <param name="list">查看列名</param>
    /// <param name="list1">限定列名</param>
    /// <param name="value1">限定值</param>
    /// <returns>查找数据</returns>
    public SqlCommand lookSelectAll2(string tableName1, string tableName2, string[] list, string[] list1, string[] value1)
    {
        if (list.Length == 0)
        {
            return null;
        }

        //SQL查看语句拼接
        string sql = "SELECT ";
        foreach (string i in list)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1) + " FROM " + tableName1 + "," + tableName2 + " WHERE ";

        if (list1.Length == 0 || list1.Length != value1.Length)
        {
            return null;
        }
        int num = Math.Min(list1.Length, value1.Length);
        for (int i = 0; i < num - 1; i++)
        {
            sql += list1[i] + " = '" + value1[i] + "' AND ";
        }
        sql += list1[list1.Length - 1] + " = " + value1[value1.Length - 1];
            sql += " ORDER BY Login.name ASC";
        //连接数据库并发送SQL语句
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd;
    }

    /// <summary>
    /// 年份查看
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="list">查看列名</param>
    /// <param name="list1">限定列</param>
    /// <param name="value1">限定列值</param>
    /// <returns>查找数据</returns>
    public SqlCommand lookSelectAll3(string tableName, string[] list, string[] list1, string[] value1)
    {
        if (list.Length == 0)
        {
            return null;
        }

        //SQL查看语句拼接
        string sql = "SELECT ";
        foreach (string i in list)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1) + " FROM " + tableName + " WHERE ";

        if (list1.Length == 0 || list1.Length != value1.Length)
        {
            return null;
        }
        int num = Math.Min(list1.Length, value1.Length);
        for (int i = 0; i < num - 1; i++)
        {
            sql += list1[i] + " = '" + value1[i] + "' AND ";
        }
        sql += list1[list1.Length - 1] + " = " + value1[value1.Length - 1];
        sql += " ORDER BY CAST(month as int) ASC";
        //连接数据库并发送SQL语句
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd;
    }

    /// <summary>
    /// 简单查看
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="list">查看列名</param>
    /// <returns>返回数据</returns>
    public SqlCommand lookSelectUser(string tableName, string[] list)
    {
        if (list.Length == 0)
        {
            return null;
        }

        //SQL查看语句拼接
        string sql = "SELECT ";
        foreach (string i in list)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1) + " FROM " + tableName;

        //连接数据库并发送SQL语句
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd;
    }
}