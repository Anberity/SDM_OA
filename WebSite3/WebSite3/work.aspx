<%@ Page Language="C#" AutoEventWireup="true" CodeFile="work.aspx.cs" Inherits="work" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link rel="stylesheet" href="https://cdn.bootcss.com/bootstrap/4.1.0/css/bootstrap.min.css" />


    <style>
        body {
            margin:0;
            overflow:auto;
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

        a{
            color: #000;
        }

        #list-tab {
            display: block;
        }
        .logo {
            width:273px;
            height:60px;
            margin-top:10px;
            margin-left:10px;
        }
        
        .clearfix:after{
            display:block;
            content:none;
            clear:both;
        }
        .left{
            float:left;
            width:280px;
            margin-right:20px;
        }
        .right{
            float:left;

        }
        .welcome{
            position:absolute;
            right:50px;
            top:50px;
        }
        #logout{
            position:absolute;
            right:0;
        }
    </style>
</head>
<body>
    <div class="row clearfix" id="Tab">
        <form runat="server">
            <div class="welcome">
                <h3 id="name"></h3>
                <asp:Button Text="注销" class="btn btn-warning" runat="server" ID="logout" OnClick="logout_Click" />
            </div>
        </form>
        <div class="left">
            <h1 class="logo"><img src="www/img/logo.png" /></h1>
            
            <ul class="list-group" id="box">
                <!--工作量填写-->
                <li id="tianxie" class="list-group-item list-group-item-action list-group-item-primary aaa">
                    <span>工作量填写及修改</span>
                    <div class="box">
                    <div class="list-group first" id="list-tab" role="tablist">
                        <span class="list-group-item list-group-item-action active" data-toggle="list" role="tab" aria-controls="home">设计工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="profile">编程/画面工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="messages">调试/工程管理工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">经营工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">日常管理工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">零星工日</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">本月工日之和</span>
                    </div>
                    </div>
                </li>
                <!--本次填写查看-->
                <li class="list-group-item list-group-item-action list-group-item-warning lis">
                    <a href="personform.aspx" target="_blank"><span>本次填写查看</span></a>
                </li>
                <!--当月科室所有员工工作量查看-->
                <li class="list-group-item list-group-item-action list-group-item-success lis">
                    <a href="allperson.aspx" target="_blank"><span>当月科室所有员工工作量查看</span></a>
                </li>
                <!--历史个人作量查看-->
                <li class="list-group-item list-group-item-action list-group-item-dark lis">
                    <a href="personhistory.aspx" target="_blank"><span>历史个人工作量查看</span></a>
                </li>
                <!--历史所有员工工作量查看-->
                <li class="list-group-item list-group-item-action list-group-item-info lis">
                    <a href="allpersonhistory.aspx" target="_blank"><span>历史所有员工工作量查看</span></a>
                </li>
                <!--工作量汇总-->
                <li class="list-group-item list-group-item-action list-group-item-danger lis">
                    <a href="daytotal.aspx" target="_blank"><span>工作量汇总</span></a>
                </li>
                
            </ul>
        </div>
        <div class="right">
            <iframe id="mainFrame" name="mainFrame" src="./form/Design.aspx" scrolling="auto" frameborder="0" height="auto" width="100%" onload='IFrameReSize("mainFrame");'></iframe>
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
    var arrForm = ['Design', 'Programming_Picture', 'Debug', 'Manage_Working', 'Daily_Manage', 'LingXing', 'Summary'];
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
       
       
        // $(frames['mainFrame'].document).find('#submit').hide();

        $('#list-tab span').click(function () {
            $("#mainFrame").attr('src', "./form/" + arrForm[$(this).index()] + ".aspx");
        })


        $('span.logout').click(function () {
            if (confirm("您确定退出吗？")) {
                window.location.href = 'Default.aspx';
            }
            
        })
    });
</script>
</html>
