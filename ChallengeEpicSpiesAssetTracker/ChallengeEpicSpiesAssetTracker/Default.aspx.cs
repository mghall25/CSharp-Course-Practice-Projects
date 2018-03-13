using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {   
                // create arrays that will remain in state between submissions of the form
                int[] elections = new int[0];
                ViewState.Add("Elections", elections);

                int[] acts = new int[0];
                ViewState.Add("Acts", acts);
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            // add new item to elections array and update the ViewState array
            int[] el = (int[])ViewState["Elections"];
            Array.Resize(ref el, el.Length + 1);
            int newIndex = el.GetUpperBound(0);
            el[newIndex] = int.Parse(electionsText.Text);
            ViewState["Elections"] = el;

            // add new item to acts array
            int[] ac = (int[])ViewState["Acts"];
            Array.Resize(ref ac, ac.Length + 1);
            newIndex = el.GetUpperBound(0);
            ac[newIndex] = int.Parse(actsText.Text);
            ViewState["Acts"] = ac;

            msgLabel.Text = String.Format("Total Elections Rigged: {0}<br />" +
               "Average Acts of Subterfuge Per Asset: {1:N2}<br />" +
               "Name of Last Asset Added: {2}",           
               el.Sum(),
               ac.Average(),
               AssetNameText.Text);

            // set intput boxes to blank
            AssetNameText.Text = "";
            electionsText.Text = "";
            actsText.Text = "";

        }
    }
}