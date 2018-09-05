<%@ Page Language="C#" AutoEventWireup="true" CodeFile="work.aspx.cs" Inherits="root_work" %>

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
            <h1 class="logo"><img src="../www/img/logo.png" /></h1>
            <ul class="list-group" id="box">
               
                <!--当月科室所有员工工作量查看-->
                <li class="list-group-item list-group-item-action list-group-item-success lis">
                    <a href="allperson.aspx" target="_blank"><span>当月科室所有员工工作量查看及修改</span></a>
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
            <iframe id="mainFrame" name="mainFrame" src="" scrolling="auto" frameborder="0" height="auto" width="100%" onload='IFrameReSize("mainFrame");'></iframe>
        </div>
    </div>
</body>
    <script src="https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdn.bootcss.com/popper.js/1.12.5/umd/popper.min.js"></script>
    
    <script src="https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>
    
    
    

</html>
