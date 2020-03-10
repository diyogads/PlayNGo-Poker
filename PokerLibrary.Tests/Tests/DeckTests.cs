using Poker.Library.Models;
using Xunit;

namespace Poker.Library.Tests
{
    public class DeckTests
    {
        #region Instantiation of deck

        [Fact]
        public void Deck_InstantiateDeckShouldHave52Cards()
        {
            var deck = new Deck();

            Assert.Equal(52, deck.Cards.Count);
        }

        #endregion

        #region Draw

        [Fact]
        public void Draw_DrawCardsShouldReturn5Cards()
        {
            var deck = new Deck();
            var cards = deck.Draw();

            Assert.Equal(5, cards.Count);
        }

        #endregion
    }
}
