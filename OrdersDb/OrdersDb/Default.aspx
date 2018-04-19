<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OrdersDb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Default.css" rel="stylesheet" />
    <title>Pizza Order Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container wrapper">
            <div class="jumbotron">
                <h1>Papa Bob's Pizza Order Form</h1>
                <p class="lead">Pizza to Code By</p>
            </div>
            <div class="inner-wrapper">
                <div class="form-group">
                    <h2>Pizza</h2>
                    <label><strong>Size</strong>:</label>
                    <asp:DropDownList ID="sizeDropDown" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Small (12 inch - $12)" Value="0" />
                        <asp:ListItem Text="Medium (14 inch - $14)" Value="1" />
                        <asp:ListItem Text="Large (16 inch - $16)" Value="2" />
                    </asp:DropDownList>
                </div>
                    <div class="form-group">
                    <label><strong>Crust</strong>:</label>
                    <asp:DropDownList ID="crustDropDown" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Regular" Value="0" />
                        <asp:ListItem Text="Thin" Value="1" />
                        <asp:ListItem Text="Thick ($2)" Value="2" />
                    </asp:DropDownList>
                </div>
                <div>
                     <label><strong>Toppings</strong>:</label>
                    <div class="checkbox"><label><asp:CheckBox ID="Sausage" runat="server"></asp:CheckBox>&nbsp;Sausage (+ $2.00)</label></div>
                    <div class="checkbox"><label><asp:CheckBox ID="Pepperoni" runat="server"></asp:CheckBox>&nbsp;Pepperoni (+ $1.50)</label></div>
                    <div class="checkbox"><label><asp:CheckBox ID="Onion" runat="server"></asp:CheckBox>&nbsp;Onions (+ $1.00)</label></div>
                    <div class="checkbox"><label><asp:CheckBox ID="GreenPepper" runat="server"></asp:CheckBox>&nbsp;Green Peppers (+ $1.00)</label><br /></div>
                </div>
			
			    <div>
                    <p>&nbsp;</p>
                    <h2>Deliver To</h2>
				    <div class="form-group">
					    <label>Name:</label>
					    <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
				    </div>
				    <div class="form-group">
					    <label>Address:</label>
					    <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
				    </div>
				    <div class="form-group">
					    <label>Zip:</label>
					    <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
				    </div>
				    <div class="form-group">
					    <label>Phone:</label>
					    <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
				        <br />
				    </div>
			    </div>
			
			    <div class="container">
                    <h2>Payment</h2>	
                    <div class="row col-md-6">
				        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentGroup"></asp:RadioButton>Cash</label></div>
                    </div>
                    <div class="row col-md-6">
				        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="paymentGroup"></asp:RadioButton>Credit</label></div>
                    </div>
			    <br />
                <asp:Label ID="errorLabel" runat="server"></asp:Label>
			    </div>
			    <br />
			    <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" />
                <br />
                <br />
			    <div>
			        <h2 class="float:left">Total Cost:
                        <asp:Label ID="totalCostLabel" runat="server"></asp:Label>
                        </h2>
                    <p class="float:left">&nbsp;</p>
                    <p class="float:left">
                        <asp:GridView ID="ordersGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="OrderId" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." GridLines="Vertical">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:BoundField DataField="OrderId" HeaderText="OrderId" ReadOnly="True" SortExpression="OrderId" />
                                <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                                <asp:BoundField DataField="Crust" HeaderText="Crust" SortExpression="Crust" />
                                <asp:CheckBoxField DataField="Sausage" HeaderText="Sausage" SortExpression="Sausage" />
                                <asp:CheckBoxField DataField="Pepperoni" HeaderText="Pepperoni" SortExpression="Pepperoni" />
                                <asp:CheckBoxField DataField="Onion" HeaderText="Onion" SortExpression="Onion" />
                                <asp:CheckBoxField DataField="Green_Pepper" HeaderText="Green_Pepper" SortExpression="Green_Pepper" />
                                <asp:BoundField DataField="TotalCost" HeaderText="TotalCost" SortExpression="TotalCost" />
                                <asp:CheckBoxField DataField="Completed" HeaderText="Completed" SortExpression="Completed" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PapaBobsConnectionString %>" SelectCommand="SELECT [OrderId], [Size], [Crust], [Sausage], [Pepperoni], [Onion], [Green Pepper] AS Green_Pepper, [TotalCost], [Completed] FROM [Orders]"></asp:SqlDataSource>
                        </p>
                    <p class="float:left">&nbsp;</p>
			    </div>          
            </div>
        </div>
    </form>

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
</body>
</html>
