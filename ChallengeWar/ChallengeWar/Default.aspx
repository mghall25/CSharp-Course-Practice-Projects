<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeWar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            font-size: medium;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            font-size: x-large;
            background-color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <asp:Button ID="playButton" runat="server" CssClass="auto-style4" OnClick="playButton_Click" Text="Play War" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </div>
    </form>
</body>
</html>
