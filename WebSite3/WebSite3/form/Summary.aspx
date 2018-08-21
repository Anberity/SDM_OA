<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="form7" %>

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
                <!--天数-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="workDays">本月工作日之和</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_workDays" class="form-control" placeholder="WorkDays" aria-describedby="basic-addon1"/>
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
