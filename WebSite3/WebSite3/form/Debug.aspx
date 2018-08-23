<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Debug.aspx.cs" Inherits="form3" %>

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
                <h2>修改/删除索引</h2>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="index">序号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_index" class="form-control" placeholder="Index" aria-describedby="basic-addon1"/>
                </div>
                <h2>填写</h2>
                <!--项目名称-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_name">项目名称</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engineName" class="form-control" placeholder="EngineName" aria-describedby="basic-addon1"/>
                </div>
                <!--项目地点-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_place">项目地点</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_enginePlace" class="form-control" placeholder="EnginePlace" aria-describedby="basic-addon1"/>
                </div>
                <!--本月工程管理天数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="manageDays">本月工程管理天数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_manageDays" class="form-control" placeholder="ManageDays" aria-describedby="basic-addon1"/>
                </div>
                <!--本月调试天数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="debugDays">本月调试天数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_debugDays" class="form-control" placeholder="DebugDays" aria-describedby="basic-addon1"/>
                </div>
                <!--备注-->
                <h2>备注</h2>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
                </div>
                <!--本次工作量填写及修改按钮-->
                <div id="box">
                    <!--修改-->
                    <div class="modifybox">
                        <asp:button runat="server" ID="modifybtn" Text="修改" class="btn btn-warning" OnClick="modifybtn_Click"  ></asp:button>
                    </div>
                    <!--删除-->
                    <div class="delete">
                        <asp:button runat="server" Text="删除" class="btn btn-danger" ID="delete" ></asp:button>
                    </div>
                    <!--增加-->
                    <div class="submit">
                        <asp:button runat="server" Text="增加" class="btn btn-success" ID="submit" OnClick="submit_Click" ></asp:button>
                    </div>
                </div>

                 

            </form>
        </div>
    </div>
</body>
</html>
