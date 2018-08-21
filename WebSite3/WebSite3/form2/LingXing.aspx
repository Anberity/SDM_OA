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
                <h2>修改备注</h2>
                <!--备注-->
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="select_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
                </div>
                <h2>查看/修改内容</h2>
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
                <h2>备注</h2>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_remarks" class="form-control" placeholder="Remarks" aria-describedby="basic-addon1"/>
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
