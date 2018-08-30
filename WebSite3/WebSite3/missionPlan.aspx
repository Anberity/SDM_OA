<%@ Page Language="C#" AutoEventWireup="true" CodeFile="missionPlan.aspx.cs" Inherits="missionPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/bootstrap-datetimepicker.min.css"/>
    <link href="www/form.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap-datetimepicker.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <style>
        #time{
            width:600px;
        }
        #time .form-group{
            margin-left:-4px;
        }
        #Start,#End{
            background:#fff;
        }
        .start,.end{
            display:flex;
        }
        .start .control-label,.end .control-label{
            padding-top:4px;
        }
        h2{
            text-align:center;
            margin-bottom:20px;
        }
    </style>
</head>
<body>
    <div class="jumbotron jumbotron-fluid">
        <h2>编程任务计划书</h2>
        <div class="container">
            
            <form id="program" runat="server">
                <!--项目名称-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="engine_name">项目名称</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_engineName" class="form-control" placeholder="EngineName" aria-describedby="basic-addon1"/>
                </div>
                <!--工程编号-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="number">工程编号</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_number" class="form-control" placeholder="Number" aria-describedby="basic-addon1"/>
                </div>
                <!--编程软件-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="ide">编程软件</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_ide" class="form-control" placeholder="Ide" aria-describedby="basic-addon1"/>
                </div>
                <!--任务接收人-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="recipient">任务接收人</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_recipient" class="form-control" placeholder="Recipient" aria-describedby="basic-addon1"/>
                </div>
                <!--审核人-->
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="auditor">审核人</span>
                    </div>
                    <asp:TextBox runat="server" ID="add_auditor" class="form-control" placeholder="Auditor" aria-describedby="basic-addon1"/>
                </div>
                <!--开始时间-->
                <fieldset id="time">
                    <div class="form-group start">
                        <label for="dtp_input2" class="col-md-2 control-label">开始时间</label>
                        <div class="input-group date form_datetime col-md-5" data-date="" data-date-format="yyyy-mm-dd" data-link-field="dtp_input2" data-link-format="yyyy-mm-dd">
                            <asp:TextBox runat="server" ID="Start" class="form-control" size="16" type="text" value="" readonly/>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
			                <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                        </div>
		                <input type="hidden" id="dtp_input1" value="" /><br/>
                    </div>
                <!--结束时间-->
                    <div class="form-group end">
                        <label for="dtp_input2" class="col-md-2 control-label">结束时间</label>
                        <div class="input-group date form_date col-md-5" data-date="" data-date-format="yyyy-mm-dd" data-link-field="dtp_input2" data-link-format="yyyy-mm-dd">
                            <asp:TextBox runat="server" ID="End" size="16" class="form-control" type="text" value="" readonly/>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
				            <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                        </div>
			            <input type="hidden" id="dtp_input2" value="" /><br/>
                    </div>
                </fieldset>
                <!--备注-->
                <h5>已有资料</h5>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_info" class="form-control" placeholder="Information" aria-describedby="basic-addon1"/>
                </div>
                <!--编程质量要求-->
                <h5>编程质量要求</h5>
                <div class="input-group mb-3 remarksbox">
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="add_require" class="form-control" placeholder="Require" aria-describedby="basic-addon1"/>
                </div>
                <!--提交-->
                <div class="submit">
                    <asp:button runat="server" ID="submit" Text="提交" class="btn btn-success"></asp:button>
                </div>
            </form>
        </div>
    </div>
</body>
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
</html>
