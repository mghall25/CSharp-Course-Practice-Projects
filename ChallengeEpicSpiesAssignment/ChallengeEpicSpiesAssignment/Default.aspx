<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .auto-style2 {
            font-weight: bold;
        }
        .auto-style3 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="logoImage" runat="server" Height="100px" ImageUrl="~/epic-spies-logo.jpg" />
        </div>
        <h1 class="auto-style1">Spy New Assignment Form</h1>
        <p class="auto-style1">
            Spy Code Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SpyNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            New Assignment Name:
            <asp:TextBox ID="AssnNameTextBox" runat="server"></asp:TextBox>
&nbsp;</p>
        <p class="auto-style1">
            <strong>End Date of Previous Assignment </strong>
        </p>
        <p class="auto-style1">
            <asp:Calendar ID="PrevEndCal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="PrevEndCal_SelectionChanged">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </p>
        <p class="auto-style1">
            <strong>New Assignment Start Date</strong></p>
        <p class="auto-style1">
            <asp:Calendar ID="NewStartCal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </p>
        <p class="auto-style1">
            <strong>New Assignment End Date</strong></p>
        <p class="auto-style1">
            <asp:Calendar ID="NewEndCal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </p>
        <p class="auto-style1">
            <strong>
            <asp:Button ID="AssignBtn" runat="server" BackColor="#999999" CssClass="auto-style2" Font-Bold="True" Font-Size="Medium" Height="40px" OnClick="AssignBtn_Click" Text="Assign Spy" Width="200px" />
            </strong>
        </p>
        <p class="auto-style1">
            <strong>
            <asp:Label ID="msgLbl" runat="server" CssClass="auto-style3"></asp:Label>
            </strong>
        </p>
    </form>
</body>
</html>
