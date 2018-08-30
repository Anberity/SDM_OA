<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Daily_Manage.aspx.cs" Inherits="form5" %>

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
                <!--部门内部日常管理-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="management">部门内部日常管理</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_management" class="form-control" placeholder="Management" aria-describedby="basic-addon1"/>
                </div>
                <!--工会事务-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="affair">工会事务</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_affair" class="form-control" placeholder="Affair" aria-describedby="basic-addon1"/>
                </div>
                <!--党组事务-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="affair2">党组事务</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_affair2" class="form-control" placeholder="Affair" aria-describedby="basic-addon1"/>
                </div>
                <!--团组事务-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="affair3">团组事务</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_affair3" class="form-control" placeholder="Affair" aria-describedby="basic-addon1"/>
                </div>
                <!--体系内审/外审-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="examine">体系内审/外审</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_examine" class="form-control" placeholder="Examine" aria-describedby="basic-addon1"/>
                </div>
                <!--考勤-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="check">考勤</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_check" class="form-control" placeholder="Check" aria-describedby="basic-addon1"/>
                </div>
                <!--其他报销-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="others">其他报销</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_others" class="form-control" placeholder="Others" aria-describedby="basic-addon1"/>
                </div>
                <!--备注-->
                <h5>备注</h5>
                <div class="input-group remarksbox">
                    <asp:TextBox TextMode="MultiLine" ID="add_remarks" placeholder="Remarks" runat="server" class="form-control " aria-label="With textarea"></asp:TextBox>
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
</body>
<script>
    const add_indexID = "<%=add_index.ClientID%>";
    const add_managementID = "<%=add_management.ClientID%>";
    const add_affairID = "<%=add_affair.ClientID%>";
    const add_affair2ID = "<%=add_affair2.ClientID%>";
    const add_affair3ID = "<%=add_affair3.ClientID%>";
    const add_examineID = "<%=add_examine.ClientID%>";
    const add_checkID = "<%=add_check.ClientID%>";
    const add_othersID = "<%=add_others.ClientID%>";
    

    const add_index = document.getElementById(add_indexID);
    const add_management = document.getElementById(add_managementID);
    const add_affair = document.getElementById(add_affairID);
    const add_affair2 = document.getElementById(add_affair2ID);
    const add_affair3 = document.getElementById(add_affair3ID);
    const add_examine = document.getElementById(add_examineID);
    const add_check = document.getElementById(add_checkID);
    const add_others = document.getElementById(add_othersID);

    add_index.onblur = function () {
        if (!/^[1-9]\d*$/.test(add_index.value)) {
            alert("请输入正确序号");
            this.value = "";
        }
    };
    add_management.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_management.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_affair.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_affair.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_affair2.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_affair2.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_affair3.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_affair3.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_examine.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_examine.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_check.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_check.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_others.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_others.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
</script>
</html>
