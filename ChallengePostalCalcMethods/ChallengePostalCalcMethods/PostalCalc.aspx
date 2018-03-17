<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostalCalc.aspx.cs" Inherits="ChallengePostalCalcMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="PostalCalc.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="width: 564px">
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Postal Calculator</h1>
            <div class="section">
                <h3>Package Dimensions</h3>
                Width:&nbsp;
                <asp:TextBox ID="widthTextBox" runat="server" Height="25px" Width="50px" AutoPostBack="True" OnTextChanged="onHandleChange" TabIndex="1"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Height:&nbsp;
                <asp:TextBox ID="heightTextBox" runat="server" Height="25px" Width="50px" AutoPostBack="True" OnTextChanged="onHandleChange" TabIndex="2"></asp:TextBox>
&nbsp;&nbsp; Length:&nbsp;
                <asp:TextBox ID="lengthTextBox" runat="server" Height="25px" Width="50px" AutoPostBack="True" OnTextChanged="onHandleChange" TabIndex="3"></asp:TextBox>
                &nbsp; inches<br />
                <br />
                <h3>Shipping Method</h3>
                <asp:RadioButton ID="groundShippingRadio" runat="server" GroupName="ShippingMethod" Text="Ground" AutoPostBack="True" OnCheckedChanged="onHandleChange" TabIndex="4" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="airShippingRadio" runat="server" GroupName="ShippingMethod" Text="Air" AutoPostBack="True" OnCheckedChanged="onHandleChange" TabIndex="5" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="nextDayShippingRadio" runat="server" GroupName="ShippingMethod" Text="Next Day" AutoPostBack="True" OnCheckedChanged="onHandleChange" TabIndex="6" />
                <br />
                <br />
            </div>
            <p>
                <strong><asp:Label ID="msgLabel" runat="server"></asp:Label>
                </strong></p>
        </div>
    </form>
</body>
</html>
