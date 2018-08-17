using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        String num = Request.Form["num"];
        String New_add_engine = add_engine.Text;
        String New_add_engineName = add_engineName.Text;
        String New_add_paperPage = add_paperPage.Text;
        String New_add_al = add_al.Text;
        String New_add_allDays = add_allDays.Text;
        String New_add_finishedDays = add_finishedDays.Text;
        String New_add_usedDays = add_usedDays.Text;
        String New_add_usedDays2 = add_usedDays2.Text;
        String New_add_leaderDays = add_leaderDays.Text;
        String New_add_remarks = add_remarks.Text;
    }
}