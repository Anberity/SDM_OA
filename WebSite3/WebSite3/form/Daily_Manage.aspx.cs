using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        String New_add_management = add_management.Text;
        String New_add_affair = add_affair.Text;
        String New_add_affair2 = add_affair2.Text;
        String New_add_affair3 = add_affair3.Text;
        String New_add_examine = add_examine.Text;
        String New_add_check = add_check.Text;
        String New_add_tel = add_tel.Text;
        String New_add_meal = add_meal.Text;
        String New_add_others = add_others.Text;
        String New_add_statistics = add_statistics.Text;
        String New_add_remarks = add_remarks.Text;
    }
}