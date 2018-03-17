<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SlotMachine.aspx.cs" Inherits="ChallengeSlotMachine.SlotMachine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="SlotMachine.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style3 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="slots">            
            <asp:Image ID="image1" runat="server" Height="200px" Width="200px" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style3" />
            <asp:Image ID="image2" runat="server" Height="200px" Width="200px" BorderStyle="Solid" BorderWidth="1px" />
            <asp:Image ID="image3" runat="server" Height="200px" Width="200px" BorderStyle="Solid" BorderWidth="1px" />
        </div>
        <div class ="status">
            <h2>
                Your Bet: $<strong><asp:TextBox ID="betTextBox" runat="server" Wrap="False" Height="35px" Width="127px"></asp:TextBox>
                </strong>
            </h2>
            <asp:Button ID="pullLeverButton" runat="server" BorderStyle="Outset" OnClick="pullLever" Text="Pull the Lever!" BorderColor="Black" BorderWidth="3px" Font-Bold="True" Font-Overline="False" Font-Size="Large" Height="85px" Width="294px" BackColor="#CC0000" />
            
            <h2 id="resultLabel" class="auto-style3">
                    <asp:Label ID="resultsLabel" runat="server" CssClass="auto-style5" style="font-weight: normal; font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif"></asp:Label>
            </h2>
            <h2>
                Cash Pot:
                $<strong><asp:Label ID="cashBalLabel" runat="server"></asp:Label>
                </strong>
            </h2>
        </div>
        <div class="rules-container">
            <p><strong>Rules:</strong></p>
            <p>1 Cherry - You win 2 x your bet</p>
            <p>2 Cherries&nbsp;- You win 3 x your bet</p>
            <p>3 Cherries&nbsp;- You win 4 x your bet</p>
            <p>3 7s&nbsp;- You win 100 x your bet!</p>
            <p>Any BARs -&nbsp;You win nothing</p>
        </div>
    </form>
</body>
</html>
