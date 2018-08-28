<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo.aspx.cs" Inherits="Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/jedate.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:Textbox runat="server" class="workinput wicon" id="custom1"/>
        <asp:Button runat="server" Text="提交" ID="submit" OnClick="submit_Click" />
    </form>
</body>
    <script src="Scripts/jeDate.js"></script>
    <script type="text/javascript">
        // 时间
        $('#custom1').jeDate({
            isinitVal: true,
            // 分隔符可以任意定义，该例子表示只显示年月
            format: 'YYYY-MM'
            // 可以将此改为    `format: 'YYYY'`     表示只显示年的插件
        });
    </script>
</html>
