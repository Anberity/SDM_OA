<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LingXing.aspx.cs" Inherits="form6" %>

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
                <!--本月出差天数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="business">本月出差天数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_business" class="form-control" placeholder="Business" aria-describedby="basic-addon1"/>
                </div>
                <!--技术交流天数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="technical">技术交流天数</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_technical" class="form-control" placeholder="Technical" aria-describedby="basic-addon1"/>
                </div>
                <!--其他零星工日-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="others">其他零星工日</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_others" class="form-control" placeholder="Others" aria-describedby="basic-addon1"/>
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
</body>
<script>
    const add_indexID = "<%=add_index.ClientID%>";
    const add_businessID = "<%=add_business.ClientID%>";
    const add_technicalID = "<%=add_technical.ClientID%>";
    const add_othersID = "<%=add_others.ClientID%>";

    const add_index = document.getElementById(add_indexID);
    const add_business = document.getElementById(add_businessID);
    const add_technical = document.getElementById(add_technicalID);
    const add_others = document.getElementById(add_othersID);

    add_index.onblur = function () {
        if (!/^[1-9]\d*$/.test(add_index.value)) {
            alert("请输入正确序号");
            this.value = "";
        }
    };
    add_business.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_business.value)) {
            alert("请输入正确数字");
            this.value = "";
        }
    }
    add_technical.onblur = function () {
        if (!/^\d+(\.\d{1,2})?$/.test(add_technical.value)) {
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
