using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeWar
{
    public class Card
    {      
        public string Rank { get; set; }       
        public string Suit { get; set; }

        public string[] ValidSuits = new[] { "Spades", "Hearts", "Clubs", "Diamonds" };
        public string[] ValidRanks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
    }    
}