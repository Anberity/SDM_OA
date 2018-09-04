using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_allperson : System.Web.UI.Page
{
    Look st = new Look();
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


        #region 设计工作量
        string designTableName1 = "Design";//表名1
        string designTableName2 = "Login";//表名2
        string[] designSourceList = { "Design.number", "Login.name", "Design.project_number", "Design.project_name", "Design.drawing_number", "Design.A1_number", "Design.zhehe_working_day", "Design.month_day", "Design.program_day", "Design.basic_design_day", "Design.leader", "Design.remark" };//查看列名
        string[] designSelectList = { "year", "month", "Design.username" };//限定列名
        string[] designSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand designCmd = st.lookSelectAll(designTableName1, designTableName2, designSourceList, designSelectList, designSelectValue);
        if (designCmd != null)
        {
            Design_Repeater.DataSource = designCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Design_Repeater.DataBind();
        }
        #endregion

        #region 编程/画面工作量
        string programTableName1 = "Programing_Picture";//表名1
        string programTableName2 = "Login";//表名2
        string[] programSourceList = { "Programing_Picture.number", "Login.name", "Programing_Picture.project_name", "Programing_Picture.digital_number", "Programing_Picture.analog_number", "Programing_Picture.programing_picture", "Programing_Picture.programing_day", "Programing_Picture.month_day", "Programing_Picture.remark" };//查看列名
        string[] programSelectList = { "year", "month", "Programing_Picture.username" };//限定列名
        string[] programSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand programCmd = st.lookSelectAll(programTableName1, programTableName2, programSourceList, programSelectList, programSelectValue);
        //if (programCmd != null)
        //{
        //    Programming_Picture_Repeater.DataSource = programCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    Programming_Picture_Repeater.DataBind();
        //}
        #endregion

        #region 调试/工程管理工作量
        string debugTableName1 = "Debug";//表名1
        string debugTableName2 = "Login";//表名2
        string[] debugSourceList = { "Debug.number", "Login.name", "Debug.projectname", "Debug.site", "Debug.manageday", "Debug.debugday", "Debug.remark" };//查看列名
        string[] debugSelectList = { "year", "month", "Debug.username" };//限定列名
        string[] debugSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand debugCmd = st.lookSelectAll(debugTableName1, debugTableName2, debugSourceList, debugSelectList, debugSelectValue);
        //if (debugCmd != null)
        //{
        //    Debug_Repeater.DataSource = debugCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    Debug_Repeater.DataBind();
        //}
        #endregion

        #region 经营工作量
        string manageWorkingTableName1 = "Manage_Working";//表名1
        string manageWorkingTableName2 = "Login";//表名2
        string[] manageWorkingSourceList = { "Manage_Working.number", "Login.name", "Manage_Working.project_name", "Manage_Working.xunjia_baojia", "Manage_Working.tender", "Manage_Working.sign", "Manage_Working.toubiao", "Manage_Working.equip", "Manage_Working.test", "Manage_Working.cuikuan", "Manage_Working.contract", "Manage_Working.other", "Manage_Working.PM_day", "Manage_Working.remark" };//查看列名
        string[] manageWorkingSelectList = { "year", "month", "Manage_Working.username" };//限定列名
        string[] manageWorkingSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand manageWorkingCmd = st.lookSelectAll(manageWorkingTableName1, manageWorkingTableName2, manageWorkingSourceList, manageWorkingSelectList, manageWorkingSelectValue);
        //if (manageWorkingCmd != null)
        //{
        //    Manage_Working_Repeater.DataSource = manageWorkingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    Manage_Working_Repeater.DataBind();
        //}
        #endregion

        #region 日常管理工作量
        string DailyManageTableName1 = "Daily_Manage";//表名1
        string DailyManageTableName2 = "Login";//表名2

        string[] DailyManageSourceList = { "Daily_Manage.number", "Login.name", "Daily_Manage.management", "Daily_Manage.affair_gonghui", "Daily_Manage.affair_dangzu", "Daily_Manage.affair_tuanzu", "Daily_Manage.examine", "Daily_Manage.kaoqin", "Daily_Manage.other", "Daily_Manage.month_day", "Daily_Manage.remark" };//查看列名
        string[] DailyManageSelectList = { "year", "month", "Daily_Manage.username" };//限定列名
        string[] DailyManageSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand DailyManageCmd = st.lookSelectAll(DailyManageTableName1, DailyManageTableName2, DailyManageSourceList, DailyManageSelectList, DailyManageSelectValue);
        //if (DailyManageCmd != null)
        //{
        //    Daily_Manage_Repeater.DataSource = DailyManageCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    Daily_Manage_Repeater.DataBind();
        //}
        #endregion

        #region 零星工日
        string lingXingTableName1 = "LingXing";//表名1
        string lingXingTableName2 = "Login";//表名2

        string[] lingXingSourceList = { "LingXing.number", "Login.name", "LingXing.chuchai_day", "LingXing.jiaoliu_day", "LingXing.other_day", "LingXing.remark" };//查看列名
        string[] lingXingSelectList = { "year", "month", "LingXing.username" };//限定列名
        string[] lingXingSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand lingXingCmd = st.lookSelectAll(lingXingTableName1, lingXingTableName2, lingXingSourceList, lingXingSelectList, lingXingSelectValue);
        //if (lingXingCmd != null)
        //{
        //    LingXing_Repeater.DataSource = lingXingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    LingXing_Repeater.DataBind();
        //}
        #endregion

        #region 本月工日之和
        string summaryTableName1 = "Summary";//表名
        string summaryTableName2 = "Login";//表名2

        string[] summarySourceList = { "Summary.work_day", "Login.name" };//查看列名
        string[] summarySelectList = { "year", "month", "Summary.username" };//限定列名
        string[] summarySelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand summaryCmd = st.lookSelectAll(summaryTableName1, summaryTableName2, summarySourceList, summarySelectList, summarySelectValue);
        //if (summaryCmd != null)
        //{
        //    Summary_Repeater.DataSource = summaryCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    Summary_Repeater.DataBind();
        //}
        #endregion

        if (!Page.IsPostBack)//必须有，规定数据不能多次被绑定。
        {
            //设计工作量
            Programming_Picture_Repeater.DataSource = programCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Programming_Picture_Repeater.DataBind();

            //调试/工程管理工作量
            Debug_Repeater.DataSource = debugCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Debug_Repeater.DataBind();

            //经营工作量
            Manage_Working_Repeater.DataSource = manageWorkingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Manage_Working_Repeater.DataBind();

            //日常管理工作量
            Daily_Manage_Repeater.DataSource = DailyManageCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Daily_Manage_Repeater.DataBind();

            //零星工日
            LingXing_Repeater.DataSource = lingXingCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            LingXing_Repeater.DataBind();

            //本月工日之和
            Summary_Repeater.DataSource = summaryCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Summary_Repeater.DataBind();

        }





    }

    protected void close_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();</script>");
    }

    protected void Design_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int id = int.Parse(e.CommandArgument.ToString().Split(',')[0]);//这里还真必须用单引号来表示字符，而不是""的字符串~，C#的Split就一个以字符，而不是字符串参数的代码
            int itemIndex = int.Parse(e.CommandArgument.ToString().Split(',')[1]);//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号

            #region Design_Repeater 简称 dr_
            TextBox dr_number = Design_Repeater.Items[itemIndex].FindControl("number") as TextBox;//获得改行的TextBox1
            TextBox dr_name = Design_Repeater.Items[itemIndex].FindControl("name") as TextBox;//获得改行的TextBox2
            TextBox dr_project_number = Design_Repeater.Items[itemIndex].FindControl("project_number") as TextBox;
            TextBox dr_project_name = Design_Repeater.Items[itemIndex].FindControl("project_name") as TextBox;
            TextBox dr_drawing_number = Design_Repeater.Items[itemIndex].FindControl("drawing_number") as TextBox;
            TextBox dr_A1_number = Design_Repeater.Items[itemIndex].FindControl("A1_number") as TextBox;
            TextBox dr_zhehe_working_day = Design_Repeater.Items[itemIndex].FindControl("zhehe_working_day") as TextBox;
            TextBox dr_month_day = Design_Repeater.Items[itemIndex].FindControl("month_day") as TextBox;
            TextBox dr_program_day = Design_Repeater.Items[itemIndex].FindControl("program_day") as TextBox;
            TextBox dr_basic_design_day = Design_Repeater.Items[itemIndex].FindControl("basic_design_day") as TextBox;
            TextBox dr_leader = Design_Repeater.Items[itemIndex].FindControl("leader") as TextBox;
            #endregion

            #region MyRegion Programming_Picture_Repeater 简称ppr_
            TextBox ppr_number = Programming_Picture_Repeater.Items[itemIndex].FindControl("number") as TextBox;
            TextBox ppr_name = Programming_Picture_Repeater.Items[itemIndex].FindControl("name") as TextBox;
            TextBox ppr_project_name = Programming_Picture_Repeater.Items[itemIndex].FindControl("project_name") as TextBox;
            TextBox ppr_digital_number = Programming_Picture_Repeater.Items[itemIndex].FindControl("digital_number") as TextBox;
            TextBox ppr_analog_number = Programming_Picture_Repeater.Items[itemIndex].FindControl("analog_number") as TextBox;
            TextBox ppr_programing_picture = Programming_Picture_Repeater.Items[itemIndex].FindControl("programing_picture") as TextBox;
            TextBox ppr_programing_day = Programming_Picture_Repeater.Items[itemIndex].FindControl("programing_day") as TextBox;
            TextBox ppr_month_day = Programming_Picture_Repeater.Items[itemIndex].FindControl("month_day") as TextBox;
            #endregion

            //这里是修改数据库表的一般逻辑，不赘述了
            /*if (TextBox1.Text.Trim().Equals("") || TextBox2.Text.Trim().Equals(""))
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
            }*/
        }
    }

    protected void Debug_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString().Split(',')[1]);//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox dernumber = Debug_Repeater.Items[itemIndex].FindControl("der_number") as TextBox;
            TextBox dername = Debug_Repeater.Items[itemIndex].FindControl("der_name") as TextBox;
            TextBox derprojectname = Debug_Repeater.Items[itemIndex].FindControl("der_projectname") as TextBox;
            TextBox dersite = Debug_Repeater.Items[itemIndex].FindControl("der_site") as TextBox;
            TextBox dermanageday = Debug_Repeater.Items[itemIndex].FindControl("der_manageday") as TextBox;
            TextBox derdebugday = Debug_Repeater.Items[itemIndex].FindControl("der_debugday") as TextBox;

            //更新原来日常工作量当月汇总
            sqlTable st = new sqlTable();
            string[] username = new string[1];
            string tableName = "Login";
            string name = dername.Text.ToString();
            string[] seleList = { "username" };
            st.select_Name(name, username, tableName, seleList);

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            string[] list5 = { "year", "month", "username", "number" };
            string[] source5 = { year, month, username[0], dernumber.Text.ToString() };
            string[] select_List1 = { "debugday" };
            string[] data1 = new string[1];
            st.select_delete("Debug", data1, list5, source5, select_List1);
            float rest = 0;//原来的值
            if (data1[0] == "NULL" || data1[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data1[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            //更新列名以及数据源
            string[] list1 = { "projectname", "site", "manageday", "debugday" };
            string[] source1 = { derprojectname.Text.ToString(), dersite.Text.ToString(), dermanageday.Text.ToString(), derdebugday.Text.ToString() };

            //查找列名以及数据源
            string[] selectList = { "year", "month", "username", "number" };
            string[] selectSource = { year, month, username[0], dernumber.Text.ToString() };

            int res = st.table_update("Debug", list1, source1, selectList, selectSource);

            //更新本月总工日
            //查找原总工时
            string[] list4 = { "year", "month", "username" };
            string[] source4 = { year, month, username[0] };
            string[] select_List = { "work_day" };
            string[] data = new string[1];
            st.select_delete("Summary", data, list4, source4, select_List);
            float sum = 0;
            if (data[0] == "NULL" || data[0] == "")
            {
            }
            else
            {
                sum += float.Parse(data[0]);
            }
            sum = sum - rest + float.Parse(derdebugday.Text.ToString());
            string[] list2 = { "work_day" };
            string[] source2 = { sum.ToString() };
            string[] list3 = { "year", "month", "username" };
            string[] source3 = { year, month, username[0] };
            int res1 = st.table_update("Summary", list2, source2, list3, source3);


            if (res == 1 && res1 == 1)
            {
                Response.Write("<script>alert('成功')</script>");
            }
            else if (res == 0 || res1 == 0)
            {
                Response.Write("<script>alert('输入有误，请重新输入')</script>");
            }
            else if (res == 2 || res1 == 2)
            {
                Response.Write("<script>alert('语法错误')</script>");
            }
        }
    }
}