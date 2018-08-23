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
        /*string constr = "data source=DESKTOP-JFMFAQ0;initial catalog=OA;user id=sa;pwd=67712563";
        string sql = "SELECT * FROM Debug WHERE year=" + DateTime.Now.Year.ToString() + " AND month=" + DateTime.Now.Month.ToString();//+  " AND username=zdhhyz";
        //projectname,site,manageday,debugday,remark
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);

        Repeater1.DataSource = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        Repeater1.DataBind();*/
    }
}