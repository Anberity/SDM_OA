<%@ Page Language="C#" AutoEventWireup="true" CodeFile="workbra.aspx.cs" Inherits="workbra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>工作量查询系统</title>
    <link rel="stylesheet" href="https://cdn.bootcss.com/bootstrap/4.1.0/css/bootstrap.min.css" />
    <style>
        body {
            margin: 0;
            overflow: auto;
        }

        #Tab {
            width: 100%;
            height: 100%;
            padding: 0;
            margin: 0;
        }

        #list-tab2, #list-tab3 {
            display: none;
        }

        #mainFrame {
            min-width: 1000px;
            min-height: 600px;
        }

        a {
            color: #000;
        }

        #list-tab {
            display: block;
        }

        .logo {
            width: 273px;
            height: 60px;
            margin-top: 10px;
            margin-left: 10px;
        }

        .clearfix:after {
            display: block;
            content: none;
            clear: both;
        }

        .left {
            float: left;
            width: 280px;
            margin-right: 20px;
        }

        .right {
            float: left;
        }

        .welcome {
            position: absolute;
            left: 1250px;
            top: 50px;
        }
        .onj {
            position: absolute;
            left: 1050px;
            top: 120px;
        }
        #logout {
            position: absolute;
            right: 0;
        }
    </style>
</head>
<body>
    <div class="row clearfix" id="Tab">
        <form runat="server">
            <div class="welcome">
                <h3 id="name"></h3>
                <div style="position:absolute;left:260px;top:0px">
                    <asp:Button Text="注销" class="btn btn-warning" runat="server" ID="logout" OnClick="logout_Click" />
                </div>
            </div>
            <div class="onj">
                <h5 id="tran"></h5>
                <div style="position:absolute;left:330px;top:40px">
                    <asp:Button Text="借调结束" CssClass="btn btn-warning" runat="server" ID="OnJob" OnClick="OnJob_Click" />
                </div>
            </div>
        </form>
        <div class="left">
            <h1 class="logo">
                <img src="www/img/logo.png" style="background-color: transparent" /></h1>

            <ul class="list-group" id="box">
                <!--历史个人工作量查询-->
                <li class="list-group-item list-group-item-action list-group-item-dark lis">
                    <a href="personhistory.aspx" target="_blank"><span>历史个人工作量查询</span></a>
                </li>
                <!--当月科室工作量查询-->
                <li class="list-group-item list-group-item-action list-group-item-success lis">
                    <a href="allperson.aspx" target="_blank"><span>当月科室工作量查询</span></a>
                </li>
                <!--科室历史工作量查询-->
                <li class="list-group-item list-group-item-action list-group-item-info lis">
                    <a href="allpersonhistory.aspx" target="_blank"><span>科室历史工作量查询</span></a>
                </li>
                <!--工作量统计汇总-->
                <li class="list-group-item list-group-item-action list-group-item-danger lis">
                    <a href="daytotal.aspx" target="_blank"><span>工作量统计汇总</span></a>
                </li>

            </ul>
        </div>
    </div>
</body>
<script src="https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js"></script>
<script src="https://cdn.bootcss.com/popper.js/1.12.5/umd/popper.min.js"></script>
<script src="https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>
<script>
    function IFrameReSize(iframename) {
        var pTar = document.getElementById(iframename);
        if (pTar) {  //ff
            if (pTar.contentDocument && pTar.contentDocument.body.offsetHeight) {
                pTar.height = pTar.contentDocument;
            } //ie
            else if (pTar.Document && pTar.Document.body.scrollHeight) {
                pTar.height = pTar.Document;
            }
        }
    }
    $(document).ready(function () {
        $('#tianxie').click(function () {
            $('#tianxie').find('.box').toggle();
        })
        $('#tianxie').find('.first span').click(function (e) {
            $('#tianxie').find('.first span').attr("class", "list-group-item list-group-item-action");
            $('#tianxie').find('.first span').eq($(this).index()).attr("class", "list-group-item list-group-item-action active");
            e.stopPropagation();
        });
        $('#box').find('.lis').click(function () {
            $('#box').find('div.box').css('display', 'none')

        });

        $('span.logout').click(function () {
            if (confirm("您确定退出吗？")) {
                window.location.href = 'Default.aspx';
            }

        })
    });
</script>
</html>
