using Poker.Library.Contants;
using Poker.Library.Utilities;
using System.Collections.Generic;

namespace Poker.Library.Models
{
    public class Player
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; }

        public HandRank HandRank
        {
            get
            {
                return GetHandRank();
            }
        }

        public bool HasValidCards => Cards.IsValid();

        public HandRank GetHandRank()
        {
            if (HasValidCards)
            {
                if (Cards.IsRoyalFlush())
                    return HandRank.RoyalFlush;

                if (Cards.IsStraightFlush())
                    return HandRank.StraightFlush;

                if (Cards.IsFourOfAKind())
                    return HandRank.FourofaKind;

                if (Cards.IsFullHouse())
                    return HandRank.FullHouse;

                if (Cards.IsFlush())
                    return HandRank.Flush;

                if (Cards.IsStraight())
                    return HandRank.Straight;

                if (Cards.IsThreeOfAKind())
                    return HandRank.ThreeofaKind;

                if (Cards.IsTwoPairs())
                    return HandRank.TwoPairs;

                if (Cards.IsPair())
                    return HandRank.Pair;

                return HandRank.HighCard;
            }
            else
            {
                return HandRank.Invalid;
            }
        }
    }
}
