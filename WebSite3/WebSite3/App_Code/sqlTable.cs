using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

/// <summary>
/// sqlTable 的摘要说明
/// </summary>
public class sqlTable
{
    DataLogic dal = new DataLogic();

    /// <summary>
    /// 数据库内容添加
    /// </summary>
    /// <param name="table_name">表名</param>
    /// <param name="columns">列名</param>
    /// <param name="values">插入内容</param>
    /// <returns>是否成功，0--失败，1--成功</returns>
    public int table_insert(string table_name, string[] columns, string[] values)
    {
        string sql = "insert into ";
        try
        {
            if (columns.Length == 0 || columns.Length != values.Length) return 0;

            sql += table_name;
            sql += "(";

            int[] length = { columns.Length, values.Length };
            int a = length.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns[i] + ",";
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ") values('";
            for (int i = 0; i < a; i++)
            {
                sql += values[i] + "','";
            }
            sql = sql.Substring(0, sql.Length - 3);
            sql += "')";


            int Exe = dal.ExecDataBySql(sql);
            return 1;
        }
        catch (Exception e)
        {
            return 0;
        }
    }

    /// <summary>
    /// 数据库内容删除
    /// </summary>
    /// <param name="table_name">表名</param>
    /// <param name="columns">列名</param>
    /// <param name="values">列值</param>
    /// <returns>是否成功，0--失败，1--成功</returns>
    public int table_delete(string table_name, string[] columns, string[] values)
    {
        string sql = "DELETE FROM " + table_name + "WHERE ";
        try
        {
            if (columns.Length == 0 || columns.Length != values.Length) return 0;

            int[] length = { columns.Length, values.Length };
            int a = length.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns[i] + " = " + values[i] + " AND ";
            }
            sql = sql.Substring(0, sql.Length - 5);

            int Exe = dal.ExecDataBySql(sql);
            return 1;
        }
        catch (Exception e)
        {
            return 0;
        }
    }

    /// <summary>
    /// 数据库内容修改
    /// </summary>
    /// <param name="table_name">表名</param>
    /// <param name="username">用户名</param>
    /// <param name="year">年份</param>
    /// <param name="month">月份</param>
    /// <param name="columns">列名</param>
    /// <param name="values">修改值</param>
    /// <returns>是否成功，1--成功，0--失败</returns>
    public int table_update(string table_name, string username, string year, string month, string[] columns, string[] values)
    {
        string sql = "UPDATE " + table_name + " SET ";
        try
        {
            if (columns.Length == 0 || columns.Length != values.Length) return 0;
            int[] length = { columns.Length, values.Length };
            int a = length.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns[i] + " = '" + values[i] + "',";
            }

            sql = sql.Substring(0, sql.Length - 1);
            sql += " WHERE year = " + year + " AND " + "month = " + month + " AND " + "username = " + username;

            int Exe = dal.ExecDataBySql(sql);
            return 1;
        }
        catch (Exception e)
        {
            return 0;
        }
    }

    /// <summary>
    /// 数据库查找
    /// </summary>
    /// <param name="mySql">查询结果</param>
    /// <param name="table">表名</param>
    /// <param name="columns">列名</param>
    public void page_flash(String[][] mySql, string table, string[] columns)
    {
        int err = 0;
        string sql = "select TOP " + mySql.Length + " ";

        foreach (string i in columns)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1);
        sql += " FROM " + table + " order by year DESC,month DESC";

        DataSet ds = dal.GetDataSet(sql, table);

        for (int i = 0; i < mySql.Length; i++)
        {
            for (int j = 0; j < mySql[i].Length; j++)
            {
                try
                {
                    string temp13 = "0";
                    if (ds.Tables[0].Rows[i][j].ToString() != null)
                    {
                        temp13 = ds.Tables[0].Rows[i][j].ToString();


                    }
                    mySql[i][j] = temp13;
                }
                catch (Exception Error)
                {

                    err++;
                }
            }
        }
        if (err != 0)
        {
        }
    }
   
    /// <summary>
    /// 登录查询
    /// </summary>
    /// <param name="username">用户名</param>
    /// <param name="mySql">查询结果</param>
    /// <param name="table">表名</param>
    /// <param name="columns">列名</param>
    public void select_login(string username, String[][] mySql, string table, string[] columns)
    {
        string sql = "SELECT ";

        foreach (string i in columns)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1);
        sql += " FROM " + table + " WHERE USERNAME='" + username + "'";

        DataSet ds = dal.GetDataSet(sql, table);
        try
        {
            for (int j = 0; j < mySql[0].Length; j++)
            {
                string temp13 = "0";
                if (ds.Tables[0].Rows[0][j].ToString() != null)
                {
                    temp13 = ds.Tables[0].Rows[0][j].ToString();


                }
                mySql[0][j] = temp13;
            }
        }
        catch (Exception Error)
        {

            for (int i = 0; i < mySql[0].Length; i++)
            {
                mySql[0][i] = "NULL";
            }
        }

    }

    /// <summary>
    /// 用户密码修改
    /// </summary>
    /// <param name="table_name">表名</param>
    /// <param name="username">用户名</param>
    /// <param name="pwd">新密码</param>
    /// <returns>是否成功，1--成功，0--失败</returns>
    public int update_login(string table_name, string name, string pwd)
    {
        string sql = "UPDATE " + table_name + " SET password = " + pwd + " WHERE name = " + name;
        try
        {
            int Exe = dal.ExecDataBySql(sql);
            return 1;
        }
        catch (Exception e)
        {
            return 0;
        }
    }
}