using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrdersDb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayOrders();                     // display customers
        }

        // add information entered to an order in the DTO layer and Add it to the Domain layer
        // Later: don't add it to the domain layer here. Add it to domain layer from DTO layer
        protected void okButton_Click(object sender, EventArgs e)
        {
            // add info entered to a new order in DTO layer
            var newOrder = new DTO.Order();

            newOrder.OrderId = Guid.NewGuid();        // create orderId here
            newOrder.Size = sizeDropDown.SelectedIndex;
            newOrder.Crust = crustDropDown.SelectedIndex;
            newOrder.Sausage = Sausage.Checked;
            newOrder.Pepperoni = Pepperoni.Checked;
            newOrder.Onion = Onion.Checked;
            newOrder.GreenPepper = GreenPepper.Checked;
            newOrder.Name = nameTextBox.Text;
            newOrder.Address = addressTextBox.Text;
            newOrder.Zip = zipTextBox.Text;
            newOrder.Phone = phoneTextBox.Text;

            if (cashRadioButton.Checked) {
                newOrder.PaymentType = 0;            
            }            
            else
            {
                newOrder.PaymentType = 1;
            }
                         

            try
            {
                Domain.OrderManager.AddOrder(newOrder);
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;      // display error to user. later: improve
            }

            displayOrders();                     // refresh display of order gridview

        }

        // displays the grid
        private void displayOrders()
        {
            var customers = Domain.OrderManager.GetOrders();

            ordersGridView.DataSource = customers.ToList();
            ordersGridView.DataBind();

        }
    }
}