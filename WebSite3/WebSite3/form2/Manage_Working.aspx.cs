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
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = Variable.username;
        string team = Variable.team;

        //网页输入
        String New_add_engineName = add_engineName.Text;//项目名称
        String New_add_quotation = add_quotation.Text;//商务询价报价
        String New_add_tender = add_tender.Text;//标书制作
        String New_add_sign = add_sign.Text;//合同制作与签署
        String New_add_bid = add_bid.Text;//投标工作
        String New_add_equip = add_equip.Text;//设备招标采购
        String New_add_test = add_test.Text;//设备出厂检测
        String New_add_dun = add_dun.Text;//催款（要账）
        String New_add_contract = add_contract.Text;//合同管理
        String New_add_others = add_others.Text;//其他经营活动
        String New_add_managerDays = add_managerDays.Text;//项目经理
        String New_add_remarks = add_remarks.Text;//备注

        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "project_name", "xunjia_baojia", "tender", "sign", "toubiao", "equip", "test", "cuikuan", "contract", "other", "PM_day", "remark" };
        string[] source = { year, month, username, team, New_add_engineName, New_add_quotation, New_add_tender, New_add_sign, New_add_bid, New_add_equip, New_add_test, New_add_dun, New_add_contract, New_add_others, New_add_managerDays, New_add_remarks };

        //插入
        sqlTable st = new sqlTable();
        int res = st.table_insert("Manage_Working", list, source);
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