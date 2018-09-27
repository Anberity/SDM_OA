<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Root.aspx.cs" Inherits="Root" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理员界面</title>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="www/form.css" rel="stylesheet" />
    <style>
        #add_user .input-group-text {
            text-align: center;
            width: 90px;
        }

        .input-group-text {
            display: block;
        }

        h2 {
            text-align: center;
            margin-bottom: 24px;
        }

        #master {
            display: none;
        }

        .table {
            margin-top: 20px;
            width: 402px;
        }

        td {
            width: 200px;
        }

        .month {
            position: absolute;
            top: -270px;
            left: 500px;
            width: 400px;
            margin: 30px auto;
        }

        .welcome {
            position: absolute;
            right: 50px;
            top: 10px;
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
    <div>
        <h2 style="position: absolute; top: 70px; left: 190px;" class="biankuang">用户添加</h2>
        <div class="container">
            <form id="add_user" runat="server">
                <div class="welcome">
                    <h3 id="name"></h3>
                    <asp:Button Text="注销" class="btn btn-warning" runat="server" ID="logout" OnClick="logout_Click" />
                </div>
                <!--员工添加-->
                <div style="position: absolute; top: 120px; left: 100px; height: 330px" class="biankuang">
                    <!--用户名-->
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="username">用户名</span>
                        </div>
                        <asp:TextBox runat="server" ID="add_username" class="form-control" placeholder="Username" aria-describedby="basic-addon1" />
                    </div>
                    <!--密码-->
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="password">密码</span>
                        </div>
                        <asp:TextBox runat="server" ID="add_userpass" class="form-control" placeholder="Password" aria-describedby="basic-addon1" />
                    </div>
                    <!--姓名-->
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="realname">姓名</span>
                        </div>
                        <asp:TextBox runat="server" ID="add_realname" class="form-control" placeholder="Realname" aria-describedby="basic-addon1" />
                    </div>
                    <!--职位-->
                    <div class="form-group">
                        <label for="job">职位</label>
                        <select class="form-control" id="job" name="job">
                            <option>主任</option>
                            <option value="2">副主任</option>
                            <option>职员</option>
                        </select>
                        <select class="form-control" id="master" name="master">
                            <option>项目管理副主任</option>
                            <option>设计管理副主任</option>
                            <option>编程管理副主任</option>
                            <option>软件管理副主任</option>
                            <option>仪表管理副主任</option>
                        </select>
                    </div>
                    <!--小组-->
                    <div class="form-group">
                        <label for="group">小组</label>
                        <select class="form-control" id="group" name="group">
                            <option>自动化</option>
                            <option>软件</option>
                            <option>营销</option>
                            <option>管理层</option>
                        </select>
                    </div>
                    <!--提交-->
                    <div class="submit" style="position: absolute; left: 110px;">
                        <asp:Button runat="server" Text="添加" class="btn btn-success" OnClick="Unnamed1_Click"></asp:Button>
                    </div>
                </div>

                <!--员工删除-->
                <h2 style="position: absolute; top: 70px; left: 560px;" class="biankuang">用户删除</h2>
                <div style="position: absolute; top: 120px; left: 430px; height: 155px" class="biankuang">
                    <div class="container">
                        <!--用户名-->
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="delusername">用户名</span>
                            </div>
                            <asp:TextBox runat="server" ID="del_username" class="form-control" placeholder="Username" aria-describedby="basic-addon1" />
                        </div>
                        <!--姓名-->
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="delrealname">姓名</span>
                            </div>
                            <asp:TextBox runat="server" ID="del_realname" class="form-control" placeholder="Realname" aria-describedby="basic-addon1" />
                        </div>
                        <!--提交-->
                        <div class="submit" style="position: absolute; left: 180px;">
                            <asp:Button runat="server" Text="删除" class="btn btn-warning" OnClick="Unnamed2_Click"></asp:Button>
                        </div>
                    </div>
                </div>

                <!--员工离职-->
                <h2 style="position: absolute; top: 280px; left: 560px" class="biankuang">用户离职</h2>
                <div style="position: absolute; top: 330px; left: 490px; height: 157px" class="biankuang">
                    <!--用户名-->
                    <div class="input-group mb-3">
                        <div class="input-group-append">
                            <span class="input-group-text" id="offusername">用户名</span>
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

                    <!--列表展示-->
                    <div class="month">
                        <asp:Repeater ID="Username_Repeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-hover table-bordered">
                                    <thead>
                                        <tr>
                                            <td>用户名</td>
                                            <td>密码</td>
                                            <td>员工姓名</td>
                                        </tr>
                                    </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                    <tr>
                                        <td><%#Eval("username") %></td>
                                        <td><%#Eval("password") %></td>
                                        <td><%#Eval("name") %></td>
                                    </tr>
                                </tbody>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
            </form>
        </div>
    </div>
</body>
<script>
    $(document).ready(function () {

        $("#job").change(function () {
            //console.log($("#job").val());
            if ($("#job").val() == "2") {
                //console.log("fzr")
                $("#master").fadeIn("slow");
            } else {
                $("#master").hide();
            }
        })
        $('span.logout').click(function () {
            if (confirm("您确定退出吗？")) {
                window.location.href = 'Default.aspx';
            }

        })


    })
</script>
</html>
