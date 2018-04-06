using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeWar
{
    public static class Battle
    {
        private static Card _topCard1;
        private static Card _topCard2;
        private static List<Card> _bounty = new List<Card>();
        private static string _result = "";

        // battle round: each player turns over their top card, add cards won (the "bounty") to the winner's cards - 
        // at the bottom (end) of their list of cards
        public static string BattleRound(Player player1, Player player2)
        {
            _result = "";
            
            _topCard1 = getTopCard(player1);            // turn over top cards and describe results to user   
            _topCard2 = getTopCard(player2);
            describeRound();
            
            determineWinner(player1, player2);          // determine winner, add bounty to bottom (end) of winner's cards

            return _result;
        }

        // remove top card from player's deck and add it to the bounty
        private static Card getTopCard(Player player)
        {
            Card _topCard = player.Cards[0];
            player.Cards.Remove(_topCard);
            _bounty.Add(_topCard);
            return _topCard;
        }

        // return value of a card (its index in the ValidRanks array)
        private static int value(Card card)
        {
            return Array.IndexOf(card.ValidRanks, card.Rank);
        }

        // describe round
        private static void describeRound()
        {           
            _result += String.Format("----------------------------------------------------------<br>" +
                                    "Battle Cards: {0} of {1} versus {2} of {3}<br>",
                                    _topCard1.Rank, _topCard1.Suit, _topCard2.Rank, _topCard2.Suit);                        
        }

        // loop through and list the bounty cards
        private static void describeBounty()
        {            
            _result += "Bounty:<br>";
            for (int i = 0; i < _bounty.Count; i++)
            {
                _result += String.Format("&nbsp;&nbsp;&nbsp;{0} of {1}<br>", _bounty.ElementAt(i).Rank, _bounty.ElementAt(i).Suit);
            }
        }

        // determine winner and add bounty to the bottom of their stack of cards
        private static void determineWinner(Player player1, Player player2)
        {
            if (value(_topCard1) > value(_topCard2))
            {
                addBounty(player1);
                _result += "<strong>Player 1 wins!</strong><br>";

            }
            else if (value(_topCard2) > value(_topCard1))
            {            
                addBounty(player2);
                _result += "<strong>Player 2 wins!</strong><br>";
            }
            else
            {
                _result += "<strong>********************** WAR! *********************</strong><br>"; 
                warRound(player1, player2);                  
            }
        }

        // add the bounty cards to the bottom of the player's cards
        private static void addBounty(Player player)
        {
            describeBounty();
            player.Cards.AddRange(_bounty);
            _bounty.Clear();
        }

        // War round: each player turns over their three top cards and battles with the fourth card.
        // All four cards from each player plus the original two battle cards are the "bounty" added to the winner's cards 
        private static void warRound(Player player1, Player player2)
        {          
            for (int i = 0; i < 4; i++)                  // get 4 top cards from each player
            {              
                _topCard1 = getTopCard(player1);         // get cards and add to bounty
                _topCard2 = getTopCard(player2);
            }            
           describeRound();
           determineWinner(player1, player2);            // determine winner, adding bounty to bottom (end) of winner's cards
        }
    }

    
}