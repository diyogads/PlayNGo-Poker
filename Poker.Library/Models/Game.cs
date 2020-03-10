using Poker.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Library.Models
{
    public class Game
    {

        private readonly List<string> names = new List<string>
        {
            "Kendall",
            "Zaida",
            "Tonisha",
            "Jessia",
            "Danille",
            "Ervin",
            "Yvette",
            "Sona",
            "Adrien",
            "Nancey",
            "Ila",
            "Jed",
            "Maritza",
            "Julio",
            "Lanie",
            "Katherine",
            "Allyson",
            "Daron",
            "Melania",
            "Katheryn",
            "Paola",
            "Goldie",
            "Heidy",
            "Pamala",
            "Martha",
            "Janyce",
            "Aracelis",
            "Wm",
            "Winnie",
            "Ayana"
        };

        public Deck Deck { get; private set; }
        public List<Player> Players { get; private set; }

        public Game()
        {
            Deck = new Deck();
            Players = new List<Player>();
        }

        public Game(int numberOfPlayers)
        {
            Deck = new Deck();
            Players = new List<Player>();

            Random rnd = new Random();

            while (!numberOfPlayers.Equals(0))
            {
                int random = rnd.Next(names.Count);

                Players.Add(new Player { Name = names[random] });
                names.Remove(names[random]);
                numberOfPlayers--;
            }
        }

        public Game(List<Player> players)
        {
            Deck = new Deck();
            Players = players;
        }

        public void StartGame()
        {
            foreach (var player in Players)
            {
                player.Cards = Deck.Draw();
            }
        }

        public Player GetWinner()
        {
            if (HasValidCardPool() && !Players.Exists(p =>! p.HasValidCards))
            {
                var players = Players.OrderByDescending(p => p.HandRank).ToList();

                if (!this.HasUndisputedWinner())
                {
                    var winningHandRank = players.First().HandRank;
                    var possibleWinners = players.Where(p => p.HandRank == winningHandRank).ToList();

                    var winner = possibleWinners.ResolveSameHandRank(winningHandRank);

                    return winner;
                }
                else
                {
                    return players.First();
                }
            }
            else
            {
                return null;
            }
        }

        public bool HasValidCardPool()
        {
            var overallCards = Deck.Cards;
            Players.ForEach(p => overallCards.AddRange(p.Cards));

            if (!overallCards.Count.Equals(52))
                return false;

            foreach (var card in overallCards)
            {
                if (!overallCards.Count(c => c.Rank.Equals(card.Rank) && c.Suit.Equals(card.Suit)).Equals(1))
                    return false;
            }

            return true;
        }
    }
}
