<%@ Page Language="C#" AutoEventWireup="true" CodeFile="date.aspx.cs" Inherits="date" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/bootstrap-datetimepicker.min.css"/>
    <link href="www/form.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap-datetimepicker.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <style>
        .container {
            width: 800px;
        }   
        .form-control:disabled, .form-control[readonly]{
            background:white;
        }
        .submit{
            justify-content: center;
        }
    </style>
</head>
<body>
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <form id="form" runat="server">
                <fieldset>
                    <div class="form-group">
                        <label for="dtp_input2" class="col-md-2 control-label">选择开始日期</label>
                        <div class="input-group date form_datetime col-md-5" data-date="" data-date-format="yyyy-m-d" data-link-field="dtp_input2" data-link-format="yyyy-mm-dd">
                            <asp:TextBox runat="server" ID="Start" class="form-control" size="16" type="text" value="" readonly/>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
			                <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                        </div>
		                <input type="hidden" id="dtp_input1" value="" /><br/>
                    </div>

                    <div class="form-group">
                        <label for="dtp_input2" class="col-md-2 control-label">选择结束日期</label>
                        <div class="input-group date form_date col-md-5" data-date="" data-date-format="yyyy-m-d" data-link-field="dtp_input2" data-link-format="yyyy-mm-dd">
                            <asp:TextBox runat="server" ID="End" size="16" class="form-control" type="text" value="" readonly/>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
				            <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                        </div>
			            <input type="hidden" id="dtp_input2" value="" /><br/>
                    </div>

                    <!--提交-->
                    <div class="submit">
                        <asp:button runat="server" Text="确认" class="btn btn-success" ID="Confirm" OnClick="Confirm_Click"></asp:button>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
    <script>
         $('.form_datetime').datetimepicker({
            weekStart: 0, //一周从哪一天开始
            minView:2,
            language:'zh-CN',
            bootcssVer:3,
            pickerPosition:"bottom-left",
            todayBtn:  1, //
            autoclose: 1,
            todayHighlight: 1,
            startView: 2,
            forceParse: 0,
            showMeridian: 1
        });
        $('.form_date').datetimepicker({
        weekStart: 0, //一周从哪一天开始
            minView:2,
            language:'zh-CN',
            bootcssVer:3,
            pickerPosition:"bottom-left",
            todayBtn:  1, //
            autoclose: 1,
            todayHighlight: 1,
            startView: 2,
            forceParse: 0,
            showMeridian: 1
        });
</script>
</body>
</html>
