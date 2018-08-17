<%@ Page Language="C#" AutoEventWireup="true" CodeFile="employees.aspx.cs" Inherits="employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <!--value值不确定暂时没更改-->
    <form id="form1" runat="server">
        <asp:TreeView ID="NavList" runat="server" Height="379px" ImageSet="Arrows">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                
                <asp:TreeNode Text="设计工作量" Value="work1">
                    <asp:TreeNode Text="序号" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="工程号" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="工程名称" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="施工图工作量" Value="新建节点">
                        <asp:TreeNode Text="图纸张数" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="折合A1" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="折合总工日数" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="本月完成工日数" Value="新建节点"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="技术方案工作量" Value="新建节点">
                        <asp:TreeNode Text="所用工日数" Value="所用工日数"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="基本设计工作量" Value="新建节点">
                        <asp:TreeNode Text="所用工日数" Value="所用工日数"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="专业负责人" Value="专业负责人">
                        <asp:TreeNode Text="操心工作量" Value="操心工作量"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="备注" Value="备注"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="编程/画面工作量" Value="work2">
                    <asp:TreeNode Text="项目名称" Value="项目名称"></asp:TreeNode>
                    <asp:TreeNode Text="总开关量点数" Value="总开关量点数"></asp:TreeNode>
                    <asp:TreeNode Text="总模拟量点数" Value="总模拟量点数"></asp:TreeNode>
                    <asp:TreeNode Text="编程/画面" Value="编程/画面"></asp:TreeNode>
                    <asp:TreeNode Text="总工日数(本月工日统计中，不统计此列)" Value="总工日数(本月工日统计中，不统计此列)"></asp:TreeNode>
                    <asp:TreeNode Text="本月完成工日数" Value="本月完成工日数"></asp:TreeNode>
                    <asp:TreeNode Text="备注" Value="备注"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="调试/工程管理工作量" Value="work3">
                    <asp:TreeNode Text="项目名称" Value="项目名称"></asp:TreeNode>
                    <asp:TreeNode Text="项目地点" Value="项目地点"></asp:TreeNode>
                    <asp:TreeNode Text="本月工程管理天数" Value="本月工程管理天数"></asp:TreeNode>
                    <asp:TreeNode Text="本月调试天数" Value="本月调试天数"></asp:TreeNode>
                    <asp:TreeNode Text="备注" Value="备注"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="经营工作量" Value="work4">
                    <asp:TreeNode Text="项目名称" Value="项目名称"></asp:TreeNode>
                    <asp:TreeNode Text="商务询价报价" Value="商务询价报价"></asp:TreeNode>
                    <asp:TreeNode Text="标书制作" Value="标书制作"></asp:TreeNode>
                    <asp:TreeNode Text="合同制作与签署" Value="合同制作与签署"></asp:TreeNode>
                    <asp:TreeNode Text="投标工作" Value="投标工作"></asp:TreeNode>
                    <asp:TreeNode Text="设备招标采购" Value="设备招标采购"></asp:TreeNode>
                    <asp:TreeNode Text="设备出厂检测" Value="设备出厂检测"></asp:TreeNode>
                    <asp:TreeNode Text="催款(要账)" Value="催款(要账)"></asp:TreeNode>
                    <asp:TreeNode Text="合同管理" Value="合同管理"></asp:TreeNode>
                    <asp:TreeNode Text="其他经营活动" Value="其他经营活动"></asp:TreeNode>
                    <asp:TreeNode Text="项目经理" Value="项目经理">
                        <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="日常管理工作量" Value="work5"></asp:TreeNode>
                <asp:TreeNode Text="零星工日" Value="work6"></asp:TreeNode>
                <asp:TreeNode Text="本月工作之和" Value="work7"></asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </form>
</body>
</html>
