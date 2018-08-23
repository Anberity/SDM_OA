using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string tableName = "Debug";//表名
        string[] sourceList = { "projectname", "site", "manageday", "debugday", "remark" };//查看列名
        string[] selectList = { "year", "month", "username" };//限定列名
        string[] selectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "zdhhyz" };//限定列值

        //连接数据查看并显示在网页
        sqlTable st = new sqlTable();
        SqlCommand cmd = st.lookSelect(tableName, sourceList, selectList, selectValue);
        Repeater1.DataSource = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        Repeater1.DataBind();
    }
    

    protected void DesignBtn_Click(object sender, EventArgs e)
    {

    }
}