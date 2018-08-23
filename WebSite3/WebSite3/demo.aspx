<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel='stylesheet prefetch' href='www/css/reset.css'/>
	<link rel="stylesheet" type="text/css" href="www/css/default.css"/>
	<link rel='stylesheet prefetch' href='https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700,900|Material+Icons'/>
	<link rel="stylesheet" type="text/css" href="www/css/styles.css"/>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
	<!--[if IE]>
		<script src="http://libs.baidu.com/html5shiv/3.7/html5shiv.min.js"></script>
	<![endif]-->
</head>
<body>
<form id="form" runat="server">
    <article class="htmleaf-container">
		
        <div class="tabs">
	        <div class="tabs-header">
	        <div class="border"></div>
	        <ul>
		        <li class="active"><a href="#tab-1" tab-id="1" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="designBtn"  Text="设计工作量" OnClick="DesignBtn_Click"/></a></li>
		        <li><a href="#tab-2" tab-id="2" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="Programming_PictureBtn"  Text="编程/画面工作量" OnClick="Programming_PictureBtn_Click"/></a></li>
		        <li><a href="#tab-3" tab-id="3" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="DebugBtn"  Text="调试/工程管理工作量" OnClick="DebugBtn_Click"/></a></li>
		        <li><a href="#tab-4" tab-id="4" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="Manage_Working"  Text="经营工作量" OnClick="Manage_WorkingBtn_Click"/></a></li>
		        <li><a href="#tab-5" tab-id="5" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="Daily_Manage"  Text="日常管理工作量" OnClick="Daily_ManageBtn_Click"/></a></li>
                <li><a href="#tab-6" tab-id="6" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="LingXing"  Text="零星工日" OnClick="LingXingBtn_Click"/></a></li>
                <li><a href="#tab-7" tab-id="7" ripple="ripple" ripple-color="#FFF"><asp:Button runat="server" ID="Summary"  Text="本月工日之和" OnClick="SummaryBtn_Click"/></a></li>
	        </ul>
	        <nav class="tabs-nav"><i id="prev" ripple="ripple" ripple-color="#FFF" class="material-icons">&#xE314;</i><i id="next" ripple="ripple" ripple-color="#FFF" class="material-icons">&#xE315;</i></nav>
	        </div>
	        <div class="tabs-content">
	            <div tab-id="1" class="tab active form">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>工程号</td>
                                    <td>工程名称</td>
                                    <td>图纸张数</td>
                                    <td>折合A1</td>
                                    <td>折合总工日数</td>
                                    <td>本月完成工日数</td>
                                    <td>技术方案工作量所用工日数</td>
                                    <td>基本设计工作量所用工日数</td>
                                    <td>专业负责人</td>
                                    <td>备注</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
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
	            <div tab-id="2" class="tab form">
                    <asp:Repeater ID="Repeater2" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>项目名称</td>
                                    <td>总开关量点数</td>
                                    <td>总模拟量点数</td>
                                    <td>编程/画面</td>
                                    <td>总工日数</td>
                                    <td>本月完成工日数</td>
                                    <td>备注</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
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
	            <div tab-id="3" class="tab form">
                    <asp:Repeater ID="Repeater3" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>项目名称</td>
                                    <td>项目地点</td>
                                    <td>本月工程管理天数</td>
                                    <td>本月调试天数</td>
                                    <td>备注</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
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
	            <div tab-id="4" class="tab form">
                    <asp:Repeater ID="Repeater4" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>项目名称</td>
                                    <td>商务询价报价</td>
                                    <td>标书制作</td>
                                    <td>合同制作与签署</td>
                                    <td>投标工作</td>
                                    <td>设备招标采购</td>
                                    <td>设备出厂检测</td>
                                    <td>催款（要账）</td>
                                    <td>合同管理</td>
                                    <td>其他经营活动</td>
                                    <td>项目经理</td>
                                    <td>备注</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
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
	            <div tab-id="5" class="tab form">
                    <asp:Repeater ID="Repeater5" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>部门内部日常管理</td>
                                    <td>工会事务</td>
                                    <td>党组事务</td>
                                    <td>团组事务</td>
                                    <td>体系内审/外审</td>
                                    <td>考勤</td>
                                    <td>电话费报销</td>
                                    <td>餐费报销</td>
                                    <td>其他报销</td>
                                    <td>每月工作量统计汇总</td>
                                    <td>备注</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
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
                <div tab-id="6" class="tab form">
                    <asp:Repeater ID="Repeater6" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>本月出差天数</td>
                                    <td>技术交流天数</td>
                                    <td>其他零星工日</td>
                                    <td>备注</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
                                    <td><%#Eval("projectname") %></td>
                                    <td><%#Eval("site") %></td>
                                    <td><%#Eval("manageday") %></td>
                                    <td><%#Eval("debugday") %></td>
                                </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
	            </div>
                <div tab-id="7" class="tab form">
                    <asp:Repeater ID="Repeater7" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>本月工作日之和</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                                <tr>
                                    <td><%#Eval("projectname") %></td>
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

    <script src="Scripts/stopExecutionOnTimeout.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
	<script src="http://www.jq22.com/jquery/2.1.1/jquery.min.js"></script>
	<script>window.jQuery || document.write('<script src="Sccript/jquery-3.0.0.min.js"><\/script>')</script>
	<script>
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
