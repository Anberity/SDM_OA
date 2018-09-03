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
            position: relative;
            width: 400px;
            margin: 30px auto;
        }
    </style>
</head>
<body>
    <div class="jumbotron jumbotron-fluid">
        <h2>用户添加</h2>
        <div class="container">
            <form id="add_user" runat="server">
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
                    </select>
                </div>
                <!--提交-->
                <div class="submit">
                    <asp:Button runat="server" Text="添加" class="btn btn-success" OnClick="Unnamed1_Click"></asp:Button>
                </div>

                <div class="jumbotron jumbotron-fluid">
                    <h2>用户删除</h2>
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
                        <div class="submit">
                            <asp:Button runat="server" Text="删除" class="btn btn-warning" OnClick="Unnamed2_Click"></asp:Button>
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


    })
</script>
</html>
