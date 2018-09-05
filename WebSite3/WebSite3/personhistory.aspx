﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="personhistory.aspx.cs" Inherits="personhistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel='stylesheet prefetch' href='www/css/reset.css' />
    <link rel="stylesheet" type="text/css" href="www/css/default.css" />
    <link rel='stylesheet prefetch' href='https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700,900|Material+Icons' />
    <link rel="stylesheet" type="text/css" href="www/css/styles.css" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/jedate.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.js"></script>
    <link href="www/table.css" rel="stylesheet" />
    <!--[if IE]>
		<script src="http://libs.baidu.com/html5shiv/3.7/html5shiv.min.js"></script>
	<![endif]-->
    <style>
        .timebox {
            margin: 20px auto;
            width: 600px;
        }

        .btn-success, .btn-danger {
            margin-left: 30px;
        }

        .tabs {
            margin-top: 30px;
        }

        #submit {
            height: 38px;
        }
        .welcome{
            position:absolute;
            right:50px;
            top:20px;
        }
    </style>
</head>
<body>
    <form id="form" runat="server">
        <div class="welcome">
            <p>欢迎你，xxx</p>
            <asp:Button Text="注销" runat="server" ID="logout" OnClick="logout_Click" />
        </div>
        <h1 class="logo"><img src="www/img/logo.png" /></h1>
        <div class="timebox">
            <asp:TextBox runat="server" class="workinput wicon" ID="date" />
            <asp:Button runat="server" ID="submit" Text="确定" type="button" class="btn btn-primary" OnClick="submit_Click" />
            <asp:Button runat="server" ID="close" Text="关闭" type="button" class="btn btn-danger" OnClick="close_Click" />
        </div>

        <article class="htmleaf-container">
            <div class="tabs">
                <div class="tabs-header">
                    <div class="border"></div>
                    <ul>
                        <li class="active"><a href="#tab-1" tab-id="1" ripple="ripple" ripple-color="#FFF">设计工作量</a></li>
                        <li><a href="#tab-2" tab-id="2" ripple="ripple" ripple-color="#FFF">编程/画面工作量</a></li>
                        <li><a href="#tab-3" tab-id="3" ripple="ripple" ripple-color="#FFF">调试/工程管理工作量</a></li>
                        <li><a href="#tab-4" tab-id="4" ripple="ripple" ripple-color="#FFF">经营工作量</a></li>
                        <li><a href="#tab-5" tab-id="5" ripple="ripple" ripple-color="#FFF">日常管理工作量</a></li>
                        <li><a href="#tab-6" tab-id="6" ripple="ripple" ripple-color="#FFF">零星工日</a></li>
                        <li><a href="#tab-7" tab-id="7" ripple="ripple" ripple-color="#FFF">本月工日之和</a></li>
                    </ul>
                    <nav class="tabs-nav"><i id="prev" ripple="ripple" ripple-color="#FFF" class="material-icons">&#xE314;</i><i id="next" ripple="ripple" ripple-color="#FFF" class="material-icons">&#xE315;</i></nav>
                </div>
                <div class="tabs-content">
                    <div tab-id="1" class="tab active form">
                        <asp:Repeater ID="Design_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>序号</td>
                                        <td>工程号</td>
                                        <td class="projectname">工程名称</td>
                                        <td>
                                            <div>施工图</div>
                                            <div>图纸张数</div>
                                        </td>
                                        <td>
                                            <div>施工图</div>
                                            <div>折合A1</div>
                                           
                                        </td>
                                        <td>
                                            <div>施工图</div>
                                            <div>折合总工日</div>
                                            
                                        </td>
                                        <td>
                                            <div>本月完成</div>
                                            <div>工日</div>        
                                        </td>
                                        <td>
                                            <div>技术方案</div>
                                            <div>（工日）</div>
                                        </td>
                                        <td>
                                            <div>基本设计</div>
                                            <div>（工日）</div>
                                        </td>
                                        <td>
                                            <div>专业负责人</div>
                                            <div>（工日）</div>
                                        </td>
                                        <td class="remarks">备注</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("number") %></td>
                                    <td><%#Eval("project_number") %></td>
                                    <td><%#Eval("project_name") %></td>
                                    <td><%#Eval("drawing_number") %></td>
                                    <td><%#Eval("A1_number") %></td>
                                    <td><%#Eval("zhehe_working_day") %></td>
                                    <td><%#Eval("month_day") %></td>
                                    <td><%#Eval("program_day") %></td>
                                    <td><%#Eval("basic_design_day") %></td>
                                    <td><%#Eval("leader") %></td>
                                    <td><%#Eval("remark") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div tab-id="2" class="tab form">
                        <asp:Repeater ID="Programming_Picture_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>序号</td>
                                        <td>项目名称</td>
                                        <td>总开关量点数</td>
                                        <td>总模拟量点数</td>
                                        <td>编程/画面</td>
                                        <td>总工日</td>
                                        <td>本月完成工日</td>
                                        <td class="remarks">备注</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("number") %></td>
                                    <td><%#Eval("project_name") %></td>
                                    <td><%#Eval("digital_number") %></td>
                                    <td><%#Eval("analog_number") %></td>
                                    <td><%#Eval("programing_picture") %></td>
                                    <td><%#Eval("programing_day") %></td>
                                    <td><%#Eval("month_day") %></td>
                                    <td><%#Eval("remark") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div tab-id="3" class="tab form">
                        <asp:Repeater ID="Debug_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>序号</td>
                                        <td>项目名称</td>
                                        <td>项目地点</td>
                                        <td>
                                            <div>工程管理</div>
                                            <div>（工日）</div>

                                        </td>
                                        <td>
                                            <div>调试</div>
                                            <div>（工日）</div>

                                        </td>
                                        <td class="remarks">备注</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("number") %></td>
                                    <td><%#Eval("projectname") %></td>
                                    <td><%#Eval("site") %></td>
                                    <td><%#Eval("manageday") %></td>
                                    <td><%#Eval("debugday") %></td>
                                    <td><%#Eval("remark") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div tab-id="4" class="tab form tab4">
                        <asp:Repeater ID="Manage_Working_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>序号</td>
                                        <td>项目名称</td>
                                        <td>
                                            <div>商务询价</div>
                                            <div>报价</div>
                                            

                                        </td>
                                        <td>标书制作</td>
                                        <td>
                                            <div>合同制作</div>
                                            <div>与签署</div>
                                        </td>
                                        <td>投标</td>
                                        <td>
                                            <div>设备招标</div>
                                            <div>采购</div> 
                                        </td>
                                        <td>
                                            <div>设备出厂</div>
                                            <div>检测</div>
                                        </td>
                                        <td>催款</td>
                                        <td>合同管理</td>
                                        <td>其他</td>
                                        <td>
                                            <div>项目经理</div>
                                            <div>（工日）</div>
                                        </td>
                                        <td class="remarks">备注</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("number") %></td>
                                    <td><%#Eval("project_name") %></td>
                                    <td><%#Eval("xunjia_baojia") %></td>
                                    <td><%#Eval("tender") %></td>
                                    <td><%#Eval("sign") %></td>
                                    <td><%#Eval("toubiao") %></td>
                                    <td><%#Eval("equip") %></td>
                                    <td><%#Eval("test") %></td>
                                    <td><%#Eval("cuikuan") %></td>
                                    <td><%#Eval("contract") %></td>
                                    <td><%#Eval("other") %></td>
                                    <td><%#Eval("PM_day") %></td>
                                    <td><%#Eval("remark") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div tab-id="5" class="tab form tab5">
                        <asp:Repeater ID="Daily_Manage_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>序号</td>
                                        <td>部门内部日常管理</td>
                                        <td>工会事务</td>
                                        <td>党组事务</td>
                                        <td>团组事务</td>
                                        <td>体系内审/外审</td>
                                        <td>考勤</td>
                                        <td>其他</td>
                                        <td>工作量汇总</td>
                                        <td class="remarks">备注</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("number") %></td>
                                    <td><%#Eval("management") %></td>
                                    <td><%#Eval("affair_gonghui") %></td>
                                    <td><%#Eval("affair_dangzu") %></td>
                                    <td><%#Eval("affair_tuanzu") %></td>
                                    <td><%#Eval("examine") %></td>
                                    <td><%#Eval("kaoqin") %></td>
                                    <td><%#Eval("other") %></td>
                                    <td><%#Eval("month_day") %></td>
                                    <td><%#Eval("remark") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div tab-id="6" class="tab form tab6">
                        <asp:Repeater ID="LingXing_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>序号</td>
                                        <td>出差天数</td>
                                        <td>技术交流天数</td>
                                        <td>其他</td>
                                        <td class="remarks">备注</td>
                                    </tr>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("number") %></td>
                                    <td><%#Eval("chuchai_day") %></td>
                                    <td><%#Eval("jiaoliu_day") %></td>
                                    <td><%#Eval("other_day") %></td>
                                    <td><%#Eval("remark") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div tab-id="7" class="tab form">
                        <asp:Repeater ID="Summary_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered table-responsive">
                                    <tr>
                                        <td>总工时</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("work_day") %></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </article>
    </form>

