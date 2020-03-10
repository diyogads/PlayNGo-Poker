using Poker.Library.Contants;

namespace Poker.Library.Models
{
    public class Card
    {
        public Card()
        {
            Rank = CardRank.Ace;
            Suit = Suit.Spades;
        }

        public string Name => GetName();
        public CardRank Rank { get; set; }
        public Suit Suit { get; set; }

        protected string GetName()
        {
            return $"{ Rank.ToString() } of { Suit.ToString() }";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            Card other = (Card)obj;

            return Rank.Equals(other.Rank) && Suit.Equals(other.Suit);
        }

        public override int GetHashCode()
        {
            return new { Rank, Suit }.GetHashCode();
        }
    }
}
