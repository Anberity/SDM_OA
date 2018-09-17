<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Working.aspx.cs" Inherits="form4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
                <h6 style="color:red;font-weight:bold">序号自动生成，填写工作量时不用填写，仅修改及删除时填写！！！</h6>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="index">序号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_index" class="form-control" placeholder="Index" aria-describedby="basic-addon1" />
                    <asp:Button ID="add" runat="server" class="btn btn-primary" Text="确认" OnClick="add_Click" />
                </div>
                
                <div class="line"></div>
                <h5>填写</h5>
                <!--项目名称-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_name">项目名称</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engineName" class="form-control" placeholder="EngineName" aria-describedby="basic-addon1" />
                </div>
                <!--商务询价报价-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="quotation">商务询价报价</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_quotation" class="form-control" placeholder="Quotation" aria-describedby="basic-addon1" />
                </div>
                <!--标书制作-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="tender">标书制作</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_tender" class="form-control" placeholder="Tender" aria-describedby="basic-addon1" />
                </div>
                <!--合同制作与签署-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="sign">合同制作与签署</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_sign" class="form-control" placeholder="Sign" aria-describedby="basic-addon1" />
                </div>
                <!--投标工作-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="bid">投标工作</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_bid" class="form-control" placeholder="Bid" aria-describedby="basic-addon1" />
                </div>
                <!--设备招标采购-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="equip">设备招标采购</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_equip" class="form-control" placeholder="Equip" aria-describedby="basic-addon1" />
                </div>
                <!--设备出厂检测-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="test">设备出厂检测</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_test" class="form-control" placeholder="Test" aria-describedby="basic-addon1" />
                </div>
                <!--催款（要账）-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="dun">催款（要账）</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_dun" class="form-control" placeholder="Dun" aria-describedby="basic-addon1" />
                </div>
                <!--合同管理-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="contract">合同管理</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_contract" class="form-control" placeholder="Contract" aria-describedby="basic-addon1" />
                </div>
                <!--其他经营活动-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="others">其他经营活动</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_others" class="form-control" placeholder="Others" aria-describedby="basic-addon1" />
                </div>
                <!--项目经理-->
                <h5>项目经理</h5>
                <p>此列不是写项目经理名字，如果你是项目经理，把操心的工作量折合工日写在此列</p>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="managerDays">项目经理</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_managerDays" class="form-control" placeholder="ManagerDays" aria-describedby="basic-addon1" />
                </div>
                <!--备注-->
                <h5>备注</h5>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1" />
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
    const add_quotationID = "<%=add_quotation.ClientID%>";
    const add_tenderID = "<%=add_tender.ClientID%>";
    const add_signID = "<%=add_sign.ClientID%>";
    const add_bidID = "<%=add_bid.ClientID%>";
    const add_equipID = "<%=add_equip.ClientID%>";
    const add_testID = "<%=add_test.ClientID%>";
    const add_dunID = "<%=add_dun.ClientID%>";
    const add_contractID = "<%=add_contract.ClientID%>";
    const add_othersID = "<%=add_others.ClientID%>";
    const add_managerDaysID = "<%=add_managerDays.ClientID%>";

    const add_index = document.getElementById(add_indexID);
    const add_quotation = document.getElementById(add_quotationID);
    const add_tender = document.getElementById(add_tenderID);
    const add_sign = document.getElementById(add_signID);
    const add_bid = document.getElementById(add_bidID);
    const add_equip = document.getElementById(add_equipID);
    const add_test = document.getElementById(add_testID);
    const add_dun = document.getElementById(add_dunID);
    const add_contract = document.getElementById(add_contractID);
    const add_others = document.getElementById(add_othersID);
    const add_managerDays = document.getElementById(add_managerDaysID);
    const submitBtn = document.getElementsByClassName('submit')[0];

    var arr = [add_quotation, add_tender, add_sign, add_bid, add_equip, add_test, add_dun, add_contract, add_others, add_managerDays];

    add_index.onblur = function () {
        ifIndex(this);
    };
    submitBtn.onclick = function () {
        var arr2 = [];
        var z = /^[0-9]+.?[0-9]*$| (^\s*)|(\s*$) /;
        let s;
        for (let i = 0; i < arr.length; i++) {
            //console.log(arr[i].value + ":" + typeof (arr[i].value));
            if (arr[i].value != "") {
                s = z.test(arr[i].value);
            } else {
                s = true;
            }
            arr2.push(s);
        }
        //console.log(arr2 + ":" + arr2.length);
        for (let i = 0; i < arr2.length; i++) {
            if (arr2[i] == false || arr2[i] == "false") {
                arr[i].value = "";
                alert("请输入有效数字");
                return false;
            }
        }
    };
</script>
</html>
