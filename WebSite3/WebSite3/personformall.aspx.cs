using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
public partial class personformall : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (HttpContext.Current.Session["username"].ToString() == "null" || HttpContext.Current.Session["userpwd"].ToString() == "null")
            {
                HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
            }
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= 'Default.aspx ' </script> ");
        }

        string str = "2018-08"; // "2018-08"
        // 拆分开始日期
        string[] sArray = Regex.Split(str, "-", RegexOptions.IgnoreCase); //["2018","08"]

        Regex regNum = new Regex("^[0]");
        if (regNum.IsMatch(sArray[1]))
        {
            sArray[1] = sArray[1].Substring(1, 1); // "08" -> "8"

        }
        string newstr = string.Join("-", sArray); // "2018-8" 也可以不再拼接，看如何使用 代码无法检测还需试验
    }

    protected void refresh_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.location.href=window.location.href;</script>");
    }

    protected void close_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();</script>");
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        
         
    }
}