<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Working.aspx.cs" Inherits="form4" %>

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
                <!--商务询价报价-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="quotation">商务询价报价</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_quotation" class="form-control" placeholder="Quotation" aria-describedby="basic-addon1"/>
                </div>
                <!--标书制作-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="tender">标书制作</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_tender" class="form-control" placeholder="Tender" aria-describedby="basic-addon1"/>
                </div>
                <!--合同制作与签署-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="sign">合同制作与签署</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_sign" class="form-control" placeholder="Sign" aria-describedby="basic-addon1"/>
                </div>
                <!--投标工作-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="bid">投标工作</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_bid" class="form-control" placeholder="Bid" aria-describedby="basic-addon1"/>
                </div>
                <!--设备招标采购-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="equip">设备招标采购</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_equip" class="form-control" placeholder="Equip" aria-describedby="basic-addon1"/>
                </div>
                <!--设备出厂检测-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="test">设备出厂检测</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_test" class="form-control" placeholder="Test" aria-describedby="basic-addon1"/>
                </div>
                <!--催款（要账）-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="dun">催款（要账）</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_dun" class="form-control" placeholder="Dun" aria-describedby="basic-addon1"/>
                </div>
                <!--合同管理-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="contract">合同管理</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_contract" class="form-control" placeholder="Contract" aria-describedby="basic-addon1"/>
                </div>
                <!--其他经营活动-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="others">其他经营活动</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_others" class="form-control" placeholder="Others" aria-describedby="basic-addon1"/>
                </div>
                <!--项目经理-->
                <h3>项目经理</h3>
                <p>此列不是写项目经理名字，如果你是项目经理，把操心的工作量折合工日写在此列</p>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="managerDays">项目经理</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_managerDays" class="form-control" placeholder="ManagerDays" aria-describedby="basic-addon1"/>
                </div>
                <!--备注-->
                <h2>备注</h2>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
                </div>
                <!--增加-->
                <div class="submit">
                    <asp:button runat="server" ID="submit" Text="增加" class="btn btn-success" OnClick="submit_Click" ></asp:button>
                </div>


                 

            </form>
        </div>
    </div>
</body>
</html>
