<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .auto-style2 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>
            <asp:Button ID="okButton" runat="server" CssClass="auto-style2" Height="38px" OnClick="okButton_Click" Text="Play" Width="140px" />
            </strong>
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </div>
    </form>
</body>
</html>
