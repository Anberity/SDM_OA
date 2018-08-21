<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Design.aspx.cs" Inherits="form1" %>

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
            <form id="design" runat="server">
                
                <!--工程号-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine">工程号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engine" class="form-control" placeholder="EngineNum" aria-describedby="basic-addon1"/>
                </div>
                <!--工程名称-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_name">工程名称</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engineName" class="form-control" placeholder="EngineName" aria-describedby="basic-addon1"/>
                </div>
                <!--施工图工作量-->
                <h2>施工图工作量</h2>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="paperPage">图纸张数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_paperPage" class="form-control" placeholder="PaperPage" aria-describedby="basic-addon1"/>
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="al">折合Al</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_al" class="form-control" placeholder="Al" aria-describedby="basic-addon1"/>
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="allDays">折合总工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_allDays" class="form-control" placeholder="AllDays" aria-describedby="basic-addon1"/>
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="finishedDays">本月完成工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_finishedDays" class="form-control" placeholder="FinishedDays" aria-describedby="basic-addon1"/>
                </div>
                <!--技术方案工作量-->
                <h3>技术方案工作量</h3>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="usedDays">所用工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_usedDays" class="form-control" placeholder="UsedDays" aria-describedby="basic-addon1"/>
                </div>
                <!--基本设计工作量-->
                <h3>基本设计工作量</h3>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="usedDays2">所用工日数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_usedDays2" class="form-control" placeholder="UsedDays2" aria-describedby="basic-addon1"/>
                </div>
                <!--专业负责人-->
                <h3>专业负责人</h3>
                <div class="input-group mb-3">
                    <p>此列不是写专业负责人名字，如果你是专业负责人，把操心的工作量折合工日写在此列</p>
                    <div class="input-group-prepend"> 
                        <span class="input-group-text" id="leaderDays">工日</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_leaderDays" class="form-control" placeholder="LeaderDays" aria-describedby="basic-addon1"/>
                </div>
                <!--备注-->
                <h2>备注</h2>
                <div class="input-group mb-3 remarksbox">     
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
                </div>

                 <!--本次填写查看及修改按钮-->
                <div id="box">
                    <!--修改-->
                    <div class="modifybox">
                        <asp:button runat="server" ID="modifybtn" Text="修改" class="btn btn-warning"  ></asp:button>
                    </div>
                    <!--查看-->
                    <div class="checkbox">
                        <asp:button runat="server" ID="checkbtn" Text="查看" class="btn btn-info"  ></asp:button>
                    </div>
                </div>

            </form>
        </div>
    </div>
</body>
</html>
