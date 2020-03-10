using Poker.Library.Contants;
using Poker.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Library.Utilities
{
    public static class Utility
    {

        public static bool IsRoyalFlush(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            if (!cards.IsFlush())
                return false;

            if (!cards.IsStraight())
                return false;

            if (!cards.GetHighestCard().Rank.Equals(CardRank.Ace))
                return false;

            return true;
        }

        public static bool IsStraightFlush(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            if (!cards.IsFlush())
                return false;

            if (!cards.IsStraight())
                return false;

            return true;
        }

        public static bool IsFourOfAKind(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            return cards.HighestRankOccurence().Equals(4);
        }

        public static bool IsFullHouse(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            if (!cards.IsThreeOfAKind())
                return false;

            var ranks = cards.GroupBy(c => c.Rank).Select(r => r.FirstOrDefault()).Select(c => c.Rank);
            bool hasValidThreeOfAKind = false, hasValidPair = false;

            foreach (var rank in ranks)
            {
                if (cards.Count(c => c.Rank.Equals(rank)).Equals(3))
                    hasValidThreeOfAKind = true;
                else if (cards.Count(c => c.Rank.Equals(rank)).Equals(2))
                    hasValidPair = true;
            }

            return hasValidThreeOfAKind && hasValidPair;
        }

        public static bool IsFlush(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            return cards.NumberOfDistinctSuits().Equals(1);
        }

        public static bool IsStraight(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            if (!cards.NumberOfDistinctRanks().Equals(5))
                return false;

            cards = cards.OrderBy(c => c.Rank).ToList();
            var lowestRank = cards.First();


            foreach (var card in cards)
            {
                if (!card.Rank.Equals(lowestRank.Rank))
                {
                    var nextRank = (CardRank)Convert.ToInt32(lowestRank.Rank + 1);

                    if (!card.Rank.Equals(nextRank))
                        return false;

                    lowestRank = card;
                }
            }

            return true;
        }

        public static bool IsThreeOfAKind(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            return cards.HighestRankOccurence().Equals(3);
        }

        public static bool IsTwoPairs(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            if (!cards.IsPair())
                return false;

            var ranks = cards.GroupBy(c => c.Rank).Select(r => r.FirstOrDefault()).Select(c => c.Rank);
            int numberOfValidPair = 0;

            foreach (var rank in ranks)
            {
                if (cards.HasPair(rank))
                    numberOfValidPair++;
            }

            return numberOfValidPair.Equals(2);
        }

        public static bool IsPair(this List<Card> cards)
        {
            if (!cards.IsValid())
                return false;

            return cards.HighestRankOccurence().Equals(2);
        }

        public static bool IsValid(this List<Card> cards)
        {
            // Flag invalid when not having five cards
            if (cards.Count != 5)
                return false;

            // Flag as invalid when having duplicate cards
            foreach (var card in cards)
            {
                if (cards.Count(c => c.Rank == card.Rank && c.Suit == card.Suit) != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static int NumberOfDistinctRanks(this List<Card> cards)
        {
            return cards.GroupBy(c => c.Rank).Select(r => r.FirstOrDefault()).ToList().Count;
        }

        public static int NumberOfDistinctSuits(this List<Card> cards)
        {
            return cards.GroupBy(c => c.Suit).Select(r => r.FirstOrDefault()).ToList().Count;
        }

        public static int HighestRankOccurence(this List<Card> cards)
        {
            var ranks = cards.GroupBy(c => c.Rank).Select(r => r.FirstOrDefault()).Select(c => c.Rank);
            int highestRankOccurence = 0;

            foreach (var rank in ranks)
            {
                var occurence = cards.Where(c => c.Rank == rank).ToList().Count;
                highestRankOccurence = occurence > highestRankOccurence ? occurence : highestRankOccurence;
            }

            return highestRankOccurence;
        }

        public static int HighestSuitOccurence(this List<Card> cards)
        {
            var suits = cards.GroupBy(c => c.Suit).Select(r => r.FirstOrDefault()).Select(c => c.Suit);
            int highestSuitOccurence = 0;

            foreach (var suit in suits)
            {
                var occurence = cards.Where(c => c.Suit == suit).ToList().Count;
                highestSuitOccurence = occurence > highestSuitOccurence ? occurence : highestSuitOccurence;
            }

            return highestSuitOccurence;
        }

        public static Card GetHighestCard(this List<Card> cards, CardRank? cardRank = null)
        {
            return cardRank.HasValue ? cards.Where(c => c.Rank.Equals(cardRank)).OrderByDescending(c => c.Rank).First() : cards.OrderByDescending(c => c.Rank).First();
        }

        public static bool HasUndisputedWinner(this Game game)
        {
            var players = game.Players;
            var highestHandRank = players.OrderByDescending(h => h.HandRank).First().HandRank;

            return players.Count(p => p.HandRank.Equals(highestHandRank)).Equals(1);
        }

        public static Suit? GetSuitWithSpecificOccurence(this List<Card> cards, int numberOfOccurence)
        {
            var suits = cards.GroupBy(c => c.Suit).Select(r => r.FirstOrDefault()).Select(c => c.Suit);

            foreach (var suit in suits)
            {
                if (cards.Where(c => c.Suit == suit).ToList().Count.Equals(numberOfOccurence))
                {
                    return suit;
                }
            }

            return null;
        }

        public static CardRank? GetRankWithSpecificOccurence(this List<Card> cards, int numberOfOccurence)
        {
            var ranks = cards.GroupBy(c => c.Rank).Select(r => r.FirstOrDefault()).Select(c => c.Rank);

            foreach (var rank in ranks)
            {
                if (cards.Where(c => c.Rank == rank).ToList().Count.Equals(numberOfOccurence))
                {
                    return rank;
                }
            }

            return null;
        }

        public static List<CardRank> GetDistinctRanksDescending(this List<Card> cards)
        {
            return cards.GroupBy(c => c.Rank)
                        .Select(r => r.FirstOrDefault())
                        .OrderByDescending(c => c.Rank)
                        .ThenByDescending(c => c.Suit)
                        .Select(c => c.Rank)
                        .ToList();
        }

        public static bool HasPair(this List<Card> cards, CardRank cardRank)
        {
            return cards.Count(c => c.Rank.Equals(cardRank)).Equals(2);
        }

        public static Player ResolveSameHandRank(this List<Player> players, HandRank resolvingHandRank)
        {
            // Variable for winning player
            Player winningPlayer = null;

            // Remove players who aren't within resolving hand rank & has invalid cards
            players.RemoveAll(p => !p.HandRank.Equals(resolvingHandRank) || !p.HasValidCards);

            if (players.Count > 1)
            {
                switch (resolvingHandRank)
                {
                    case HandRank.RoyalFlush:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            // More than one Royal Flush is possible but will be resolved by their suits
                            // Get suits of the winning & current player
                            var winningPlayerSuit = winningPlayer.Cards.GetSuitWithSpecificOccurence(5);
                            var currentPlayerSuit = currentPlayer.Cards.GetSuitWithSpecificOccurence(5);

                            if (currentPlayerSuit > winningPlayerSuit)
                                winningPlayer = currentPlayer;
                        }

                        break;

                    case HandRank.StraightFlush:

                        foreach (var player in players)
                        {
                            winningPlayer = winningPlayer.Equals(null) ? player : winningPlayer;

                            // Straights will always be resolved by its highest ranking card
                            // Get highest ranking card of winning & current player
                            var winningPlayerHighestRankingCard = winningPlayer.Cards.GetHighestCard().Rank;
                            var currentPlayerHighestRankingCard = player.Cards.GetHighestCard().Rank;

                            if (currentPlayerHighestRankingCard > winningPlayerHighestRankingCard)
                            {
                                winningPlayer = player;
                            }

                            // If both ranks were equal, they will be resolved by the highest card's suit
                            else if (currentPlayerHighestRankingCard.Equals(winningPlayerHighestRankingCard))
                            {
                                // Get highest ranking card suit of winning & current player
                                var winningPlayerSuit = winningPlayer.Cards.GetSuitWithSpecificOccurence(5);
                                var currentPlayerSuit = player.Cards.GetSuitWithSpecificOccurence(5);

                                if (currentPlayerSuit > winningPlayerSuit)
                                    winningPlayer = player;
                            }
                        }

                        break;

                    case HandRank.FourofaKind:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            // Four of a kind with same ranks should not exist in different hands, therefore, only check for the rank
                            // Get Four of a kind ranks of winning & current player
                            var winningPlayerFourOfAKindRank = winningPlayer.Cards.GetRankWithSpecificOccurence(4);
                            var currentPlayerFourOfAKindRank = currentPlayer.Cards.GetRankWithSpecificOccurence(4);

                            if (currentPlayerFourOfAKindRank > winningPlayerFourOfAKindRank)
                            {
                                winningPlayer = currentPlayer;
                            }
                        }

                        break;

                    case HandRank.FullHouse:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            // Same with three of a kind
                            // Three of a kind same ranks should not exist in different hands, therefore, only check for the rank
                            // Get Three of a kind ranks of winning & current player
                            var winningPlayerThreeOfAKindRank = winningPlayer.Cards.GetRankWithSpecificOccurence(3);
                            var currentPlayerThreeOfAKindRank = currentPlayer.Cards.GetRankWithSpecificOccurence(3);

                            if (currentPlayerThreeOfAKindRank > winningPlayerThreeOfAKindRank)
                            {
                                winningPlayer = currentPlayer;
                            }
                        }

                        break;

                    case HandRank.Flush:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            // Get winning & current player's flush suits
                            var winningPlayerSuit = winningPlayer.Cards.GetSuitWithSpecificOccurence(5);
                            var currentPlayerSuit = currentPlayer.Cards.GetSuitWithSpecificOccurence(5);

                            if (currentPlayerSuit > winningPlayerSuit)
                            {
                                winningPlayer = currentPlayer;
                            }

                            // In case suits are equal, resolve using highest card rank
                            else if (currentPlayerSuit.Equals(winningPlayerSuit))
                            {
                                // Get winning & current player's highest card
                                var winningPlayerHighestCardRank = winningPlayer.Cards.GetHighestCard().Rank;
                                var currentPlayerHighestCardRank = currentPlayer.Cards.GetHighestCard().Rank;

                                if (currentPlayerHighestCardRank > winningPlayerHighestCardRank)
                                {
                                    winningPlayer = currentPlayer;
                                }
                            }
                        }

                        break;

                    case HandRank.Straight:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            // Get winning & current player's highest card
                            var winningPlayerHighestCard = winningPlayer.Cards.GetHighestCard();
                            var currentPlayerHighestCard = currentPlayer.Cards.GetHighestCard();

                            if (currentPlayerHighestCard.Rank > winningPlayerHighestCard.Rank)
                            {
                                winningPlayer = currentPlayer;
                            }

                            // In case ranks are equal, resolve using highest card suit
                            else if (currentPlayerHighestCard.Rank.Equals(winningPlayerHighestCard.Rank))
                            {
                                if (currentPlayerHighestCard.Suit > winningPlayerHighestCard.Suit)
                                {
                                    winningPlayer = currentPlayer;
                                }
                            }
                        }

                        break;

                    case HandRank.ThreeofaKind:

                        // Same resolution with Full House
                        goto case HandRank.FullHouse;

                    case HandRank.TwoPairs:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            CardRank? winningPlayerHighPairRank = null, currentPlayerHighPairRank = null;

                            // Get descending possible ranks having pairs from winning and current player
                            var winningPlayerCardRanks = winningPlayer.Cards.GetDistinctRanksDescending();
                            var currentPlayerCardRanks = currentPlayer.Cards.GetDistinctRanksDescending();

                            foreach (var rank in winningPlayerCardRanks)
                            {
                                // If the matched rank is a pair, it is the winning player's highest pair
                                if (winningPlayer.Cards.HasPair(rank))
                                    winningPlayerHighPairRank = rank;
                            }

                            foreach (var rank in currentPlayerCardRanks)
                            {
                                // If the matched rank is a pair, it is the current player's highest pair
                                if (currentPlayer.Cards.HasPair(rank))
                                    currentPlayerHighPairRank = rank;
                            }

                            if (currentPlayerHighPairRank > winningPlayerHighPairRank)
                            {
                                winningPlayer = currentPlayer;
                            }

                            // If the high pairs for both players are equal, compare each other's high pair's highest suit
                            else if (currentPlayerHighPairRank.Equals(winningPlayerHighPairRank))
                            {
                                // Get highest suit from winning and current player's high pairs
                                var winningPlayerHighPairHighestSuit = winningPlayer.Cards.GetHighestCard(winningPlayerHighPairRank).Suit;
                                var currentPlayerHighPairHighestSuit = currentPlayer.Cards.GetHighestCard(currentPlayerHighPairRank).Suit;

                                if (currentPlayerHighPairHighestSuit > winningPlayerHighPairHighestSuit)
                                {
                                    winningPlayer = currentPlayer;
                                }
                            }
                        }

                        break;

                    case HandRank.Pair:

                        foreach (var currentPlayer in players)
                        {
                            winningPlayer = winningPlayer ?? currentPlayer;

                            // Get ranks of winning and current player's pair
                            var winningPlayerPairRank = winningPlayer.Cards.GetRankWithSpecificOccurence(2);
                            var currentPlayerPairRank = currentPlayer.Cards.GetRankWithSpecificOccurence(2);

                            if (currentPlayerPairRank > winningPlayerPairRank)
                            {
                                winningPlayer = currentPlayer;
                            }

                            // If ranks are equal, compare using pair's suit
                            else if (currentPlayerPairRank.Equals(winningPlayerPairRank))
                            {
                                // Get suits of winning and current player's pair
                                var winningPlayerHighPairHighestSuit = winningPlayer.Cards.GetHighestCard(winningPlayerPairRank).Suit;
                                var currentPlayerHighPairHighestSuit = currentPlayer.Cards.GetHighestCard(currentPlayerPairRank).Suit;

                                if (currentPlayerHighPairHighestSuit > winningPlayerHighPairHighestSuit)
                                {
                                    winningPlayer = currentPlayer;
                                }
                            }
                        }

                        break;

                    case HandRank.HighCard:

                        // Same resolution with Straights
                        goto case HandRank.Straight;

                    default:

                        winningPlayer = null;

                        break;
                }
            }

            return winningPlayer;
        }

        public static List<Card> RearrangeUsingHandRank(this Player player)
        {
            List<Card> rearrangedCards = new List<Card>();

            switch (player.HandRank)
            {

                case HandRank.RoyalFlush:
                case HandRank.StraightFlush:
                case HandRank.Straight:
                case HandRank.HighCard:
                    {
                        rearrangedCards.AddRange(
                            player.Cards.OrderByDescending(c => c.Rank)
                                            .ThenByDescending(c => c.Suit)
                                            .ToList());
                    }
                    break;

                case HandRank.FourofaKind:
                    {
                        var FourOfAKindRank = player.Cards.GetRankWithSpecificOccurence(4);

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => c.Rank.Equals(FourOfAKindRank))
                                        .OrderByDescending(c => c.Rank)
                                        .OrderByDescending(c => c.Suit)
                                        .ToList());

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => !c.Rank.Equals(FourOfAKindRank))
                                        .OrderByDescending(c => c.Rank)
                                        .OrderByDescending(c => c.Suit)
                                        .ToList());
                    }
                    break;

                case HandRank.ThreeofaKind:
                case HandRank.FullHouse:
                    {
                        var ThreeOfAKindRank = player.Cards.GetRankWithSpecificOccurence(3);

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => c.Rank.Equals(ThreeOfAKindRank))
                                        .OrderByDescending(c => c.Rank)
                                        .OrderByDescending(c => c.Suit)
                                        .ToList());

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => !c.Rank.Equals(ThreeOfAKindRank))
                                        .OrderByDescending(c => c.Rank)
                                        .OrderByDescending(c => c.Suit)
                                        .ToList());
                    }
                    break;

                case HandRank.Flush:
                    {
                        var suit = player.Cards.GetSuitWithSpecificOccurence(5);

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => c.Suit.Equals(suit))
                                        .OrderByDescending(c => c.Rank)
                                        .ToList());
                    }

                    break;

                case HandRank.TwoPairs:
                    {

                        CardRank? winningPlayerHighPairRank = null, winningPlayerLowPairRank = null;

                        var winningPlayerCardRanks = player.Cards.GetDistinctRanksDescending();

                        foreach (var rank in winningPlayerCardRanks)
                        {
                            if (player.Cards.HasPair(rank))
                            {
                                winningPlayerHighPairRank = rank;
                                winningPlayerCardRanks.Remove(rank);

                                break;
                            }
                        }

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => c.Rank.Equals(winningPlayerHighPairRank))
                                        .OrderByDescending(c => c.Rank)
                                        .ThenByDescending(c => c.Suit)
                                        .ToList());



                        foreach (var rank in winningPlayerCardRanks)
                        {
                            if (player.Cards.HasPair(rank))
                            {
                                winningPlayerLowPairRank = rank;
                                winningPlayerCardRanks.Remove(rank);

                                break;
                            }
                        }


                        rearrangedCards.AddRange(
                            player.Cards.Where(c => c.Rank.Equals(winningPlayerLowPairRank))
                                        .OrderByDescending(c => c.Rank)
                                        .ThenByDescending(c => c.Suit)
                                        .ToList());

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => !c.Rank.Equals(winningPlayerHighPairRank) && !c.Rank.Equals(winningPlayerLowPairRank))
                                        .OrderByDescending(c => c.Rank)
                                        .ThenByDescending(c => c.Suit)
                                        .ToList());
                    }

                    break;

                case HandRank.Pair:
                    {
                        var pairRank = player.Cards.GetRankWithSpecificOccurence(2);

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => c.Rank.Equals(pairRank))
                                        .OrderByDescending(c => c.Rank)
                                        .ThenByDescending(c => c.Suit)
                                        .ToList());

                        rearrangedCards.AddRange(
                            player.Cards.Where(c => !c.Rank.Equals(pairRank))
                                        .OrderByDescending(c => c.Rank)
                                        .ThenByDescending(c => c.Suit)
                                        .ToList());
                    }

                    break;
            }

            return rearrangedCards;
        }
    }
}
