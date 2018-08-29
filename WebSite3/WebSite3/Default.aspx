<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
    .input-group{
        width:350px;
        margin: 20px auto;

    }
    #basic-addon2{
        padding:6px 19px;
    }
    .btnbox{
        display:flex;
        width:350px;
        margin:0 auto;
    }
    .btn{
        display:block;
        justify-content:space-between;
        margin-left:70px;
        width: 58px;
        height:38px;
        }
    .btn-info{
        color: #fff;
        background-color: #5bc0de;
        border-color: #46b8da;
    }
    .btn-info.focus, .btn-info:focus{
        color: #fff;
        background-color: #31b0d5;
        border-color: #1b6d85;
    }
    #changePass{
        width:90px;
    }
    h1{
        text-align:center;
        margin-bottom:20px;
    }
    .logo{
        width:273px;
        height:60px;
        margin-top:10px;
        margin-left:10px;
    }
    .jumbotron{
        padding:160px 0;
    }
</style>
</head>
<body>
    <h1 class="logo"><img src="www/img/logo.png" /></h1>
    <div class="jumbotron">
        <h1>自动化工程技术公司工作量汇总查询系统</h1>  
        <form id="form1" runat="server">
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text" id="basic-addon1">用户名</span>
                </div>
                <asp:TextBox runat="server" ID="UserName" class="form-control" placeholder="Username" aria-describedby="basic-addon1" OnTextChanged="UserName_TextChanged"/>
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                <span class="input-group-text" id="basic-addon2">密码</span>
            </div>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" 
                    class="form-control" placeholder="Password" aria-describedby="basic-addon1" 
                    ></asp:TextBox>
            </div>

            <div class="btnbox">
                <asp:Button ID="login" runat="server" Text="登录" class="btn btn-primary" OnClick="login_Click"></asp:Button>
                
                <asp:Button ID="changePass" runat="server" Text="修改密码" type="button" class="btn btn-warning" OnClick="changePass_Click"></asp:Button>
            </div>
        </form>
    </div>
</body>
</html>
