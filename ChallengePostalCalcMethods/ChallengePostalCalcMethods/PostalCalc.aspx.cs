using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalcMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                widthTextBox.Focus();          
            }
        }

        // ---------------- main helper method ---------------------------------
        protected void onHandleChange(object sender, EventArgs e)
        {
            // continue only if requirements are met
            if (!(requiredDimensions() && requiredShipMethod())) return;

            // get shipping multiplier
            double shipMultiplier;
            getMultiplier(out shipMultiplier);

            // calc and display the cost
            calculateShippingCost(shipMultiplier);
        }

        // determie whether a positive number has been entered for width and height and
        // a positive number OR a blank has been entered for length
        private bool requiredDimensions()
        {
            if (toNum(widthTextBox.Text)>0 && toNum(heightTextBox.Text)>0 && 
               (toNum(lengthTextBox.Text)>0 || lengthTextBox.Text.Trim().Length==0))   
            {
                return true;
            }
            else return false;
        }

        // determine whether a shipping method has been selected
        private bool requiredShipMethod()
        {
            if (airShippingRadio.Checked==false && groundShippingRadio.Checked==false && nextDayShippingRadio.Checked==false)
            {
                return false;
            }
            else return true;
        }

        // convert string to a positive number if possible. If result is not a positive number, return 0. 
        private double toNum(string textVal)
        {
            double parsedVal;
            if (!Double.TryParse(textVal, out parsedVal) || parsedVal<=0)
                return 0.0;
            else return parsedVal;
        }

        // determine shipping multiplier
        private void getMultiplier(out double shipMultiplier)
        {
            if (groundShippingRadio.Checked) shipMultiplier = .15;
            else if (airShippingRadio.Checked) shipMultiplier = .25;
            else shipMultiplier = .45;
        }

        private void calculateShippingCost(double shipMultiplier)
        {
            double width = toNum(widthTextBox.Text);
            double height = toNum(heightTextBox.Text);
            double length;

            // if length is blank, set it to 1
            if (lengthTextBox.Text.Trim().Length == 0) length = 1.0;
            else length = toNum(lengthTextBox.Text);

            double shipCost = width * height * length * shipMultiplier;
            msgLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", shipCost);
        }
        
    }
}