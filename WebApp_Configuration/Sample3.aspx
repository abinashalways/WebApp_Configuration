<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample3.aspx.cs" Inherits="WebApp_Configuration.Sample3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button style="margin-left:120px;" ID="btnGetData" runat="server" Text="Get Data" OnClick="btnGetData_Click"  />
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="734px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
