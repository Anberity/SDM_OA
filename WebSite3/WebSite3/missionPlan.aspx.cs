using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class missionPlan : System.Web.UI.Page
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

        String engineName = add_engineName.Text; //项目名称
        String number = add_number.Text; // 工程编号
        String ide = add_ide.Text; // 编程软件
        String recipient = add_recipient.Text; // 任务接收人
        String auditor = add_auditor.Text; // 审核人
        String StartDay = Request.Form["Start"]; // 开始时间
        String EndDay = Request.Form["End"]; // 结束时间
        String info = add_info.Text; // 已有资料
        String require = add_require.Text; // 编程质量需求
    }
}