<%@ Page Language="C#" AutoEventWireup="true" CodeFile="personform.aspx.cs" Inherits="Defaul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="www/form.css" rel="stylesheet" />
    <style>
        .formbox {
            min-width: 6000px;
            display: flex;
        }
    </style>
</head>
<body>
    <div class="formbox">
        <table class="table table-hover table-bordered table-responsive box1">
            <thead>
                <tr>
                    <th scope="col" colspan="11">设计工作量</th>
                    <th scope="col" colspan="7">编程/画面工作量</th>
                    <th scope="col" colspan="5">调试/工程管理工作量</th>
                    <th scope="col" colspan="12">经营工作量</th>
                    <th scope="col" colspan="11">日常管理工作量</th>
                    <th scope="col" colspan="4">零星工日</th>
                </tr>
                <tr>
                    <th scope="col">序号</th>
                    <th scope="col">工程号</th>
                    <th scope="col">工程名称</th>
                    <th scope="col">施工图工作量图纸张数</th>
                    <th scope="col">施工图工作量折合A1</th>
                    <th scope="col">施工图工作量折合总工日数</th>
                    <th scope="col">技术方案工作量所用工日数</th>
                    <th scope="col">基本设计工作量所用工日数</th>
                    <th scope="col">专业负责人</th>
                    <th scope="col">备注</th>

                    <th scope="col">项目名称</th>
                    <th scope="col">总开关量点数</th>
                    <th scope="col">总模拟量点数</th>
                    <th scope="col">编程/画面</th>
                    <th scope="col">总工日数</th>
                    <th scope="col">本月完成工日数</th>
                    <th scope="col">备注</th>

                    <th scope="col">项目名称</th>
                    <th scope="col">项目地点</th>
                    <th scope="col">本月工程管理天数</th>
                    <th scope="col">本月调试天数</th>
                    <th scope="col">备注</th>

                    <th scope="col">项目名称</th>
                    <th scope="col">商务询价报价</th>
                    <th scope="col">标书制作</th>
                    <th scope="col">合同制作与签署</th>
                    <th scope="col">投标工作</th>
                    <th scope="col">设备招标采购</th>
                    <th scope="col">设备出厂检测</th>
                    <th scope="col">催款（要账）</th>
                    <th scope="col">合同管理</th>
                    <th scope="col">其他经营活动</th>
                    <th scope="col">项目经理</th>
                    <th scope="col">备注</th>

                    <th scope="col">部门内部</th>
                    <th scope="col">工会事务</th>
                    <th scope="col">党组事务</th>
                    <th scope="col">团组事务</th>
                    <th scope="col">体系内审/外审</th>
                    <th scope="col">考勤</th>
                    <th scope="col">电话费报销</th>
                    <th scope="col">餐费报销</th>
                    <th scope="col">其他报销</th>
                    <th scope="col">每月工作量统计汇总</th>
                    <th scope="col">备注</th>

                    <th scope="col">本月出差天数</th>
                    <th scope="col">技术交流天数</th>
                    <th scope="col">其他零星工日</th>
                    <th scope="col">备注</th>
                </tr>
            </thead>
            <tbody id="tbody">
                <!--第一行-->
                <tr>
                    <td>1</td>
                    <td>11</td>
                    <td>@mdo</td>
                    <td>@2</td>
                    <td>@2</td>
                    <td>@3</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                    <td>@leo</td>
                </tr>
            </tbody>
        </table>

    </div>
</body>
<script>
        var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
        /*$(document).ready(function () {
            var tbody = document.getElementsByTagName('tboody')[0];

            tbody.append(`<tr></tr>`)
        });*/
        var tbody = document.getElementById('tbody');

        for(let i=0;i<10;i++){
            var atr = document.createElement('tr');
            //var ath = document.createElement('th');
            atr.innerHTML = "<th>"+i+"</th>"
            for (let j = 1; j < arr.length; j++) {

                atr.innerHTML += "<td>"+arr[j]+"</td>";
            }
            tbody.appendChild(atr);
        }

</script>

</html>

