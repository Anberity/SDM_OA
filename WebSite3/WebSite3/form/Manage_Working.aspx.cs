using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        String New_add_engineName = add_engineName.Text;
        String New_add_quotation = add_quotation.Text;
        String New_add_tender = add_tender.Text;
        String New_add_sign = add_sign.Text;
        String New_add_bid = add_bid.Text;
        String New_add_equip = add_equip.Text;
        String New_add_test = add_test.Text;
        String New_add_dun = add_dun.Text;
        String New_add_contract = add_contract.Text;
        String New_add_others = add_others.Text;
        String New_add_managerDays = add_managerDays.Text;
        String New_add_remarks = add_remarks.Text;
    }
}