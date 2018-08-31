using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class work : System.Web.UI.Page
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
    }
}