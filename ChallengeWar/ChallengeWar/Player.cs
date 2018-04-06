using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeWar
{
    public class Player 
    {
        public List<Card> Cards { get; set; }

        public Player()
        {
            Cards = new List<Card>();
        }
    }
}