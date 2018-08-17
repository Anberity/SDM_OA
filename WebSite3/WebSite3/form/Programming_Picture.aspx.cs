using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        String New_add_engineName = add_engineName.Text;
        String New_add_onOffNum = add_onOffNum.Text;
        String New_add_modeNum = add_modeNum.Text;
        String New_add_program = add_program.Text;
        String New_add_allDays = add_allDays.Text;
        String New_add_finishedDays = add_finishedDays.Text;
        String New_add_remarks = add_remarks.Text;
    }
}