</body>

<script src="Scripts/bootstrap.min.js"></script>
<script src="http://www.jq22.com/jquery/2.1.1/jquery.min.js"></script>
<script>window.jQuery || document.write('<script src="Sccript/jquery-3.0.0.min.js"><\/script>')</script>
<script src="Scripts/jeDate.js"></script>
<script>
    // 时间
    $('#date').jeDate({
        isinitVal: true,
        // 分隔符可以任意定义，该例子表示只显示年月
        format: 'YYYY-MM'
        // 可以将此改为    `format: 'YYYY'`     表示只显示年的插件
    });

    $(document).ready(function () {
        var activePos = $('.tabs-header .active').position();
        function changePos() {
            activePos = $('.tabs-header .active').position();
            $('.border').stop().css({
                left: activePos.left,
                width: $('.tabs-header .active').width()
            });
        }
        changePos();
        var tabHeight = $('.tab.active').height();
        function animateTabHeight() {
            tabHeight = $('.tab.active').height();
            $('.tabs-content').stop().css({ height: tabHeight + 'px' });
        }
        animateTabHeight();
        function changeTab() {
            var getTabId = $('.tabs-header .active a').attr('tab-id');
            $('.tab').stop().fadeOut(300, function () {
                $(this).removeClass('active');
            }).hide();
            $('.tab[tab-id=' + getTabId + ']').stop().fadeIn(300, function () {
                $(this).addClass('active');
                animateTabHeight();
            });
        }
        $('.tabs-header a').on('click', function (e) {
            e.preventDefault();
            var tabId = $(this).attr('tab-id');
            $('.tabs-header a').stop().parent().removeClass('active');
            $(this).stop().parent().addClass('active');
            changePos();
            tabCurrentItem = tabItems.filter('.active');
            $('.tab').stop().fadeOut(300, function () {
                $(this).removeClass('active');
            }).hide();
            $('.tab[tab-id="' + tabId + '"]').stop().fadeIn(300, function () {
                $(this).addClass('active');
                animateTabHeight();
            });
        });
        var tabItems = $('.tabs-header ul li');
        var tabCurrentItem = tabItems.filter('.active');
        $('#next').on('click', function (e) {
            e.preventDefault();
            var nextItem = tabCurrentItem.next();
            tabCurrentItem.removeClass('active');
            if (nextItem.length) {
                tabCurrentItem = nextItem.addClass('active');
            } else {
                tabCurrentItem = tabItems.first().addClass('active');
            }
            changePos();
            changeTab();
        });
        $('#prev').on('click', function (e) {
            e.preventDefault();
            var prevItem = tabCurrentItem.prev();
            tabCurrentItem.removeClass('active');
            if (prevItem.length) {
                tabCurrentItem = prevItem.addClass('active');
            } else {
                tabCurrentItem = tabItems.last().addClass('active');
            }
            changePos();
            changeTab();
        });
        $('[ripple]').on('click', function (e) {
            var rippleDiv = $('<div class="ripple" />'), rippleOffset = $(this).offset(), rippleY = e.pageY - rippleOffset.top, rippleX = e.pageX - rippleOffset.left, ripple = $('.ripple');
            rippleDiv.css({
                top: rippleY - ripple.height() / 2,
                left: rippleX - ripple.width() / 2,
                background: $(this).attr('ripple-color')
            }).appendTo($(this));
            window.setTimeout(function () {
                rippleDiv.remove();
            }, 1500);
        });


    });

</script>
</html>
