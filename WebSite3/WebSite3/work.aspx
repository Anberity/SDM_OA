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
    <script>
        
        window.onload = function () {
            const aSpan = document.getElementsByTagName("span");
            const oIframe = document.getElementById("mainFrame");
            aSpan[0].onclick = function () {
                oIframe.src = './form/Design.aspx';
            };
            aSpan[1].onclick = function () {
                oIframe.src = './form/Programming_Picture.aspx';
            };
            aSpan[2].onclick = function () {
                oIframe.src = './form/Debug.aspx';
            };
            aSpan[3].onclick = function () {
                oIframe.src = './form/Manage_Working.aspx';
            };
            aSpan[4].onclick = function () {
                oIframe.src = './form/Daily_Manage.aspx';
            };
            aSpan[5].onclick = function () {
                oIframe.src = './form/LingXing.aspx';
            };
            aSpan[6].onclick = function () {
                oIframe.src = './form/Summary.aspx';
            };
        }
    
    </script>
    <style>
        #Tab{
            height:700px;
            padding:0;
            margin:0;
        }
    </style>
</head>
<body>
    <div class="row" id="Tab">
        <div class="col-3">
            <div class="list-group" id="list-tab" role="tablist">
                <span class="list-group-item list-group-item-action active"  data-toggle="list" role="tab" aria-controls="home">设计工作量</span>
                <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="profile">编程/画面工作量</span>
                <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="messages">调试/工程管理工作量</span>
                <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings">经营工作量</span>
                <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings">日常管理工作量</span>
                <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings">零星工日</span>
                <span class="list-group-item list-group-item-action"  data-toggle="list"  role="tab" aria-controls="settings">本月工日之和</span>
            </div>
        </div>
        <iframe class="col-7"  src="./form/Daily_Manage.aspx" runat="server" id="mainFrame" name="mainFrame" frameborder="no" border="0" marginwidth="0" marginheight="0"></iframe>
        
    </div>

</body>
</html>
