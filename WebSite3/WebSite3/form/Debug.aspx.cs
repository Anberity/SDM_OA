using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        String New_add_engineName = add_engineName.Text;
        String New_add_enginePlace = add_enginePlace.Text;
        String New_add_manageDays = add_manageDays.Text;
        String New_add_debugDays = add_debugDays.Text;
        String New_add_remarks = add_remarks.Text;
    }
}