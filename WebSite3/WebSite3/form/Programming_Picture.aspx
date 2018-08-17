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
                <h2>备注</h2>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
                </div>
                <!--提交-->
                <div class="submit">
                    <asp:button runat="server" ID="submit" Text="提交" class="btn btn-success" OnClick="submit_Click" ></asp:button>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
