using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void OkBtn_Click(object sender, EventArgs e)
        {

            if (pencilRadio.Checked)
            {
                msgLabel.Text = "";
                selectedImg.ImageUrl = "../pencil.png";
                        
            }
            else if (penRadio.Checked)
            {
                msgLabel.Text = "";
                selectedImg.ImageUrl = "../pen.png";
            }
            else if (phoneRadio.Checked)
            {
                msgLabel.Text = "";
                selectedImg.ImageUrl = "../phone.png";
            }
            else if (tabletRadio.Checked)
            {
                msgLabel.Text = "";
                selectedImg.ImageUrl = "../tablet.png";
            }
            else
            {
                msgLabel.Text = ("Please select an option.");
            }
        }
    }
}