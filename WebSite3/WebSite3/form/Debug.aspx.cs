using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //增加事件
    protected void submit_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();
        int number = 0;//填写序号
        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();
        string team = HttpContext.Current.Session["team"].ToString();

        //网页输入
        string New_add_engineName = add_engineName.Text.Trim();//项目名称
        string New_add_enginePlace = add_enginePlace.Text.Trim();//项目地点
        string New_add_manageDays = add_manageDays.Text.Trim();//本月工程管理天数
        string New_add_debugDays = add_debugDays.Text.Trim();//本月调试天数
        string New_add_remarks = add_remarks.Text.Trim();//备注

        //number在原有基础上加1
        string list1 = "number";
        string[] value = new string[1];
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture" };

        st.select_number(list1, value, tableName, year, month, username);
        if (value[0] != "")
        {
            number = int.Parse(value[0]) + 1;
        }
        else
        {
            number = 1;
        }
        //列名以及数据源
        string[] list = { "year", "month", "username", "team", "number", "projectname", "site", "manageday", "debugday", "remark" };
        string[] source = { year, month, username, team, number.ToString(), New_add_engineName, New_add_enginePlace, New_add_manageDays, New_add_debugDays, New_add_remarks };

        //插入
        int res = st.table_insert("Debug", list, source);

        //更新本月总工日
        //查找列名以及数据源
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
        string[] select_List = { "work_day" };
        string[] data = new string[1];
        st.select_delete("Summary", data, list4, source4, select_List);
        float sum = 0;
        if (data[0] == "NULL")
        {
            sum = 0;
            string[] suList = { "year", "month", "username", "team", "work_day" };
            string[] suSource = { year, month, username, team, sum.ToString() };
            st.table_insert("Summary", suList, suSource);
        }
        else
        {
            sum = float.Parse(data[0]);
        }
        if (add_debugDays.Text != "")
        {
            sum += float.Parse(New_add_debugDays);
        }
        string[] list2 = { "work_day" };
        string[] source2 = { sum.ToString() };
        string[] list3 = { "year", "month", "username" };
        string[] source3 = { year, month, username };
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

    //修改事件
    protected void modifybtn_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_index = add_index.Text.Trim(); // 索引
        String New_add_engineName = add_engineName.Text.Trim();//项目名称
        String New_add_enginePlace = add_enginePlace.Text.Trim();//项目地点
        String New_add_manageDays = add_manageDays.Text.Trim();//本月工程管理天数
        String New_add_debugDays = add_debugDays.Text.Trim();//本月调试天数
        String New_add_remarks = add_remarks.Text.Trim();//备注

        //查找原来日常工作量当月汇总
        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        string[] select_List1 = { "debugday" };
        string[] data1 = new string[1];
        st.select_delete("Debug", data1, list5, source5, select_List1);
        float rest = 0;//原来的值
        if (data1[0] == "NULL" || data1[0] == "")
        {
        }
        else
        {
            rest += float.Parse(data1[0]);
        }

        //更新列名以及数据源
        string[] list = { "projectname", "site", "manageday", "debugday", "remark" };
        string[] source = { New_add_engineName, New_add_enginePlace, New_add_manageDays, New_add_debugDays, New_add_remarks };

        //查找列名以及数据源
        string[] selectList = { "year", "month", "username", "number" };
        string[] selectSource = { year, month, username, New_add_index };

        int res = st.table_update("Debug", list, source, selectList, selectSource);

        //更新本月总工日
        //查找原总工时
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
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
        sum = sum - rest + float.Parse(New_add_debugDays);
        string[] list1 = { "work_day" };
        string[] source1 = { sum.ToString() };
        string[] list2 = { "year", "month", "username" };
        string[] source2 = { year, month, username };
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

    //删除事件
    protected void delete_Click(object sender, EventArgs e)
    {
        sqlTable st = new sqlTable();

        //获取年月日以及用户名，小组
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string username = HttpContext.Current.Session["username"].ToString();

        //网页输入
        string New_add_index = add_index.Text.Trim(); //添加索引

        //查找原来日常工作量当月汇总
        string[] list = { "year", "month", "username", "number" };
        string[] source = { year, month, username, New_add_index };
        string[] select_List = { "debugday" };
        string[] data = new string[1];
        st.select_delete("Debug", data, list, source, select_List);
        float rest = 0;//原来的值
        if (data[0] == "NULL" || data[0] == "")
        {
        }
        else
        {
            rest += float.Parse(data[0]);
        }

        //查找原总工时
        string[] list2 = { "year", "month", "username" };
        string[] source2 = { year, month, username };
        string[] select_List2 = { "work_day" };
        string[] data2 = new string[1];
        st.select_delete("Summary", data2, list2, source2, select_List2);
        float sum = 0;
        if (data2[0] == "NULL" || data2[0] == "")
        {
        }
        else
        {
            sum += float.Parse(data2[0]);
        }

        sum -= rest;

        //更新总工时
        string[] list3 = { "work_day" };
        string[] source3 = { sum.ToString() };
        string[] list4 = { "year", "month", "username" };
        string[] source4 = { year, month, username };
        int res = st.table_update("Summary", list3, source3, list4, source4);

        string[] list5 = { "year", "month", "username", "number" };
        string[] source5 = { year, month, username, New_add_index };
        int res1 = st.table_delete("Debug", list5, source5);


        #region 修改number值
        //SELECT * FROM OA.dbo.Debug WHERE year='2018' AND month='8' AND username='zdhhyz' AND CAST(number as int)>2 ORDER BY CAST(number as int) ASC
        //update [OA].[dbo].[Debug]set number='13' where year='2018' and month='8' and username = 'zdhhyz' and number='12'
        string[] tableName = { "Daily_Manage", "Debug", "Design", "LingXing", "Manage_Working", "Programing_Picture" };
        string[] columns = { "number" };
        String[,] temp = new String[30, 1];
        String[,] temp1 = new String[30, 1];
        for (int j = 0; j < temp.Length; j++)
        {
            temp[j, 0] = null;
        }
        for (int k = 0; k < tableName.Length; k++)
        {
            st.page_flash(temp, tableName[k], columns);//tableName[i]
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                if (temp[i, 0] == null)
                {
                    break;
                }
                if (int.Parse(temp[i, 0]) > int.Parse(New_add_index))
                {
                    temp1[i, 0] = temp[i, 0];
                    temp[i, 0] = (int.Parse(temp[i, 0]) - 1).ToString();
                    string[] temp2 = new string[1];
                    temp2[0] = temp[i, 0];
                    string[] upsource = { year, month, username, temp1[i, 0] };
                    st.table_update(tableName[k], columns, temp2, list5, upsource);
                }
            }
        }
        #endregion

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