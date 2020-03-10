using Poker.Library.Contants;
using Poker.Library.Tests.Data;
using Xunit;

namespace Poker.Library.Tests
{
    public class PlayerTests
    {
        private readonly PlayerDataTemplate data = new PlayerDataTemplate();

        #region GetHand

        [Fact]
        public void GetHand_FiveCardsRoyalFlushShouldReturnRoyalFlushHandRank()
        {
            var player = data.PlayerWithRoyalFlushHearts;

            Assert.Equal(HandRank.RoyalFlush, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsStraightFlushShouldReturnStraightFlushHandRank()
        {
            var player = data.PlayerWithStraightFlush;

            Assert.Equal(HandRank.StraightFlush, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsFourOfAKindShouldReturnFourofaKindHandRank()
        {
            var player = data.PlayerWithFourOfAKind;

            Assert.Equal(HandRank.FourofaKind, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsFullHouseShouldReturnFullHouseHandRank()
        {
            var player = data.PlayerWithFullHouse1;

            Assert.Equal(HandRank.FullHouse, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsFlushShouldReturnFlushHandRank()
        {
            var player = data.PlayerWithFlush;

            Assert.Equal(HandRank.Flush, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsStraightShouldReturnStraightHandRank()
        {
            var player = data.PlayerWithStraight1;

            Assert.Equal(HandRank.Straight, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsThreeOfAKindShouldReturnThreeofaKindHandRank()
        {
            var player = data.PlayerWithThreeOfAKind1;

            Assert.Equal(HandRank.ThreeofaKind, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsTwoPairsShouldReturnTwoPairsHandRank()
        {
            var player = data.PlayerWithTwoPairs1;

            Assert.Equal(HandRank.TwoPairs, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsPairShouldReturnPairHandRank()
        {
            var player = data.PlayerWithPair1;

            Assert.Equal(HandRank.Pair, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsShouldReturnHighCardHandRank()
        {
            var player = data.PlayerWithHighCard1;

            Assert.Equal(HandRank.HighCard, player.HandRank);
        }

        [Fact]
        public void GetHand_LessThanFiveCardsShouldReturnInvalidHandRank()
        {
            var player = data.PlayerWithLessThanFiveCards;

            Assert.Equal(HandRank.Invalid, player.HandRank);
        }

        [Fact]
        public void GetHand_MoreThanFiveCardsShouldReturnInvalidHandRank()
        {
            var player = data.PlayerWithMoreThanFiveCards;

            Assert.Equal(HandRank.Invalid, player.HandRank);
        }

        [Fact]
        public void GetHand_FiveCardsHasDuplicateCardsShouldReturnInvalidHandRank()
        {
            var player = data.PlayerWithDuplicateCards;

            Assert.Equal(HandRank.Invalid, player.HandRank);
        }

        #endregion
    }
}
