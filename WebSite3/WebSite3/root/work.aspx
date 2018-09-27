﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="work.aspx.cs" Inherits="root_work" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>工作量查询系统</title>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../www/form.css" rel="stylesheet" />
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

        .month {
            position: absolute;
            top: 100px;
            left: 800px;
            width: 450px;
            margin: 30px auto;
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
            right: 50px;
            top: 50px;
        }

        #logout {
            position: absolute;
            right: 0;
        }

        .biankuang {
            padding: 5px 5px 5px 5px;
            box-shadow: 0px 1px 3px rgba(34, 25, 25, 0.2);
        }
    </style>
</head>
<body style="background-color: #dddddd">
    <div class="row clearfix" id="Tab">
        <form runat="server">
            <div class="welcome">
                <h3 id="name"></h3>
                <asp:Button Text="注销" class="btn btn-warning" runat="server" ID="logout" OnClick="logout_Click" />
            </div>
            <div>
                <!--离职状态-->
                <!--员工离职-->
                <h2 style="position: absolute; top: 130px; left: 460px" class="biankuang">用户离职</h2>
                <div style="position: absolute; top: 180px; left: 390px; height: 157px" class="biankuang">
                    <!--用户名-->
                    <div class="input-group mb-3">
                        <div class="input-group-append">
                            <span class="input-group-text" id="offusername">员工姓名</span>
                        </div>
                        <asp:TextBox runat="server" ID="off_username" Class="form-control" placeholder="Username" aria-describedby="basic-addon1" />
                    </div>
                    <!--在职状态-->
                    <div class="form-group">
                        <label for="jobsta">工作状态</label>
                        <select class="form-control" id="jobstatus" name="jobstatus">
                            <option value="1">在职</option>
                            <option value="0">离职</option>
                        </select>
                    </div>
                    <!--提交-->
                    <div class="submit" style="position: absolute; left: 110px;">
                        <asp:Button runat="server" Text="提交" class="btn btn-success" OnClick="JobStatus_Click"></asp:Button>
                    </div>
                </div>
            </div>

            <!--列表展示-->
            <div class="month">
                <asp:Repeater ID="Username_Repeater" runat="server">
                    <HeaderTemplate>
                        <table class="table table-hover table-bordered">
                            <thead>
                                <tr>
                                    <td>用户名</td>
                                    <td>密码</td>
                                    <td style="width:90px">员工姓名</td>
                                    <td style="width:150px">
                                        <div>在职状态</div>
                                        <div>1:在职，0:离职</div>
                                    </td>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td><%#Eval("username") %></td>
                                <td><%#Eval("password") %></td>
                                <td style="width:90px"><%#Eval("name") %></td>
                                <td><%#Eval("on_job") %></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </form>
        <div class="left">
            <h1 class="logo">
                <img src="../www/img/logo.png" style="background-color: transparent" /></h1>

            <ul class="list-group" id="box">

                <!--当月工作量审核-->
                <li class="list-group-item list-group-item-action list-group-item-success lis">
                    <a href="allperson.aspx" target="_blank"><span>当月工作量审核</span></a>
                </li>

                <!--历史工作量查询-->
                <li class="list-group-item list-group-item-action list-group-item-info lis">
                    <a href="allpersonhistory.aspx" target="_blank"><span>历史工作量查询</span></a>
                </li>
                <!--工作量统计汇总-->
                <li class="list-group-item list-group-item-action list-group-item-danger lis">
                    <a href="daytotal.aspx" target="_blank"><span>工作量统计汇总</span></a>
                </li>

            </ul>

            <div class="right">
                <iframe id="mainFrame" name="mainFrame" src="" scrolling="auto" frameborder="0" height="auto" width="100%" onload='IFrameReSize("mainFrame");'></iframe>
            </div>
        </div>
</body>
<script src="https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js"></script>
<script src="https://cdn.bootcss.com/popper.js/1.12.5/umd/popper.min.js"></script>

<script src="https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>




</html>
