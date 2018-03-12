using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fromCal.SelectedDate;
            DateTime toDate = toCal.SelectedDate;
            TimeSpan days = fromDate.Subtract(toDate);
            double span = Math.Abs(days.TotalDays);

            if (span != 1 )
            {
                msgLbl.Text = span.ToString() + " days.";
            } else
            {
                msgLbl.Text = span.ToString() + " day.";
            }
        }
    }
}