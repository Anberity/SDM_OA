<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Design.aspx.cs" Inherits="form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../www/form.css" rel="stylesheet" />

</head>
<body>
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <form id="design" runat="server">
                <!--修改索引-->
                <h2>修改/删除索引</h2>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="index">序号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_index" class="form-control" placeholder="Index" aria-describedby="basic-addon1" />
                </div>
                <div class="line"></div>
                <h2>填写</h2>
                <!--工程号-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine">工程号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engine" class="form-control" placeholder="EngineNum" aria-describedby="basic-addon1" />
                </div>
                <!--工程名称-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_name">工程名称</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engineName" class="form-control" placeholder="EngineName" aria-describedby="basic-addon1" />
                </div>
                <!--施工图工作量-->
                <h2>施工图工作量</h2>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="paperPage">图纸张数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_paperPage" class="form-control" placeholder="PaperPage" aria-describedby="basic-addon1" />
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="al">折合Al</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_al" class="form-control" placeholder="Al" aria-describedby="basic-addon1" />
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="allDays">折合总工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_allDays" class="form-control" placeholder="AllDays" aria-describedby="basic-addon1" />
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="finishedDays">本月完成工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_finishedDays" class="form-control" placeholder="FinishedDays" aria-describedby="basic-addon1" />
                </div>
                <!--技术方案工作量-->
                <h3>技术方案工作量</h3>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="usedDays">所用工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_usedDays" class="form-control" placeholder="UsedDays" aria-describedby="basic-addon1" />
                </div>
                <!--基本设计工作量-->
                <h3>基本设计工作量</h3>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="usedDays2">所用工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_usedDays2" class="form-control" placeholder="UsedDays2" aria-describedby="basic-addon1" />
                </div>
                <!--专业负责人-->
                <h3>专业负责人</h3>
                <div class="input-group mb-3">
                    <p>此列不是写专业负责人名字，如果你是专业负责人，把操心的工作量折合工日写在此列</p>
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="leaderDays">工日</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_leaderDays" class="form-control" placeholder="LeaderDays" aria-describedby="basic-addon1" />
                </div>
                <!--备注-->
                <h2>备注</h2>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1" />
                </div>

                <div class="line"></div>
                <!--本次工作量填写及修改按钮-->
                <div id="box">
                    <!--修改-->
                    <div class="modifybox">
                        <asp:Button runat="server" ID="modifybtn" Text="修改" class="btn btn-warning" OnClick="modifybtn_Click"></asp:Button>
                    </div>
                    <!--删除-->
                    <div class="delete">
                        <asp:Button runat="server" Text="删除" class="btn btn-danger" ID="delete" OnClick="delete_Click"></asp:Button>
                    </div>
                    <!--增加-->
                    <div class="submit">
                        <asp:Button runat="server" Text="增加" class="btn btn-success" ID="submit" OnClick="submit_Click"></asp:Button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
<script src="../www/regexp.js"></script>
<script>
    const add_indexID = "<%=add_index.ClientID%>";
    const add_finishedDaysID = "<%=add_finishedDays.ClientID%>";
    const add_usedDaysID = "<%=add_usedDays.ClientID%>";
    const add_usedDays2ID = "<%=add_usedDays2.ClientID%>";
    const add_leaderDaysID = "<%=add_leaderDays.ClientID%>";

    const add_index = document.getElementById(add_indexID);
    const sadd_finishedDays = document.getElementById(add_finishedDaysID);
    const sadd_usedDays = document.getElementById(add_usedDaysID);
    const sadd_usedDays2 = document.getElementById(add_usedDays2ID);
    const sadd_leaderDays = document.getElementById(add_leaderDaysID);

    const submitBtn = document.getElementsByClassName('submit')[0];

    var arr = [sadd_finishedDays, sadd_usedDays, sadd_usedDays2, sadd_leaderDays];


    add_index.onblur = function () {
        ifIndex(this);
    };

    submitBtn.onclick = function () {
        var arr2 = [];
        var z = /^[0-9]+.?[0-9]*$| (^\s*)|(\s*$) /;
        let s;
        for (let i = 0; i < arr.length; i++) {
            console.log(arr[i].value + ":" + typeof (arr[i].value));
            s = z.test(arr[i].value);
            arr2.push(s);
        }
        console.log(arr2 + ":" + arr2.length);
        for (let i = 0; i < arr2.length; i++) {
            console.log(arr2[i]);
            if (arr2[i] == false || arr2[i] == "false") {
                arr[j].value = "";
                alert("请输入有效数字");
                return false;
            }
            console.log(arr[i].value);
            

        }

    }
</script>
</html>
