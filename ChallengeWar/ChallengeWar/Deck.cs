using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeWar
{
    public class Deck
    {
        private Random _random { get; set; }
        public List<Card> Cards { get; set; }

        // construct deck
        public Deck()
        {
            var _card = new Card();
            _random = new Random();
            Cards = new List<Card>();

            foreach (var _suit in _card.ValidSuits)
            {
                foreach (var _rank in _card.ValidRanks)
                {
                    Cards.Add(new Card() { Rank = _rank, Suit = _suit });
                }
            }
        }

        public void Shuffle()
        {
            List<Card> _shuffledCards = new List<Card>();   // all 52 cards in random order                          
            int _randomCardIndex;

            for (int i = 52; i > 0; i--)                                // add cards to _shuffledCards in random order
            {
                _randomCardIndex = _random.Next(0, Cards.Count);        // get random number representing one of the cards remaining in the deck                
                _shuffledCards.Add(Cards[_randomCardIndex]);            // Add the randomly generated card to _shuffledCards                
                Cards.RemoveAt(_randomCardIndex);                       // remove the randomly generated card from the deck
            }            
            Cards = _shuffledCards;                                     //reassign the shuffled deck to this deck
        }

        // deal cards alternately to player1 and player2
        public void Deal(Player player1, Player player2)
        {
            do
            {
                DealOne(player1);
                DealOne(player2);
            } while (Cards.Count > 0);
        }

        // remove top card of deck and add it to player's list of cards
        private void DealOne(Player player)
        {
            Card _topCard;                  
            
            _topCard = this.Cards[0];
            Cards.RemoveAt(0);
            player.Cards.Add(_topCard);  
        }

        // list the cards dealt to each player
        public string DescribeDeal(Player player1, Player player2)
        {
            string result = "<h1>Dealing Cards...</h1>";

            for (int i = 0; i < player1.Cards.Count; i++)
            {
                result += "Player1 is dealt the " + player1.Cards.ElementAt(i).Rank + " of " + player1.Cards.ElementAt(i).Suit + "<br>";
                result += "Player2 is dealt the " + player2.Cards.ElementAt(i).Rank + " of " + player2.Cards.ElementAt(i).Suit + "<br>";
            }
            return result;
        }

        // print a list of cards - used for testing
        public string PrintDeck(List<Card> cards)
        {
            Card _currentCard;
            string result = "";

            for (int i = 0; i < cards.Count; i++)
            {
                _currentCard = cards.ElementAt(i);
                result += "Card Added: " + _currentCard.Rank + " of " + _currentCard.Suit + "<br>";
            }
            return result;
        }
    }
}