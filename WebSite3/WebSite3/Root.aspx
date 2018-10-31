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
            top: -50px;
            left: 500px;
            width: 400px;
            margin: 30px auto;
        }

        .welcome {
            position: absolute;
            right: 50px;
            top: 10px;
            text-align: center;
            margin: 0 auto;
        }

        #logout {
            position: absolute;
            right: 0;
        }

        .biankuang {
            padding: 5px 5px 5px 5px;
            box-shadow: 0px 1px 3px rgba(34, 25, 25, 0.2);
        }

        .jumbotron {
            padding: 160px 0;
            background-color: white;
            width: 880px;
            height: 320px;
            align: center;
            line-height: 500px;
            overflow: hidden;
            margin-top: 230px;
            margin-left: auto;
            margin-right: auto;
            box-shadow: 0px 1px 3px rgba(34, 25, 25, 0.2);
        }
    </style>
</head>
<body style="background-color: #dddddd; height: 1000px;">
    <div>
        <h2 style="position: absolute; top: 70px; left: 190px;" class="biankuang">员工添加</h2>
        <div class="container">
            <form id="add_user" runat="server">
                <div class="welcome">
                    <h3 id="name"></h3>
                    <asp:Button Text="注销" class="btn btn-warning" runat="server" ID="logout" OnClick="logout_Click" />
                </div>
                <!--员工添加-->
                <div style="position: absolute; top: 120px; left: 100px; height: 380px" class="biankuang">
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
                    <!--员工编号-->
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="peoplenumber">员工编号</span>
                        </div>
                        <asp:TextBox runat="server" ID="PeopleNumber" class="form-control" placeholder="PeopleNumber" aria-describedby="basic-addon1" />
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

                <!--员工离职-->
                <h2 style="position: absolute; top: 70px; left: 560px" class="biankuang">员工离职</h2>
                <div style="position: absolute; top: 120px; left: 490px; height: 157px" class="biankuang">
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
                </div>
                <!--员工信息修改-->
                <h2 style="position: absolute; top: 500px; left: 490px" class="biankuang">员工信息修改</h2>
                <div style="position: absolute; top: 550px; left: 100px; height: 0px; width: 300px">
                    <div class="biankuang" style="width: 1005px; height: 160px;">
                        <!--用户名-->
                        <div class="input-group mb-3" style="position: absolute;">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="username1">用户名</span>
                            </div>
                            <asp:TextBox runat="server" ID="Username" class="form-control" placeholder="Username" aria-describedby="basic-addon1" />
                        </div>
                        <!--查询-->
                        <div class="submit" style="position: absolute; top: 5px; left: 380px;">
                            <asp:Button runat="server" Text="查询" class="btn btn-success" OnClick="Select_Click"></asp:Button>
                        </div>
                        <!--密码-->
                        <div class="input-group mb-3" style="position: absolute; top: 60px;">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="pwd">密码</span>
                            </div>
                            <asp:TextBox runat="server" ID="Pwd" class="form-control" placeholder="Password" aria-describedby="basic-addon1" />
                        </div>
                        <!--真实姓名-->
                        <div class="input-group mb-3" style="position: absolute; top: 60px; left: 350px;">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="peopleName">姓名</span>
                            </div>
                            <asp:TextBox runat="server" ID="PeopleName" class="form-control" placeholder="RealName" aria-describedby="basic-addon1" />
                        </div>
                        <!--员工编号-->
                        <div class="input-group mb-3" style="position: absolute; top: 5px; left: 700px;">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="staffNumber">员工编号</span>
                            </div>
                            <asp:TextBox runat="server" ID="StaffNumber" class="form-control" placeholder="StaffNumber" aria-describedby="basic-addon1" />
                        </div>
                        <!--小组-->
                        <div class="input-group mb-3" style="position: absolute; top: 114px;">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="Group">小组</span>
                            </div>
                            <select runat="server" class="form-control" id="group2" name="group2">
                                <option value="1">自动化</option>
                                <option value="2">软件</option>
                                <option value="3">营销</option>
                                <option value="0">管理层</option>
                            </select>
                        </div>
                        <!--职位-->
                        <div class="input-group mb-3" style="position: absolute; top: 114px; left: 320px; width: 360px">
                            <div class="input-group-prepend">
                                <lable class="input-group-text" for="Post">职位</lable>
                            </div>
                            <select runat="server" class="form-control" id="Post" name="Post">
                                <option value="1">主任</option>
                                <option value="2">副主任</option>
                                <option value="18">职员</option>
                            </select>
                            <select runat="server" class="form-control" id="fzr" name="fzr" style="width: 80px;">
                                <option value="2">项目管理副主任</option>
                                <option value="3">设计管理副主任</option>
                                <option value="4">编程管理副主任</option>
                                <option value="5">软件管理副主任</option>
                                <option value="6">仪表管理副主任</option>
                            </select>
                        </div>
                    </div>
                    <!--借调状态-->
                    <div class="input-group mb-3" style="position: absolute; top: 60px; left: 700px;">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="jieDiao">借调状态</span>
                        </div>
                        <asp:TextBox runat="server" ID="JieDiao" class="form-control" placeholder="jieDiao" aria-describedby="basic-addon1" />
                    </div>
                    <!--在职状态-->
                    <div class="input-group mb-3" style="position: absolute; top: 114px; left: 700px;">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="onJob">在职状态</span>
                        </div>
                        <asp:TextBox runat="server" ID="OnJob" class="form-control" placeholder="OnJob" aria-describedby="basic-addon1" />
                    </div>
                    <!--修改-->
                    <div class="submit" style="position: absolute; top: 5px; left: 550px;">
                        <asp:Button runat="server" Text="修改" class="btn btn-success" OnClick="Update_Click"></asp:Button>
                    </div>
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

        $("#Post").change(function () {
            if ($("#Post").val() == "2") {
                $("#fzr").fadeIn("slow");
            } else {
                $("#fzr").hide();
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
