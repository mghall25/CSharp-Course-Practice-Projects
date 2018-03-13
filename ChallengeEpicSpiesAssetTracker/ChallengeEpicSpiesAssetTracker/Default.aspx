<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/epic-spies-logo.jpg" />
&nbsp;<h1 class="auto-style1">Asset Performance Tracker</h1>
            <p class="auto-style1">
                Asset Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="AssetNameText" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
                Elections Rigged:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="electionsText" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
                Acts of Subterfuge Performed:&nbsp;
                <asp:TextBox ID="actsText" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
                <strong>
                <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" style="height: 26px" Text="Add Asset" />
                </strong>
            </p>
            <p class="auto-style1">
                <strong>
                <asp:Label ID="msgLabel" runat="server"></asp:Label>
                </strong>
            </p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                * Assumption made in calculation of average acts per asset: each asset&#39;s performance is entered only once.
            </p>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
