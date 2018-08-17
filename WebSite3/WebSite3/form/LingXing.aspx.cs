using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        String New_add_business = add_business.Text;
        String New_add_technical = add_technical.Text;
        String New_add_others = add_others.Text;
        String New_add_remarks = add_remarks.Text;
    }
}