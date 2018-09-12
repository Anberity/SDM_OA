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
                HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= '../Default.aspx ' </script> ");
            }
            string name = HttpContext.Current.Session["name"].ToString();
            Response.Write(" <script>window.onload=function(){ var name=document.getElementById('name'); name.innerHTML='欢迎你，" + name + "主任'} </script> ");
        }
        catch (Exception)
        {
            HttpContext.Current.Response.Write(" <script> alert( '您还未登陆，请先登录！！！');window.location.href= '../Default.aspx ' </script> ");
        }

        #region 设计工作量
        string designTableName1 = "Design";//表名1
        string designTableName2 = "Login";//表名2
        string[] designSourceList = { "Design.number", "Login.name", "Design.project_number", "Design.project_name", "Design.drawing_number", "Design.A1_number", "Design.zhehe_working_day", "Design.month_day", "Design.program_day", "Design.basic_design_day", "Design.leader", "Design.remark" };//查看列名
        string[] designSelectList = { "year", "month", "Design.username" };//限定列名
        string[] designSelectValue = { DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), "Login.username" };//限定列值

        //连接数据查看并显示在网页
        SqlCommand designCmd = st.lookSelectAll(designTableName1, designTableName2, designSourceList, designSelectList, designSelectValue);
        //if (designCmd != null)
        //{
        //    Design_Repeater.DataSource = designCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    Design_Repeater.DataBind();
        //}
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

        string[] DailyManageSourceList = { "Daily_Manage.number", "Login.name", "Daily_Manage.management", "Daily_Manage.affair_gonghui", "Daily_Manage.affair_dangzu", "Daily_Manage.affair_tuanzu", "Daily_Manage.examine", "Daily_Manage.kaoqin", "Daily_Manage.other", "Daily_Manage.remark" };//查看列名
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
            Design_Repeater.DataSource = designCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Design_Repeater.DataBind();

            //编程/画面工作量
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

    //设计工作量
    protected void Design_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString());//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox dr_number = Design_Repeater.Items[itemIndex].FindControl("dr_number") as TextBox;//获得改行的TextBox1
            TextBox dr_name = Design_Repeater.Items[itemIndex].FindControl("dr_name") as TextBox;//获得改行的TextBox2
            TextBox dr_project_number = Design_Repeater.Items[itemIndex].FindControl("dr_project_number") as TextBox;
            TextBox dr_project_name = Design_Repeater.Items[itemIndex].FindControl("dr_project_name") as TextBox;
            TextBox dr_drawing_number = Design_Repeater.Items[itemIndex].FindControl("dr_drawing_number") as TextBox;
            TextBox dr_A1_number = Design_Repeater.Items[itemIndex].FindControl("dr_A1_number") as TextBox;
            TextBox dr_zhehe_working_day = Design_Repeater.Items[itemIndex].FindControl("dr_zhehe_working_day") as TextBox;
            TextBox dr_month_day = Design_Repeater.Items[itemIndex].FindControl("dr_month_day") as TextBox;
            TextBox dr_program_day = Design_Repeater.Items[itemIndex].FindControl("dr_program_day") as TextBox;
            TextBox dr_basic_design_day = Design_Repeater.Items[itemIndex].FindControl("dr_basic_design_day") as TextBox;
            TextBox dr_leader = Design_Repeater.Items[itemIndex].FindControl("dr_leader") as TextBox;

            //获取用户名
            sqlTable st = new sqlTable();
            string[] username = new string[1];
            string tableName = "Login";
            string name = dr_name.Text.ToString();
            string[] seleList = { "username" };
            st.select_Name(name, username, tableName, seleList);

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            //新值
            float monthSum = 0;
            if (dr_month_day.Text != "")
            {
                monthSum += float.Parse(dr_month_day.Text.ToString());
            }
            if (dr_program_day.Text != "")
            {
                monthSum += float.Parse(dr_program_day.Text.ToString());
            }
            if (dr_basic_design_day.Text != "")
            {
                monthSum += float.Parse(dr_basic_design_day.Text.ToString());
            }
            if (dr_leader.Text != "")
            {
                monthSum += float.Parse(dr_leader.Text.ToString());
            }

            //查找原来日常工作量当月汇总
            string[] list5 = { "year", "month", "username", "number" };
            string[] source5 = { year, month, username[0], dr_number.Text.ToString() };
            string[] select_List1 = { "month_day" };
            string[] data1 = new string[1];
            st.select_delete("Design", data1, list5, source5, select_List1);
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

            string[] select_List2 = { "program_day" };
            string[] data2 = new string[1];
            st.select_delete("Design", data2, list5, source5, select_List2);
            if (data2[0] == "NULL" || data2[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data2[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }

            string[] select_List3 = { "basic_design_day" };
            string[] data3 = new string[1];
            st.select_delete("Design", data3, list5, source5, select_List3);
            if (data3[0] == "NULL" || data3[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data3[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }

            string[] select_List4 = { "leader" };
            string[] data4 = new string[1];
            st.select_delete("Design", data4, list5, source5, select_List4);
            if (data4[0] == "NULL" || data4[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data4[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }

            //更新列名以及数据源
            string[] list = { "project_number", "project_name", "drawing_number", "A1_number", "zhehe_working_day", "month_day", "program_day", "basic_design_day", "leader" };
            string[] source1 = { dr_project_number.Text.ToString(), dr_project_name.Text.ToString(), dr_drawing_number.Text.ToString(), dr_A1_number.Text.ToString(), dr_zhehe_working_day.Text.ToString(), dr_month_day.Text.ToString(), dr_program_day.Text.ToString(), dr_basic_design_day.Text.ToString(), dr_leader.Text.ToString() };

            //查找列名以及数据源
            string[] selectList = { "year", "month", "username", "number" };
            string[] selectSource = { year, month, username[0], dr_number.Text.ToString() };

            //插入
            int res = st.table_update("Design", list, source1, selectList, selectSource);

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
                sum = float.Parse(data[0]);
            }
            sum = sum - rest + monthSum;

            string[] list1 = { "work_day" };
            string[] source11 = { sum.ToString() };
            string[] list2 = { "year", "month", "username" };
            string[] source2 = { year, month, username[0] };
            int res1 = st.table_update("Summary", list1, source11, list2, source2);

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

    //编程/画面工作量
    protected void Programming_Picture_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString());//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox ppr_number = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_number") as TextBox;
            TextBox ppr_name = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_name") as TextBox;
            TextBox ppr_project_name = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_project_name") as TextBox;
            TextBox ppr_digital_number = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_digital_number") as TextBox;
            TextBox ppr_analog_number = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_analog_number") as TextBox;
            TextBox ppr_programing_picture = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_programing_picture") as TextBox;
            TextBox ppr_programing_day = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_programing_day") as TextBox;
            TextBox ppr_month_day = Programming_Picture_Repeater.Items[itemIndex].FindControl("ppr_month_day") as TextBox;

            //获取用户名
            sqlTable st = new sqlTable();
            string[] username = new string[1];
            string tableName = "Login";
            string name = ppr_name.Text.ToString();
            string[] seleList = { "username" };
            st.select_Name(name, username, tableName, seleList);
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            //新值
            float monthSum = 0;
            if (ppr_month_day.Text != "")
            {
                monthSum += float.Parse(ppr_month_day.Text.ToString());
            }

            //查找原来日常工作量当月汇总
            string[] list5 = { "year", "month", "username", "number" };
            string[] source5 = { year, month, username[0], ppr_number.Text.ToString() };
            string[] select_List1 = { "month_day" };
            string[] data1 = new string[1];
            st.select_delete("Programing_Picture", data1, list5, source5, select_List1);
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
            string[] list = { "project_name", "digital_number", "analog_number", "programing_picture", "programing_day", "month_day" };
            string[] source1 = { ppr_project_name.Text.ToString(), ppr_digital_number.Text.ToString(), ppr_analog_number.Text.ToString(), ppr_programing_picture.Text.ToString(), ppr_programing_day.Text.ToString(), ppr_month_day.Text.ToString() };

            //查找列名以及数据源
            string[] selectList = { "year", "month", "username", "number" };
            string[] selectSource = { year, month, username[0], ppr_number.Text.ToString() };

            //插入
            int res = st.table_update("Programing_Picture", list, source1, selectList, selectSource);

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
            sum = sum - rest + monthSum;

            string[] list1 = { "work_day" };
            string[] source11 = { sum.ToString() };
            string[] list2 = { "year", "month", "username" };
            string[] source2 = { year, month, username[0] };
            int res1 = st.table_update("Summary", list1, source11, list2, source2);

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

    //调试/工程管理工作量
    protected void Debug_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString());//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox dernumber = Debug_Repeater.Items[itemIndex].FindControl("der_number") as TextBox;
            TextBox dername = Debug_Repeater.Items[itemIndex].FindControl("der_name") as TextBox;
            TextBox derprojectname = Debug_Repeater.Items[itemIndex].FindControl("der_projectname") as TextBox;
            TextBox dersite = Debug_Repeater.Items[itemIndex].FindControl("der_site") as TextBox;
            TextBox dermanageday = Debug_Repeater.Items[itemIndex].FindControl("der_manageday") as TextBox;
            TextBox derdebugday = Debug_Repeater.Items[itemIndex].FindControl("der_debugday") as TextBox;

            //获取用户名
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
            //查找原总工日
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

    //经营工作量
    protected void Manage_Working_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString());//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox number = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_number") as TextBox;
            TextBox name = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_name") as TextBox;
            TextBox project_name = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_project_name") as TextBox;
            TextBox xunjia_baojia = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_xunjia_baojia") as TextBox;
            TextBox tender = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_tender") as TextBox;
            TextBox sign = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_sign") as TextBox;
            TextBox toubiao = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_toubiao") as TextBox;
            TextBox equip = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_equip") as TextBox;
            TextBox test = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_test") as TextBox;
            TextBox cuikuan = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_cuikuan") as TextBox;
            TextBox contract = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_contract") as TextBox;
            TextBox other = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_other") as TextBox;
            TextBox PM_day = Manage_Working_Repeater.Items[itemIndex].FindControl("MW_PM_day") as TextBox;

            //获取用户名
            sqlTable st = new sqlTable();
            string[] username = new string[1];
            string tableName = "Login";
            string trueName = name.Text.ToString();
            string[] seleList = { "username" };
            st.select_Name(trueName, username, tableName, seleList);

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            //新值
            float monthSum = 0;
            if (xunjia_baojia.Text != "")
            {
                monthSum += float.Parse(xunjia_baojia.Text.ToString());
            }
            if (tender.Text != "")
            {
                monthSum += float.Parse(tender.Text.ToString());
            }
            if (sign.Text != "")
            {
                monthSum += float.Parse(sign.Text.ToString());
            }
            if (toubiao.Text != "")
            {
                monthSum += float.Parse(toubiao.Text.ToString());
            }
            if (equip.Text != "")
            {
                monthSum += float.Parse(equip.Text.ToString());
            }
            if (test.Text != "")
            {
                monthSum += float.Parse(test.Text.ToString());
            }
            if (cuikuan.Text != "")
            {
                monthSum += float.Parse(cuikuan.Text.ToString());
            }
            if (contract.Text != "")
            {
                monthSum += float.Parse(contract.Text.ToString());
            }
            if (other.Text != "")
            {
                monthSum += float.Parse(other.Text.ToString());
            }
            if (PM_day.Text != "")
            {
                monthSum += float.Parse(PM_day.Text.ToString());
            }

            //查找原来日常工作量当月汇总
            string[] list5 = { "year", "month", "username", "number" };
            string[] source5 = { year, month, username[0], number.Text.ToString() };
            string[] select_List1 = { "xunjia_baojia" };
            string[] data1 = new string[1];
            st.select_delete("Manage_Working", data1, list5, source5, select_List1);

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
            string[] select_List2 = { "tender" };
            string[] data2 = new string[1];
            st.select_delete("Manage_Working", data2, list5, source5, select_List2);
            if (data2[0] == "NULL" || data2[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data2[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            string[] select_List3 = { "sign" };
            string[] data3 = new string[1];
            st.select_delete("Manage_Working", data3, list5, source5, select_List3);
            if (data3[0] == "NULL" || data3[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data3[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }

            string[] select_List4 = { "toubiao" };
            string[] data4 = new string[1];
            st.select_delete("Manage_Working", data4, list5, source5, select_List4);
            if (data4[0] == "NULL" || data4[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data4[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }


            string[] select_List5 = { "equip" };
            string[] data5 = new string[1];
            st.select_delete("Manage_Working", data5, list5, source5, select_List5);
            if (data5[0] == "NULL" || data5[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data5[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }

            string[] select_List6 = { "test" };
            string[] data6 = new string[1];
            st.select_delete("Manage_Working", data6, list5, source5, select_List6);
            if (data6[0] == "NULL" || data6[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data6[0]);
                }
                catch (Exception)
                {
                    rest += 0;
                }
            }

            string[] select_List7 = { "cuikuan" };
            string[] data7 = new string[1];
            st.select_delete("Manage_Working", data7, list5, source5, select_List7);
            if (data7[0] == "NULL" || data7[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data7[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            string[] select_List8 = { "contract" };
            string[] data8 = new string[1];
            st.select_delete("Manage_Working", data8, list5, source5, select_List8);
            if (data8[0] == "NULL" || data8[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data8[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            string[] select_List9 = { "other" };
            string[] data9 = new string[1];
            st.select_delete("Manage_Working", data9, list5, source5, select_List9);
            if (data9[0] == "NULL" || data9[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data9[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            string[] select_List10 = { "PM_day" };
            string[] data10 = new string[1];
            st.select_delete("Manage_Working", data10, list5, source5, select_List10);
            if (data10[0] == "NULL" || data10[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data10[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            //更新列名以及数据源
            string[] list = { "project_name", "xunjia_baojia", "tender", "sign", "toubiao", "equip", "test", "cuikuan", "contract", "other", "PM_day" };
            string[] source11 = { project_name.Text.ToString(), xunjia_baojia.Text.ToString(), tender.Text.ToString(), sign.Text.ToString(), toubiao.Text.ToString(), equip.Text.ToString(), test.Text.ToString(), cuikuan.Text.ToString(), contract.Text.ToString(), other.Text.ToString(), PM_day.Text.ToString() };

            //查找列名以及数据源
            string[] selectList = { "year", "month", "username", "number" };
            string[] selectSource = { year, month, username[0], number.Text.ToString() };

            //插入
            int res = st.table_update("Manage_Working", list, source11, selectList, selectSource);

            //更新本月总工日
            //查找原总工日
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
                sum = float.Parse(data[0]);
            }
            sum = sum - rest + monthSum;
            string[] list1 = { "work_day" };
            string[] source1 = { sum.ToString() };
            string[] list2 = { "year", "month", "username" };
            string[] source2 = { year, month, username[0] };
            int res1 = st.table_update("Summary", list1, source1, list2, source2);

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

    //日常管理工作量
    protected void Daily_Manage_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString());//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox number = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_number") as TextBox;
            TextBox name = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_name") as TextBox;
            TextBox management = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_management") as TextBox;
            TextBox affair_gonghui = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_affair_gonghui") as TextBox;
            TextBox affair_dangzu = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_affair_dangzu") as TextBox;
            TextBox affair_tuanzu = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_affair_tuanzu") as TextBox;
            TextBox examine = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_examine") as TextBox;
            TextBox kaoqin = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_kaoqin") as TextBox;
            TextBox other = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_other") as TextBox;
            TextBox month_day = Daily_Manage_Repeater.Items[itemIndex].FindControl("DM_month_day") as TextBox;

            //获取用户名
            sqlTable st = new sqlTable();
            string[] username = new string[1];
            string tableName = "Login";
            string trueName = name.Text.ToString();
            string[] seleList = { "username" };
            st.select_Name(trueName, username, tableName, seleList);

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            //查找原来日常工作量当月汇总
            string[] list5 = { "year", "month", "username", "number" };
            string[] source5 = { year, month, username[0], number.Text.ToString() };
            string[] select_List1 = { "month_day" };
            string[] data1 = new string[1];
            st.select_delete("Daily_Manage", data1, list5, source5, select_List1);
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

            //当月总工日汇总
            float monthSum = 0;//修改汇总

            if (management.Text != "")
            {
                monthSum += float.Parse(management.Text.ToString());
            }
            if (affair_gonghui.Text != "")
            {
                monthSum += float.Parse(affair_gonghui.Text.ToString());
            }
            if (affair_dangzu.Text != "")
            {
                monthSum += float.Parse(affair_dangzu.Text.ToString());
            }
            if (affair_tuanzu.Text != "")
            {
                monthSum += float.Parse(affair_tuanzu.Text.ToString());
            }
            if (examine.Text != "")
            {
                monthSum += float.Parse(examine.Text.ToString());
            }
            if (kaoqin.Text != "")
            {
                monthSum += float.Parse(kaoqin.Text.ToString());
            }
            if (other.Text != "")
            {
                monthSum += float.Parse(other.Text.ToString());
            }

            //更新列名以及数据源
            string[] list = { "management", "affair_gonghui", "affair_dangzu", "affair_tuanzu", "examine", "kaoqin", "other", "month_day" };
            string[] source11 = { management.Text.ToString(), affair_gonghui.Text.ToString(), affair_dangzu.Text.ToString(), affair_tuanzu.Text.ToString(), examine.Text.ToString(), kaoqin.Text.ToString(), other.Text.ToString(), monthSum.ToString() };

            //查找列名以及数据源
            string[] selectList = { "year", "month", "username", "number" };
            string[] selectSource = { year, month, username[0], number.Text.ToString() };

            //插入
            int res = st.table_update("Daily_Manage", list, source11, selectList, selectSource);

            //更新本月总工日
            //查找原总工日
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
                sum = int.Parse(data[0]);
            }
            sum = sum - rest + monthSum;

            string[] list1 = { "work_day" };
            string[] source1 = { sum.ToString() };
            string[] list2 = { "year", "month", "username" };
            string[] source2 = { year, month, username[0] };
            int res1 = st.table_update("Summary", list1, source1, list2, source2);
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

    //零星工日
    protected void LingXing_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "confirm")//如果点击的是被标记为CommandName="del"的按钮，也就是确认按钮
        {
            int itemIndex = int.Parse(e.CommandArgument.ToString());//藏在CommandArgument='<%#Eval("id")+","+(Container as RepeaterItem).ItemIndex%>'逗号后面的参数就是该行行号
            TextBox number = LingXing_Repeater.Items[itemIndex].FindControl("LX_number") as TextBox;
            TextBox name = LingXing_Repeater.Items[itemIndex].FindControl("LX_name") as TextBox;
            TextBox chuchai_day = LingXing_Repeater.Items[itemIndex].FindControl("LX_chuchai_day") as TextBox;
            TextBox jiaoliu_day = LingXing_Repeater.Items[itemIndex].FindControl("LX_jiaoliu_day") as TextBox;
            TextBox other_day = LingXing_Repeater.Items[itemIndex].FindControl("LX_other_day") as TextBox;

            //获取用户名
            sqlTable st = new sqlTable();
            string[] username = new string[1];
            string tableName = "Login";
            string trueName = name.Text.ToString();
            string[] seleList = { "username" };
            st.select_Name(trueName, username, tableName, seleList);

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            float monthSum = 0;
            if (chuchai_day.Text != "")
            {
                monthSum += float.Parse(chuchai_day.Text.ToString());
            }
            if (jiaoliu_day.Text != "")
            {
                monthSum += float.Parse(jiaoliu_day.Text.ToString());
            }
            if (other_day.Text != "")
            {
                monthSum += float.Parse(other_day.Text.ToString());
            }

            //查找原来日常工作量当月汇总
            string[] list5 = { "year", "month", "username", "number" };
            string[] source5 = { year, month, username[0], number.Text.ToString() };
            string[] select_List1 = { "chuchai_day" };
            string[] data1 = new string[1];
            st.select_delete("LingXing", data1, list5, source5, select_List1);
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
            string[] select_List2 = { "jiaoliu_day" };
            string[] data2 = new string[1];
            st.select_delete("LingXing", data2, list5, source5, select_List2);
            if (data2[0] == "NULL" || data2[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data2[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            string[] select_List3 = { "other_day" };
            string[] data3 = new string[1];
            st.select_delete("LingXing", data3, list5, source5, select_List3);
            if (data3[0] == "NULL" || data3[0] == "")
            {
            }
            else
            {
                try
                {
                    rest += float.Parse(data3[0]);
                }
                catch (Exception)
                {

                    rest += 0;
                }
            }

            //更新列名以及数据源
            string[] list = { "chuchai_day", "jiaoliu_day", "other_day" };
            string[] source11 = { chuchai_day.Text.ToString(), jiaoliu_day.Text.ToString(), other_day.Text.ToString() };

            //查找列名以及数据源
            string[] selectList = { "year", "month", "username", "number" };
            string[] selectSource = { year, month, username[0], number.Text.ToString() };

            //插入
            int res = st.table_update("LingXing", list, source11, selectList, selectSource);

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
                sum = float.Parse(data[0]);
            }
            sum = sum - rest + monthSum;

            string[] list1 = { "work_day" };
            string[] source1 = { sum.ToString() };
            string[] list2 = { "year", "month", "username" };
            string[] source2 = { year, month, username[0] };
            int res1 = st.table_update("Summary", list1, source1, list2, source2);

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

    //注销
    protected void logout_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Session["power"] = "null";//权限
        HttpContext.Current.Session["username"] = "null";//获取用户名
        HttpContext.Current.Session["userpwd"] = "null";//获取密码
        HttpContext.Current.Session["name"] = "null";//获取用户名字
        HttpContext.Current.Session["team"] = "null";//获取用户小组
        HttpContext.Current.Session["yearh"] = DateTime.Now.Year.ToString();//历史年份
        HttpContext.Current.Session["monh"] = DateTime.Now.Month.ToString();//历史月份
        HttpContext.Current.Session["months"] = DateTime.Now.Month.ToString();//汇总查看月份
        HttpContext.Current.Session["years"] = DateTime.Now.Month.ToString();//汇总查看年份
        HttpContext.Current.Session["yearuser"] = DateTime.Now.Month.ToString();//按年查看员工汇总
        HttpContext.Current.Session["numberMonth"] = "0";//月份汇总
        HttpContext.Current.Session["numberYear"] = "0";//年份汇总
        HttpContext.Current.Session["userYear"] = "0";//员工年份汇总
        HttpContext.Current.Response.Write(" <script>window.location.href= '../Default.aspx' </script> ");
    }
}