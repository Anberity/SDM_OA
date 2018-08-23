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
        //连接数据库字符串
        string constr = "data source=DESKTOP-JFMFAQ0;initial catalog=OA;user id=sa;pwd=67712563";

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

        //连接数据库并发送SQL语句
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd;
    }
}