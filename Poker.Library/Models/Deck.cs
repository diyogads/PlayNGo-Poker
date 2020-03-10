using Poker.Library.Contants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Library.Models
{
    public class Deck
    {
        public List<Card> Cards { get; }

        public Deck()
        {
            // Instantiate cards
            Cards = new List<Card>();

            // Instantiate deck
            foreach (var suit in Enum.GetValues(typeof(Suit)).Cast<Suit>())
            {
                foreach (var rank in Enum.GetValues(typeof(CardRank)).Cast<CardRank>())
                {
                    Cards.AddRange(new List<Card> {
                        new Card {
                            Rank = rank,
                            Suit = suit
                        }
                    });
                }
            }
        }

        // Gets randomized list of cards from the deck
        public List<Card> Draw()
        {
            var cardsDrawn = new List<Card>();
            var numberOfCards = 5;

            Random rnd = new Random();

            do
            {
                int random = rnd.Next(Cards.Count);
                cardsDrawn.Add(Cards[random]);

                Cards.RemoveAt(random);
                numberOfCards--;
            }
            while (!numberOfCards.Equals(0));

            return cardsDrawn;
        }
    }
}
