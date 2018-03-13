using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //initialize only if this is the initial page load event
            if (!Page.IsPostBack)
            {
                // initialize values on page load
                // .Date is needed below for it to display on the calendar
                PrevEndCal.SelectedDate = DateTime.Now.Date;
                NewStartCal.SelectedDate = DateTime.Now.Date.AddDays(14);
                NewEndCal.SelectedDate = DateTime.Now.Date.AddDays(21);

            }
        }

        protected void AssignBtn_Click(object sender, EventArgs e)
        {
            double DaysOff = NewStartCal.SelectedDate.Subtract(PrevEndCal.SelectedDate).TotalDays;
            double AssnLength = NewEndCal.SelectedDate.Subtract(NewStartCal.SelectedDate).TotalDays;

            // confirm 2 week break
            if (DaysOff < 14)
            {
                msgLbl.Text = "Error: you must allow at least two weeks between assignments.";
                NewStartCal.SelectedDate = DateTime.Now.Date.AddDays(14);

            }
            else
            // calculate budget for spy
            {
                double budget = AssnLength * 500;
                if (AssnLength > 21) budget = budget + 1000;

                msgLbl.Text = String.Format("Assignment of {0} to project {1} is authorized.<br />" +
                                                "Budget: {2:C}",
                                                SpyNameTextBox.Text,
                                                AssnNameTextBox.Text,
                                                budget);
            }

        }

        protected void PrevEndCal_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}