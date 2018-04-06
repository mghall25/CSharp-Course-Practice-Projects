using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChallengeWar;

namespace ChallengeWar
{
    public static class Game
    {
        public static string PlayGame()
        {
            // declarations
            Deck deck = new Deck();
            Player player1 = new Player();
            Player player2 = new Player();
            string result = "";

            // play game
            deck.Shuffle();
            deck.Deal(player1, player2);
            result += deck.DescribeDeal(player1, player2);            

            result += "<h1><strong>Begin battle</strong></h1>";
            for (int i = 0; i < 20; i++)
            {
                if (player1.Cards.Count == 0 || player2.Cards.Count == 0) break;   
                result+= Battle.BattleRound(player1, player2);
            }
            result += giveFinalScore(player1.Cards.Count, player2.Cards.Count);

            return result;
        }

        private static string giveFinalScore(int player1Cards, int player2Cards)
        {
            string result = "<h1><font color='red'>";
            if (player1Cards > player2Cards)
                result += "Player 1 wins!</font></h1>";
            else if (player2Cards > player1Cards)
                result += "Player 2 wins!</font></h1>";
            else
                result += "It's a tie!!!</font></h1>";

            result += String.Format("&nbsp;&nbsp;&nbsp;Player 1: {0} cards<br>" +
                                    "&nbsp;&nbsp;&nbsp;Player 2: {1} cards", 
                                    player1Cards, player2Cards);            
            return result;
        }
    }

    
}