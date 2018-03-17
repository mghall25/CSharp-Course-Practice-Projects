using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Bob Tabor";
            resultLabel1.Text = "";

            for (int i = name.Length; i>0 ; i--)
                resultLabel1.Text += name[i-1];
           
           
            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            string[] nameArray = names.Split(',');

            for (int i=nameArray.Length-1; i>0; i--)
                resultLabel2.Text += nameArray[i] + ", ";
            resultLabel2.Text += nameArray[0];

            
            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            int nameLength;
            double extraSpace;
            int leftSpace;
            int rightSpace;

            for (int i=0; i<=nameArray.Length-1; i++)
            {
                int totalLength = 14;
                nameLength = nameArray[i].Length;
                extraSpace = totalLength - nameLength ;
                leftSpace = (int)Math.Floor(extraSpace / 2);
                rightSpace = (int)(extraSpace - leftSpace);

                resultLabel3.Text += nameArray[i].PadLeft(leftSpace + nameLength,'*').PadRight(totalLength,'*') + "<br />";
            }

           
            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            puzzle = puzzle.Replace('Z', 't').Replace("remove-me", "").ToLower();
            resultLabel4.Text = char.ToUpper(puzzle[0]) + puzzle.Substring(1);

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

        }
    }
}