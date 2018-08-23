﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="www/page.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
        *{margin:0;padding:0;list-style-type:none;}
        a,img{border:0;}
        a{text-decoration:none;outline:none;}
        html,body{font:12px/23px \u5B8B\u4F53;background: #e4e8ec;}
        .clearfix:after{content: " ";display:block;clear: both;height: 0;line-height: 0;visibility: hidden;}
        .clearfix{display: inline-block;}
        .clearfix{display: block;}
        /* warp */
        .warp{width: 980px;margin: 0 auto;padding:35px 0 40px;}
    </style>
<script type="text/javascript" src="Scripts/jquery-3.0.0.min.js"></script>
<script type="text/javascript">
$(document).ready(function(){

    var f_main_nav=$("#f_main_nav");
    var f_main_con=$("#f_main_con");

    f_main_nav.find("li").each(function(index){
        $(this).click(function(){
            if(f_main_con.find("li").eq(index).css("display")=="none"){
                f_main_con.find("li").fadeOut("fast").eq(index).fadeIn("fast");
                f_main_nav.find("span").fadeOut("fast").eq(index).fadeIn("fast");
            }else{
            	f_main_con.find("li").fadeOut("fast").eq(index).fadeOut("fast");
                f_main_nav.find("span").fadeOut("fast").eq(index).fadeOut("fast");
            }
        });
    });
    f_main_con.find("a").click(function(){
        $(this).parent().fadeOut("fast");
        f_main_nav.find("span").fadeOut("fast");
    });

});
</script>
</head>
<body>
    <form id="form" runat="server">
        <div class="warp">

	        <div id="f_main_nav" class="f_main_nav">
		        <ul class="clearfix">
			        <li class="fm1">
				        <p class="fm_info">拖动mp3音乐即可自动转换铃声。</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm2">
				        <p class="fm_info">桌面管理，帮你的程序归类。</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm3">
				        <p class="fm_info">关联ipa，双击安装。</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm4">
				        <p class="fm_info">Plist编辑器</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm5">
				        <p class="fm_info">短信，联系人，可编辑。</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm6">
				        <p class="fm_info">定制app标签</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm7">
				        <p class="fm_info">清理垃圾。</p>
				        <span>&nbsp;</span>
			        </li>
			        <li class="fm8">
				        <p class="fm_info">不同设备间资料共享</p>
				        <span>&nbsp;</span>
			        </li>
		        </ul>
	        </div>
		
	        <div id="f_main_con" class="f_main_con">
		        <ul>
			        <li class="fmc1">
				        <a class="dc_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>拖动mp3音乐，即可自动转换成m4r格式。</strong>
					        <p>还苦恼每次添加铃声的时候怎么转换成苹果特有的m4r格式吗？无需安装解码软件，轻轻将喜欢的音乐拖曳到iTools的设备铃声栏中，即可自动将其转换成m4r格式。还可以随意截取自己喜欢的片段，作为手机铃声。</p>
				        </div>
			        </li>
			        <li class="fmc2">
				        <a class="dr_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>桌面管理，帮你的程序归类。</strong>
					        <p>下载了好多应用程序，看得眼花缭乱？iTools桌面管理的智能分类让你不再头痛，选好类别，自动帮你将相应程序归好类。</p>
				        </div>
			        </li>
			        <li class="fmc3">
				        <a class="de_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>关联ipa，双击安装。</strong>
					        <p>关联ipa，在各大网站点击iTools的ipa一键安装按钮，或者直接在电脑中双击ipa文件就能将其安装到您的设备。</p>
				        </div>
			        </li>
			        <li class="fmc4">
				        <a class="df_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>Plist编辑器</strong>
					        <p>专为中高级用户打造，对于需要修改的plist文件，无需再下载相关软件，直接打开iTools的plist文件即可编辑。</p>
				        </div>
			        </li>
			        <li class="fmc5">
				        <a class="dx_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>短信，联系人，可编辑。</strong>
					        <p>短信内容，联系人信息，随意编辑，一键保存。</p>
				        </div>
			        </li>
			        <li class="fmc7">
				        <a class="app_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>定制app标签。</strong>
					        <p>多人共用一台电脑，本地程序很多很杂怎么一键管理？iTools程序库里面的定制app标签功能，让你一键管理属于你的全部APP。</p>
				        </div>
			        </li>
			        <li class="fmc6">
				        <a class="clear_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info">
					        <strong>清理垃圾。</strong>
					        <p>iTools首创的清理垃圾功能，让你的苹果设备更轻巧，运行更无负担！</p>
				        </div>
			        </li>
			        <li class="fmc8">
				        <a class="share_close" title="关闭" href="javascript:void(0);">关闭</a>
				        <div class="fmc_info"><strong>不同设备间资料共享。</strong>
					        <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
                            <p>多台设备同时连接到电脑上，即可将软件同时安装到不同的设备上，最高可连接20台设备。如果你是手机销售商，这样的设计，一定让你的效率大大提高。</p>
				        </div>
			        </li>
		        </ul>
	        </div>

        </div>
        <!--<div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table>
                    <tr>
                        <td>year</td>
                        <td>mon</td>
                        <td>username</td>
                        <td>team</td>
                        <td>number</td>
                        <td>编号</td>
                        <td>用户名</td>
                        <td>用户密码</td>
                        <td>用户类型</td>
                        <td>用户类型</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("year") %></td>
                    <td><%#Eval("mon") %></td>
                    <td><%#Eval("username") %></td>
                    <td><%#Eval("team") %></td>
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
    </div>-->
    </form>
</body>
</html>
