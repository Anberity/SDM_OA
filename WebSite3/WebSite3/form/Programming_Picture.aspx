<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Programming_Picture.aspx.cs" Inherits="form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../www/form.css" rel="stylesheet" />
</head>
<body>
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <form id="program" runat="server">
                <!--修改索引-->
                <h5>修改/删除索引</h5>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="index">序号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_index" class="form-control" placeholder="Index" aria-describedby="basic-addon1"/>
                </div>
                <div class="line"></div>
                <h5>填写</h5>
                <!--项目名称-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_name">项目名称</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engineName" class="form-control" placeholder="EngineName" aria-describedby="basic-addon1"/>
                </div>
                <!--总开关量点数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="onoffNum">总开关量点数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_onOffNum" class="form-control" placeholder="OnOffNum" aria-describedby="basic-addon1"/>
                </div>
                <!--总模拟量点数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="modeNum">总模拟量点数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_modeNum" class="form-control" placeholder="ModeNum" aria-describedby="basic-addon1"/>
                </div>
                <!--编程/画面-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="programs">编程/画面</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_program" class="form-control" placeholder="Program" aria-describedby="basic-addon1"/>
                </div>
                <!--总工日数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="allDays">总工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_allDays" class="form-control" placeholder="AllDays" aria-describedby="basic-addon1"/>
                </div>
                <!--本月完成工日数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="finishedDays">本月完成工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_finishedDays" class="form-control" placeholder="FinishedDays" aria-describedby="basic-addon1"/>
                </div>
                <!--备注-->
                <h5>备注</h5>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
                </div>
                <div class="line"></div>
                <!--本次工作量填写及修改按钮-->
                <div id="box">
                    <!--修改-->
                    <div class="modifybox">
                        <asp:button runat="server" ID="modifybtn" Text="修改" class="btn btn-warning" OnClick="modifybtn_Click"  ></asp:button>
                    </div>
                    <!--删除-->
                    <div class="delete">
                        <asp:button runat="server" Text="删除" class="btn btn-danger" ID="delete" OnClick="delete_Click" ></asp:button>
                    </div>
                    <!--增加-->
                    <div class="submit">
                        <asp:button runat="server" Text="增加" class="btn btn-success" ID="submit" OnClick="submit_Click" ></asp:button>
                    </div>
                </div>

            </form>
        </div>
    </div>
    <script>
        const add_indexID = "<%=add_index.ClientID%>";
        const add_finishedDaysID = "<%=add_finishedDays.ClientID%>";

        const add_index = document.getElementById(add_indexID);
        const add_finishedDays = document.getElementById(add_finishedDaysID);

        add_index.onblur = function () {
            if (!/^[1-9]\d*$/.test(add_index.value)) {
                alert("请输入正确序号");
                this.value = "";
            }
        };
        add_finishedDays.onblur = function () {
            if (!/^\d+(\.\d{1,2})?$/.test(add_finishedDays.value)) {
                alert("请输入正确天数");
                this.value = "";
            }
        }
    </script>
</body>
</html>
