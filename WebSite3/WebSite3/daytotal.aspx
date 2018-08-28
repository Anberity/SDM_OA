<%@ Page Language="C#" AutoEventWireup="true" CodeFile="daytotal.aspx.cs" Inherits="daytotal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .box{
            width:213px;
            margin:30px auto;
        }
        table{
            margin-top:20px;
        }
    </style>
</head>
<body>
    
    <div class="box"> 
    <form id="form1" runat="server">
        <div class="form-group">
            <label for="month">选择月份</label>
            <select class="form-control" id="month">
              <option>1</option>
              <option>2</option>
              <option>3</option>
              <option>4</option>
              <option>5</option>
              <option>6</option>
              <option>7</option>
              <option>8</option>
              <option>9</option>
              <option>10</option>
              <option>11</option>
              <option>12</option>
            </select>
        </div>
        <asp:Button runat="server" ID="submit" Text="确认" type="button" class="btn btn-primary" />        
        <table class="table table-hover table-bordered table-responsive">
            <thead>
                <tr>
                    <td>员工姓名</td>  
                    <td>当日工日之和</td> 
                </tr>   
            </thead>
            <tbody>
                <tr>
                    <td>leo</td>
                    <td>111</td>
                </tr>
                <tr>
                    <td colspan="2">总计:</td>
                </tr>
            </tbody>
        </table>
        
    </form>
    </div>

</body>
</html>
