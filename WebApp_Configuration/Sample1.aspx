<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample1.aspx.cs" Inherits="WebApp_Configuration.Sample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Value of a is"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtSample1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Value of b is"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtSample2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button style="margin-left:120px;" ID="btnGetData" runat="server" Text="Get Data" OnClick="btnGetData_Click" />
        </div>
    </form>
</body>
</html>
