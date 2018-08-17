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
    public sqlTable()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    DataLogic dal = new DataLogic();

    public void table_insert(string table_name, string[] columns, string[] values, string time)
    {

        try
        {
            if (columns.Length == 0 || columns.Length != values.Length) return;

            string sql = "insert into ";
            sql += table_name;
            sql += "(DATE_TIME,";

            int[] length = { columns.Length, values.Length };
            int a = length.Min();

            for (int i = 0; i < a; i++)
            {
                sql += columns[i] + ",";
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ") values('" + time + "',";
            for (int i = 0; i < a; i++)
            {
                sql += values[i] + ",";
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";

            int Exe = dal.ExecDataBySql(sql);
        }
        catch (Exception Error)
        {
        }
    }

    public void table_insert_login(string table_name, string[] columns, string[] values)
    {
        string sql = "insert into ";
        try
        {
            if (columns.Length == 0 || columns.Length != values.Length) return;
            
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
        }
        catch (Exception e)
        {
        }
    }

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
    public void select_login(String[][] mySql, string table, string[] columns)
    {
        int err = 0;
        string sql = "select TOP " + mySql.Length + " ";

        foreach (string i in columns)
        {
            sql += i + ",";
        }
        sql = sql.Substring(0, sql.Length - 1);
        sql += " FROM " + table;

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
}