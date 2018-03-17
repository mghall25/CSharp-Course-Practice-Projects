using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSlotMachine
{
    public partial class SlotMachine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState.Add("cashBalance", 0.0);
                cashBalLabel.Text = "0.00";
                betTextBox.Focus();
            }
        }

        protected void pullLever(object sender, EventArgs e)
        {
            string pic1 = "", pic2 = "", pic3 = "";
            double bet = 0, cashAdded = 0;

            if (!betMade()) return;
            else bet = toPosNum(betTextBox.Text);

            getSpin(out pic1, out pic2, out pic3);
            calcResult(bet, pic1, pic2, pic3, out cashAdded);
            displayResult(cashAdded);
            ViewState["cashBalance"] = calcBalance(cashAdded);
        }

        private bool betMade()
        {
            if (toPosNum(betTextBox.Text) > 0)
                return true;
            else
            {
                resultsLabel.Text = "Enter in your bet.";
                return false;
            }
        }

        Random randomNum = new Random();
        private void getSpin(out string pic1, out string pic2, out string pic3)
        {
            string[] pics = new string[12] {
                "Bar", "Bell", "Cherry", "Clover","" +
                "Diamond", "HorseShoe","Lemon","Orange",
                "Plum", "Seven", "Strawberry", "Watermellon"};
            pic1 = pics[randomNum.Next(0, 11)];
            pic2 = pics[randomNum.Next(0, 11)];
            pic3 = pics[randomNum.Next(0, 11)];
            displayPics(pic1, pic2, pic3);
        }

        private void displayPics(string pic1, string pic2, string pic3)
        {
            image1.ImageUrl = "../Images/" + pic1 + ".png";     
            image2.ImageUrl = "../Images/" + pic2 + ".png";
            image3.ImageUrl = "../Images/" + pic3 + ".png";
        }

        // calculate result (cash added to pot) based on pics spun
        private void calcResult(double bet, string pic1, string pic2, string pic3, out double cashAdded)
        {
            if (pic1 == "Bar" || pic2 == "Bar" || pic3 == "Bar") cashAdded = -1 * bet;
            else if (pic1 == pic2 && pic2 == pic3 && pic1 == "Seven") cashAdded = bet * 100;
            else if (pic1 == pic2 && pic2 == pic3 && pic1 == "Cherry") cashAdded = bet * 4;
            else if ((pic1 == pic2 || pic2 == pic3 || pic1 == pic3) && (pic1 == "Cherry" || pic2 == "Cherry")) cashAdded = bet * 3;
            else if (pic1 == "Cherry" || pic2 == "Cherry" || pic3 == "Cherry") cashAdded = bet * 2;
            else cashAdded = -1 * bet;
        }

        private void displayResult(double cashAdded)
        {
            if (cashAdded > 0)
                resultsLabel.Text = String.Format("You bet {0:C} and won {1:C}!", toPosNum(betTextBox.Text), cashAdded);
            else if (cashAdded < 0)
                resultsLabel.Text = String.Format("You lost ${0:N2}.", Math.Abs(cashAdded));
            else
                resultsLabel.Text = String.Format("You bet {0:C} and won {1:C}.", toPosNum(betTextBox.Text), cashAdded);
        }

        private double calcBalance(double cashAdded)
        {
            double cashBal = (double)ViewState["cashBalance"];
            cashBal = cashBal + cashAdded;
            cashBalLabel.Text = String.Format("{0:N2}", cashBal);
            return cashBal;
        }

        // convert string to a positive number if possible. If result is not a positive number, return 0. 
        private double toPosNum(string textVal)
        {
            double parsedVal;
            if (!Double.TryParse(textVal, out parsedVal) || parsedVal <= 0)
                return 0.0;
            else return parsedVal;
        }
    }
}