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
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = Variable.username;
        string team = Variable.team;

        //网页输入
        String New_add_business = add_business.Text;//本月出差天数
        String New_add_technical = add_technical.Text;//技术交流天数
        String New_add_others = add_others.Text;//其他零星工日
        String New_add_remarks = add_remarks.Text;//备注

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "chuchai_day", "jiaoliu_day", "other_day", "remark" };
        string[] source = { year, month, username, team, New_add_business, New_add_technical, New_add_others, New_add_remarks };

        //插入
        sqlTable st = new sqlTable();
        int res = st.table_insert_login("LingXing", list, source);
        if (res == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('输入有误，请重新输入')</script>");
        }
    }
}