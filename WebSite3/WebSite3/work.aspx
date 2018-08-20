<%@ Page Language="C#" AutoEventWireup="true" CodeFile="work.aspx.cs" Inherits="work" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link rel="stylesheet" href="https://cdn.bootcss.com/bootstrap/4.1.0/css/bootstrap.min.css"/>
    <script src="https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdn.bootcss.com/popper.js/1.12.5/umd/popper.min.js"></script>
    <script src="https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>


    <style>
        body {margin-left: 0px;margin-top: 0px;margin-right: 0px;margin-bottom: 0px;overflow: hidden;}
        #Tab{
            width:100%;
            height:100%;
            padding:0;
            margin:0;
        }
        #list-tab2,#list-tab3{
            display:none;
        }
        #mainFrame{
            min-width:600px;
            min-height:800px;
        }
        a{
            color:#000;
        }
        #list-tab{
            display:block;
        }
    </style>
</head>
<body>
    <div class="row" id="Tab">
        <div class="col-4">
            <ul class="list-group" id="box">
                <!--工作量填写-->
                <li class="list-group-item list-group-item-action list-group-item-primary aaa">
                    <span>工作量填写</span> 
                    <div class="list-group" id="list-tab" role="tablist">
                        <span class="list-group-item list-group-item-action active"  data-toggle="list" role="tab" aria-controls="home"><a href="./form/Design.aspx" target="mainFrame">设计工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="profile"><a href="./form/Programming_Picture.aspx" target="mainFrame">编程/画面工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="messages"><a href="./form/Debug.aspx" target="mainFrame">调试/工程管理工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">经营工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Manage_Working.aspx" target="mainFrame">日常管理工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/LingXing.aspx" target="mainFrame">零星工日</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Summary.aspx" target="mainFrame">本月工日之和</a></span>
                    </div>
                </li>
                <!--本次填写查看及修改-->
                 <li class="list-group-item list-group-item-action list-group-item-warning">
                    <span>本次填写查看及修改</span> 
                    <div class="list-group" id="list-tab2" role="tablist">
                        <span class="list-group-item list-group-item-action active"  data-toggle="list" role="tab" aria-controls="home"><a href="./form/Daily_Manage.aspx" target="mainFrame">设计工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="profile"><a href="./form/Daily_Manage.aspx" target="mainFrame">编程/画面工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="messages"><a href="./form/Daily_Manage.aspx" target="mainFrame">调试/工程管理工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">经营工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">日常管理工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">零星工日</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">本月工日之和</a></span>
                    </div>
                </li>
                <!--历史工作量查看-->
                 <li class="list-group-item list-group-item-action list-group-item-success">
                    <span>历史工作量查看</span> 
                    <div class="list-group" id="list-tab3" role="tablist">
                        <span class="list-group-item list-group-item-action active"  data-toggle="list" role="tab" aria-controls="home"><a href="./form/Daily_Manage.aspx" target="mainFrame">设计工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="profile"><a href="./form/Daily_Manage.aspx" target="mainFrame">编程/画面工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="messages"><a href="./form/Daily_Manage.aspx" target="mainFrame">调试/工程管理工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">经营工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">日常管理工作量</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">零星工日</a></span>
                        <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings"><a href="./form/Daily_Manage.aspx" target="mainFrame">本月工日之和</a></span>
                    </div>
                </li>
            </ul>    
        </div>
        <div class="col-8"> 
            <iframe id="mainFrame" name="mainFrame" src="./form/Daily_Manage.aspx" scrolling="auto" frameborder="0" height="auto" width="100%" onload='IFrameReSize("mainFrame");'></iframe>  
        </div>
    </div>
</body>
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
            $('#box').find('li').click(function () {
                $('#box').find('div').css('display', 'none')
                $('#box').find('div').eq($(this).index()).css('display', 'block');
            });
        });
    </script>
</html>
