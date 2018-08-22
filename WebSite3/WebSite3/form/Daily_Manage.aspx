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
                <h2>修改索引</h2>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="index">序号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_index" class="form-control" placeholder="Index" aria-describedby="basic-addon1"/>
                </div>
                <h2>填写</h2>
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
                <!--电话费报销-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="tel">电话费报销</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_tel" class="form-control" placeholder="Tel" aria-describedby="basic-addon1"/>
                </div>
                <!--餐费报销-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="meal">餐费报销</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_meal" class="form-control" placeholder="Meal" aria-describedby="basic-addon1"/>
                </div>
                <!--其他报销-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="others">其他报销</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_others" class="form-control" placeholder="Others" aria-describedby="basic-addon1"/>
                </div>
                <!--每月工作量统计汇总-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="statistics">每月工作量统计汇总</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_statistics" class="form-control" placeholder="Statistics" aria-describedby="basic-addon1"/>
                </div>
      
                <!--备注-->
                <h2>备注</h2>
                <div class="input-group remarksbox">
                    <asp:TextBox TextMode="MultiLine" ID="add_remarks" placeholder="Remarks" runat="server" class="form-control " aria-label="With textarea"></asp:TextBox>
                </div>
                <!--本次工作量填写及修改按钮-->
                <div id="box">
                    <!--修改-->
                    <div class="modifybox">
                        <asp:button runat="server" ID="modifybtn" Text="修改" class="btn btn-warning" OnClick="modifybtn_Click"  ></asp:button>
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
