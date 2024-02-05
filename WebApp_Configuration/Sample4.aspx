<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample4.aspx.cs" Inherits="WebApp_Configuration.Sample4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEID" runat="server"></asp:TextBox>
            <asp:Button ID="btnGet" style="margin-left:20px" runat="server" Text="Get" Width="87px" OnClick="btnGet_Click"  />

            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Name"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtEName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Select Photo"></asp:Label>
&nbsp;&nbsp;
            &nbsp;&nbsp;<asp:FileUpload ID="FileUpload1" runat="server"  />
            <br />
            <asp:Button ID="btnSubmit" style="margin-left:97px" runat="server" Text="Submit" Width="87px" OnClick="btnSubmit_Click" />

            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
            <br />
          
        </div>
        <asp:Image ID="Image1" runat="server" Width="381px" />
    </form>
</body>
</html>
