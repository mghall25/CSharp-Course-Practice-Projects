<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengeConditionalRadioButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Your Note-Taking Preference</h1>
            <asp:RadioButton ID="pencilRadio" runat="server" GroupName="noteGroup" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadio" runat="server" GroupName="noteGroup" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadio" runat="server" GroupName="noteGroup" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadio" runat="server" GroupName="noteGroup" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="OkBtn" runat="server" OnClick="OkBtn_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Image ID="selectedImg" runat="server" Width="400px" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
