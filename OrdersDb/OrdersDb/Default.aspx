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
			    </div>          
            </div>
        </div>
    </form>

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
</body>
</html>
