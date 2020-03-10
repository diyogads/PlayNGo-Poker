using Poker.Library.Contants;
using Poker.Library.Models;
using Xunit;

namespace Poker.Library.Tests
{
    public class CardTests
    {
        [Theory]
        [InlineData(CardRank.Ace, Suit.Clubs, "Ace of Clubs")]
        [InlineData(CardRank.Five, Suit.Clubs, "Five of Clubs")]
        public void GetName_ShouldOutputFormattedName(CardRank rank, Suit suit, string expectedName)
        {
            var card = new Card { Rank = rank, Suit = suit };

            var cardName = card.Name;

            Assert.Equal(expectedName, cardName);
        }
    }
}
