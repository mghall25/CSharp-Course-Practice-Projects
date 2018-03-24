using System;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            resultLabel.Text = game.GameDesc;
            DisplayScores(game);
            DisplayWinner(game);
            
        }

        public void DisplayScores(Game game)
        {
            resultLabel.Text += String.Format("<br><strong>Final: <br>Player 1's Score = {0}<br> Player 2's Score = {1}<strong> <br>", game.Player1.score, game.Player2.score);
        }

        public void DisplayWinner(Game game)
        {
            resultLabel.Text += "<br><strong><em>The winner is ";
            if (game.Player1.score > game.Player2.score)
                resultLabel.Text += "Player 1!</em></strong>";
            else
                resultLabel.Text += "Player 2!</em></strong>";
        }

    }   
}
    
