using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_allperson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void close_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();</script>");
    }

    protected void Design_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "update")//如果点击的是被标记为CommandName="update"的按钮，也就是修改按钮
        {
            int id = int.Parse(e.CommandArgument.ToString().Split(',')[0]);//这里还真必须用单引号来表示字符，而不是""的字符串~，C#的Split就一个以字符，而不是字符串参数的代码
            int itemIndex = int.Parse(e.CommandArgument.ToString().Split(',')[1]);//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号

            TextBox number = Design_Repeater.Items[itemIndex].FindControl("number") as TextBox;//获得改行的TextBox1
            TextBox name = Design_Repeater.Items[itemIndex].FindControl("name") as TextBox;//获得改行的TextBox2
            TextBox project_number = Design_Repeater.Items[itemIndex].FindControl("project_number") as TextBox;
            TextBox project_name = Design_Repeater.Items[itemIndex].FindControl("project_name") as TextBox;
            TextBox drawing_number = Design_Repeater.Items[itemIndex].FindControl("drawing_number") as TextBox;
            TextBox A1_number = Design_Repeater.Items[itemIndex].FindControl("A1_number") as TextBox;
            TextBox zhehe_working_day = Design_Repeater.Items[itemIndex].FindControl("zhehe_working_day") as TextBox;
            TextBox month_day = Design_Repeater.Items[itemIndex].FindControl("month_day") as TextBox;
            TextBox program_day = Design_Repeater.Items[itemIndex].FindControl("program_day") as TextBox;
            TextBox basic_design_day = Design_Repeater.Items[itemIndex].FindControl("basic_design_day") as TextBox;
            TextBox leader = Design_Repeater.Items[itemIndex].FindControl("leader") as TextBox;
            //这里是修改数据库表的一般逻辑，不赘述了
            if (TextBox1.Text.Trim().Equals("") || TextBox2.Text.Trim().Equals(""))
            {
                Response.Write("<b>用户名，密码不得为空！</b>");
            }
            else
            {
                if (db.getBySql("select * from [user_info] where [username]='{0}'", new Object[] { TextBox1.Text }).Rows.Count == 0)//如果没有这个用户名才能修改
                {
                    db.setBySql("update [user_info] set [username]='{0}' where [id]={1}", new Object[] { TextBox1.Text, id });
                    db.setBySql("update [user_info] set [password]='{0}' where [id]={1}", new Object[] { TextBox2.Text, id });
                    //数据绑定并不意味着会自动刷新Repeater1，必须自己再用代码，刷新一下Repeater1
                    Design_Repeater.DataSource = db.getBySql("select * from [user_info]");
                    Design_Repeater.DataBind();
                    Response.Write("<b>已修改！</b>");
                }
                else
                {
                    Response.Write("<b>已有该用户名！</b>");
                }
            }
        }
    }
}