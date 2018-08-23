<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        <form id="form" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <td>编号</td>
                            <td>用户名</td>
                            <td>用户密码</td>
                            <td>用户类型</td>
                            <td>用户类型</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr><td><%#Eval("projectname") %></td>
                        <td><%#Eval("site") %></td>
                        <td><%#Eval("manageday") %></td>
                        <td><%#Eval("debugday") %></td>
                        <td><%#Eval("remark") %></td>
                        <%--<td><%#DataBinder.Eval(Container.DataItem,"projectname") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem,"site") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem,"manageday") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem,"debugday") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem,"remark") %></td>--%>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
