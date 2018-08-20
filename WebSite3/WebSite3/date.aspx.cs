using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class date : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Confirm_Click(object sender, EventArgs e)
    {
        String StartDay = Request.Form["Start"];  // "2018-8-15"
        String EndDay = Request.Form["End"]; 
        // 拆分开始日期
        string[] sArray = Regex.Split(StartDay, "-", RegexOptions.IgnoreCase); //["2018","8","15"]
    }
}