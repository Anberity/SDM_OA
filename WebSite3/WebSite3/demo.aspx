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
    <style>
        .form{
            padding:20px;
        }
    </style>
</head>
<body>
<form id="form" runat="server">
    <article class="htmleaf-container">
		
        <div class="tabs">
	        <div class="tabs-header">
	        <div class="border"></div>
	        <ul>
		        <li class="active"><a href="#tab-1" tab-id="1" ripple="ripple" ripple-color="#FFF">Tab 1</a></li>
		        <li><a href="#tab-2" tab-id="2" ripple="ripple" ripple-color="#FFF">Tab 2</a></li>
		        <li><a href="#tab-3" tab-id="3" ripple="ripple" ripple-color="#FFF">Tab 3</a></li>
		        <li><a href="#tab-4" tab-id="4" ripple="ripple" ripple-color="#FFF">Tab 4</a></li>
		        <li><a href="#tab-5" tab-id="5" ripple="ripple" ripple-color="#FFF">Tab 5</a></li>
	        </ul>
	        <nav class="tabs-nav"><i id="prev" ripple="ripple" ripple-color="#FFF" class="material-icons">&#xE314;</i><i id="next" ripple="ripple" ripple-color="#FFF" class="material-icons">&#xE315;</i></nav>
	        </div>
	        <div class="tabs-content">
	            <div tab-id="1" class="tab active form">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <table class="table table-hover table-bordered table-responsive">
                                <tr>
                                    <td>编号</td>
                                    <td>用户名</td>
                                    <td>用户密码</td>
                                    <td>用户类型</td>
                                    <td>用户类型</td>
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
	            <div tab-id="2" class="tab">2. Donec ullamcorper nulla non metus auctor fringilla. Aenean eu leo quam.</div>
	            <div tab-id="3" class="tab">3. Donec ullamcorper nulla non metus auctor fringilla. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Curabitur blandit tempus porttitor.</div>
	            <div tab-id="4" class="tab">4. Donec ullamcorper nulla non metus auctor fringilla. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Curabitur blandit tempus porttitor. Maecenas faucibus mollis interdum. Donec ullamcorper nulla non metus auctor fringilla. Aenean lacinia bibendum nulla sed consectetur. Aenean lacinia bibendum nulla sed consectetur.</div>
	            <div tab-id="5" class="tab">5. Donec ullamcorper nulla non metus auctor fringilla. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Curabitur blandit tempus porttitor.Cras mattis consectetur purus sit amet fermentum. Maecenas sed diam eget risus varius blandit sit amet non magna. Nullam quis risus eget urna mollis ornare vel eu leo. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor. Maecenas sed diam eget risus varius blandit sit amet non magna. Maecenas sed diam eget risus varius blandit sit amet non magna. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Integer posuere erat a ante venenatis dapibus posuere velit aliquet. Vestibulum id ligula porta felis euismod semper. Aenean lacinia bibendum nulla sed consectetur. Donec id elit non mi porta gravida at eget metus. Donec id elit non mi porta gravida at eget metus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas faucibus mollis interdum. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Aenean lacinia bibendum nulla sed consectetur. Maecenas faucibus mollis interdum. Donec ullamcorper nulla non metus auctor fringilla. Aenean lacinia bibendum nulla sed consectetur. Aenean lacinia bibendum nulla sed consectetur.</div>
	        </div>
        </div>
    </article>
</form>
    
</body>

    <script src='Sccript/stopExecutionOnTimeout.js?t=1'></script>
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
