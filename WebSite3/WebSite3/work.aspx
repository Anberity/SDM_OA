﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="work.aspx.cs" Inherits="work" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link rel="stylesheet" href="https://cdn.bootcss.com/bootstrap/4.1.0/css/bootstrap.min.css" />
    <script src="https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdn.bootcss.com/popper.js/1.12.5/umd/popper.min.js"></script>
    <script src="https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>


    <style>
        body {
            margin-left: 0px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
            overflow: hidden;
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
            min-width: 600px;
            min-height: 800px;
        }

        a {
            color: #000;
        }

        #list-tab {
            display: block;
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
                        <span class="list-group-item list-group-item-action active" data-toggle="list" role="tab" aria-controls="home">设计工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="profile">编程/画面工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="messages">调试/工程管理工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">经营工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">日常管理工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">零星工日</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">本月工日之和</span>
                    </div>
                </li>
                <!--本次填写查看及修改-->
                <li class="list-group-item list-group-item-action list-group-item-warning">
                    <span>本次填写查看及修改</span>
                    <div class="list-group" id="list-tab2" role="tablist">
                        <span class="list-group-item list-group-item-action active" data-toggle="list" role="tab" aria-controls="home">设计工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="profile">编程/画面工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="messages">调试/工程管理工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">经营工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">日常管理工作量</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">零星工日</span>
                        <span class="list-group-item list-group-item-action" data-toggle="list" role="tab" aria-controls="settings">本月工日之和</span>
                    </div>
                </li>
                <!--科室所有员工工作量查看-->
                <li class="list-group-item list-group-item-action list-group-item-success">
                    <a href="" target="_blank"><span>科室所有员工工作量查看</span></a>
                </li>
            </ul>
        </div>
        <div class="col-8">
            <iframe id="mainFrame" name="mainFrame" src="./form/Design.aspx" scrolling="auto" frameborder="0" height="auto" width="100%" onload='IFrameReSize("mainFrame");'></iframe>
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
    var arrForm = ['Design', 'Programming_Picture', 'Debug', 'Manage_Working', 'Daily_Manage', 'LingXing', 'Summary'];
    $(document).ready(function () {
        $('#box').find('li').click(function () {
            $('#box').find('div').css('display', 'none')
            $('#box').find('div').eq($(this).index()).css('display', 'block');
            
        });
        // $(frames['mainFrame'].document).find('#submit').hide();

        $('#list-tab span').click(function () {

            $("#mainFrame").attr('src', "./form/" + arrForm[$(this).index()] + ".aspx");



        })
        $('#list-tab2 span').click(function () {

            $("#mainFrame").attr('src', "./form2/" + arrForm[$(this).index()] + ".aspx");
            
        })







    });
</script>
</html>
