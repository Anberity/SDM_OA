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
        string sql = "DELETE FROM " + table_name + " WHERE ";
        try
        {
            if (columns.Length == 0 || columns.Length != values.Length) return 0;

            int[] length = { columns.Length, values.Length };
            int a = length.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns[i] + " = '" + values[i] + "' AND ";
            }
            sql = sql.Substring(0, sql.Length - 5);

            int Exe = dal.ExecDataBySql(sql);
            return 1;
        }
        catch (Exception e)
        {
            return 2;
        }
    }

    /// <summary>
    /// 数据库内容更新
    /// </summary>
    /// <param name="table_name">表名</param>
    /// <param name="columns1">更新列名</param>
    /// <param name="values1">更新值</param>
    /// <param name="columns2">查找列名</param>
    /// <param name="values2">查找值</param>
    /// <returns></returns>
    public int table_update(string table_name, string[] columns1, string[] values1, string[] columns2, string[] values2)
    {
        string sql = "UPDATE " + table_name + " SET ";
        try
        {
            if (columns1.Length == 0 || columns1.Length != values1.Length) return 0;
            int[] length = { columns1.Length, values1.Length };
            int a = length.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns1[i] + " = '" + values1[i] + "',";
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += " WHERE ";

            if (columns2.Length == 0 || columns2.Length != values2.Length) return 0;
            int[] length2 = { columns2.Length, values2.Length };
            a = length2.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns2[i] + " = '" + values2[i] + "' AND ";
            }

            sql = sql.Substring(0, sql.Length - 5);

            int Exe = dal.ExecDataBySql(sql);
            return 1;
        }
        catch (Exception e)
        {
            return 2;
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
    public void select_login(string username, String[] mySql, string table, string[] columns)
    {
        string sql = "SELECT ";

        foreach (string i in columns)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1);
        sql += " FROM " + table + " WHERE username='" + username + "'";

        DataSet ds = dal.GetDataSet(sql, table);
        try
        {
            for (int j = 0; j < mySql.Length; j++)
            {
                string temp13 = "0";
                if (ds.Tables[0].Rows[0][j].ToString() != null)
                {
                    temp13 = ds.Tables[0].Rows[0][j].ToString();
                }
                mySql[j] = temp13;
            }
        }
        catch (Exception Error)
        {

            for (int i = 0; i < mySql.Length; i++)
            {
                mySql[i] = "NULL";
            }
        }
        
    }

    /// <summary>
    /// 多表联合查询单一列最大值
    /// </summary>
    /// <param name="list">列名</param>
    /// <param name="mySql">查询结果</param>
    /// <param name="tableName">表名</param>
    /// <param name="year">年份</param>
    /// <param name="month">月份</param>
    /// <param name="username">用户名</param>
    public void select_number(string list, String[] mySql, string[] tableName, string year, string month, string username)
    {

        //SELECT MAX(number) from (SELECT number from Daily_Manage WHERE year='2018' AND month='8' union SELECT number from Debug WHERE year='2018' AND month='8' union SELECT number from Design WHERE year='2018' AND month='8' union SELECT number from LingXing WHERE year='2018' AND month='8' union SELECT number from Manage_Working WHERE year='2018' AND month='8' union SELECT number from Programing_Picture WHERE year='2018' AND month='8' union SELECT number from Summary WHERE year='2018' AND month='8') A
        string sql = "SELECT MAX(CAST(" + list + " as int)) from (";

        foreach (string i in tableName)
        {
            sql += "SELECT " + list + " from " + i + " WHERE year = '" + year + "' AND month = '" + month + "' AND username = '" + username + "' union ";
        }
        sql = sql.Substring(0, sql.Length - 7);
        sql += ") A";

        DataTable dt = dal.GetDataTable1(sql);
        try
        {
            for (int j = 0; j < mySql.Length; j++)
            {
                string temp13 = "0";
                temp13 = dt.Rows[0][j].ToString();
                mySql[0] = temp13;
            }
        }
        catch (Exception Error)
        {
            mySql[0] = "NULL";
        }
    }
}