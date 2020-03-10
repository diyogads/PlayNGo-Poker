using Poker.Library.Contants;
using Poker.Library.Models;
using Poker.Library.Tests.Data;
using Poker.Library.Utilities;
using System.Collections.Generic;
using Xunit;

namespace Poker.Library.Tests
{
    public class UtilityTests
    {
        private readonly PlayerDataTemplate playerData = new PlayerDataTemplate();
        private readonly CardDataTemplate cardData = new CardDataTemplate();
        private readonly GameDataTemplate gameData = new GameDataTemplate();

        #region IsRoyalFlush

        [Fact]
        public void IsRoyalFlush_FiveCardsRoyalFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.True(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsStraightFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        [Fact]
        public void IsRoyalFlush_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsRoyalFlush());
        }

        #endregion

        #region IsStraightFlush

        [Fact]
        public void IsStraightFlush_FiveCardsRoyalFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.True(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsStraightFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.True(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsStraightFlush());
        }

        [Fact]
        public void IsStraightFlush_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsStraightFlush());
        }


        #endregion

        #region IsFourOfAKind

        [Fact]
        public void IsFourOfAKind_FiveCardsRoyalFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsStraightFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsFourOfAKindShouldReturnTrue()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.True(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsFourOfAKind());
        }

        [Fact]
        public void IsFourOfAKind_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsFourOfAKind());
        }


        #endregion

        #region IsFullHouse

        [Fact]
        public void IsFullHouse_FiveCardsRoyalFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsStraightFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsFullHouseShouldReturnTrue()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.True(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsFullHouse());
        }

        [Fact]
        public void IsFullHouse_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsFullHouse());
        }


        #endregion

        #region IsFlush

        [Fact]
        public void IsFlush_FiveCardsRoyalFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.True(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsStraightFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.True(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.True(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsFlush());
        }

        [Fact]
        public void IsFlush_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsFlush());
        }


        #endregion

        #region IsStraight

        [Fact]
        public void IsStraight_FiveCardsRoyalFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.True(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsStraightFlushShouldReturnTrue()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.True(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsStraightShouldReturnTrue()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.True(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsStraight());
        }

        [Fact]
        public void IsStraight_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsStraight());
        }


        #endregion

        #region IsThreeOfAKind

        [Fact]
        public void IsThreeOfAKind_FiveCardsRoyalFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsStraightFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsFullHouseShouldReturnTrue()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.True(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsThreeOfAKindShouldReturnTrue()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.True(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsTwoPairsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }

        [Fact]
        public void IsThreeOfAKind_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsThreeOfAKind());
        }


        #endregion

        #region IsTwoPairs

        [Fact]
        public void IsTwoPairs_FiveCardsRoyalFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsStraightFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsTwoPairsShouldReturnTrue()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.True(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsPairShouldReturnFalse()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsTwoPairs());
        }

        [Fact]
        public void IsTwoPairs_FiveCardsHasDuplicateCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsTwoPairs());
        }


        #endregion

        #region IsPair

        [Fact]
        public void IsPair_FiveCardsRoyalFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsStraightFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsFourOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsFullHouseShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsFlushShouldReturnFalse()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsStraightShouldReturnFalse()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsThreeOfAKindShouldReturnFalse()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsTwoPairsShouldReturnTrue()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.True(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsPairShouldReturnTrue()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.True(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_LessThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_MoreThanFiveCardsShouldReturnFalse()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            Assert.False(cards.IsPair());
        }

        [Fact]
        public void IsPair_FiveCardsHasDuplicateCardsShouldReturnTrue()
        {
            var cards = playerData.PlayerWithDuplicateCards.Cards;

            Assert.False(cards.IsPair());
        }


        #endregion

        #region IsValid

        [Fact]
        public void ValidateCards_ValidCardsShouldReturnTrue()
        {
            var player = playerData.PlayerWithFullHouse1;

            var hasValidCards = player.Cards.IsValid();

            Assert.True(hasValidCards);
        }

        [Fact]
        public void ValidateCards_IsDuplicateCardsShouldReturnFalse()
        {
            var player = playerData.PlayerWithDuplicateCards;

            var hasValidCards = player.Cards.IsValid();

            Assert.False(hasValidCards);
        }

        [Fact]
        public void ValidateCards_IsMoreThanFiveCardsShouldReturnFalse()
        {
            var player = playerData.PlayerWithMoreThanFiveCards;

            var hasValidCards = player.Cards.IsValid();

            Assert.False(hasValidCards);
        }

        [Fact]
        public void ValidateCards_IsLessThanFiveCardsShouldReturnFalse()
        {
            var player = playerData.PlayerWithLessThanFiveCards;

            var hasValidCards = player.Cards.IsValid();

            Assert.False(hasValidCards);
        }

        #endregion

        #region NumberOfDistinctRanks

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsStraightFlushShouldReturn5()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(5, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsFourOfAKindShouldReturn2()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(2, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsFullHouseShouldReturn2()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(2, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsFlushShouldReturn5()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(5, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsStraightShouldReturn5()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(5, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsThreeOfAKindShouldReturn3()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(3, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsTwoPairsShouldReturn3()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(3, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsPairShouldReturn4()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(4, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_FiveCardsShouldReturn5()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(5, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_LessThan5CardsShouldReturn3()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(3, numberOfDistinctRanks);
        }

        [Fact]
        public void NumberOfDistinctRanks_MoreThan5CardsShouldReturn7()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            var numberOfDistinctRanks = cards.NumberOfDistinctRanks();

            Assert.Equal(7, numberOfDistinctRanks);
        }

        #endregion

        #region NumberOfDistinctSuits
        [Fact]
        public void NumberOfDistinctSuits_FiveCardsStraightFlushShouldReturn1()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(1, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsFourOfAKindShouldReturn4()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(4, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsFullHouseShouldReturn4()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(4, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsFlushShouldReturn1()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(1, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsStraightShouldReturn3()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(3, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsThreeOfAKindShouldReturn4()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(4, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsTwoPairsShouldReturn3()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(3, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsPairShouldReturn3()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(3, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_FiveCardsShouldReturn3()
        {
            var cards = playerData.PlayerWithHighCard2.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(3, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_LessThan5CardsShouldReturn2()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(2, numberOfDistinctSuits);
        }

        [Fact]
        public void NumberOfDistinctSuits_MoreThan5CardsShouldReturn4()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            var numberOfDistinctSuits = cards.NumberOfDistinctSuits();

            Assert.Equal(4, numberOfDistinctSuits);
        }

        #endregion

        #region HighestRankOccurence

        [Fact]
        public void HighestRankOccurence_FiveCardsStraightFlushShouldReturn1()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(1, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsFourOfAKindShouldReturn4()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(4, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsFullHouseShouldReturn3()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(3, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsFlushShouldReturn1()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(1, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsStraightShouldReturn1()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(1, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsThreeOfAKindShouldReturn3()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(3, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsTwoPairsShouldReturn2()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(2, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsPairShouldReturn2()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(2, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_FiveCardsShouldReturn1()
        {
            var cards = playerData.PlayerWithHighCard3.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(1, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_LessThan5CardsShouldReturn3()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(1, highestRankOccurence);
        }

        [Fact]
        public void HighestRankOccurence_MoreThan5CardsShouldReturn1()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            var highestRankOccurence = cards.HighestRankOccurence();

            Assert.Equal(1, highestRankOccurence);
        }

        #endregion

        #region HighestSuitOccurence

        [Fact]
        public void HighestSuitOccurence_FiveCardsStraightFlushShouldReturn5()
        {
            var cards = playerData.PlayerWithStraightFlush.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(5, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsFourOfAKindShouldReturn2()
        {
            var cards = playerData.PlayerWithFourOfAKind.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(2, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsFullHouseShouldReturn2()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(2, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsFlushShouldReturn5()
        {
            var cards = playerData.PlayerWithFlush.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(5, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsStraightShouldReturn3()
        {
            var cards = playerData.PlayerWithStraight1.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(3, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsThreeOfAKindShouldReturn2()
        {
            var cards = playerData.PlayerWithThreeOfAKind1.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(2, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsTwoPairsShouldReturn3()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(3, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsPairShouldReturn2()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(2, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_FiveCardsShouldReturn3()
        {
            var cards = playerData.PlayerWithHighCard1.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(3, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_LessThan5CardsShouldReturn2()
        {
            var cards = playerData.PlayerWithLessThanFiveCards.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(2, highestSuitOccurence);
        }

        [Fact]
        public void HighestSuitOccurence_MoreThan5CardsShouldReturn2()
        {
            var cards = playerData.PlayerWithMoreThanFiveCards.Cards;

            var highestSuitOccurence = cards.HighestSuitOccurence();

            Assert.Equal(2, highestSuitOccurence);
        }

        #endregion

        #region GetHighestRank

        [Fact]
        public void GetHighestRank_FiveCardsRoyalFlushShouldReturnAceCardRank()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            var highestCardRank = cards.GetHighestCard().Rank;

            Assert.Equal(CardRank.Ace, highestCardRank);
        }

        #endregion

        #region GetSuitWithSpecificOccurence

        [Fact]

        public void GetSuitWithSpecificOccurence_FiveCardsRoyalFlushShouldReturnClubs()
        {
            var cards = playerData.PlayerWithRoyalFlushClubs.Cards;

            Assert.Equal(Suit.Clubs, cards.GetSuitWithSpecificOccurence(5));
        }

        #endregion

        #region GetRankWithSpecificOccurence

        [Fact]

        public void GetRankWithSpecificOccurence_FiveCardsFiveCardsFullHouseShouldReturnTen()
        {
            var cards = playerData.PlayerWithFullHouse1.Cards;

            Assert.Equal(CardRank.Ten, cards.GetRankWithSpecificOccurence(3));
        }

        #endregion

        #region HasUndisputedWinner

        [Fact]
        public void HasUndisputedWinner_GameHasNoSameHandRankShouldReturnTrue()
        {
            var game = gameData.GameWithoutSamePlayerHand;

            Assert.True(game.HasUndisputedWinner());
        }

        [Fact]
        public void HasUndisputedWinner_GameHasSameHandRankShouldReturnFalse()
        {
            var game = gameData.GameWithSamePlayerHand;

            Assert.False(game.HasUndisputedWinner());
        }

        #endregion

        #region GetDistinctRanksDescending

        [Fact]
        public void GetDistinctRanksDescending_PlayerWithHighCardShouldReturnDescendingRank()
        {
            var cards = playerData.PlayerWithHighCard3.Cards;
            var cardsInDescendingOrder = new List<CardRank>
            {
                CardRank.Ace,
                CardRank.Jack,
                CardRank.Nine,
                CardRank.Eight,
                CardRank.Two
            };

            Assert.Equal(cardsInDescendingOrder, cards.GetDistinctRanksDescending());
        }

        [Fact]
        public void GetDistinctRanksDescending_FiveCardsTwoPairsShouldReturnDescendingRank()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;
            var cardsInDescendingOrder = new List<CardRank>
            {
                CardRank.Queen,
                CardRank.Nine,
                CardRank.Two
            };

            Assert.Equal(cardsInDescendingOrder, cards.GetDistinctRanksDescending());
        }

        #endregion

        #region HasPair

        [Fact]
        public void HasPair_HasOnePairWithMatchRankingShouldReturnTrue()
        {
            var cards = playerData.PlayerWithPair1.Cards;

            Assert.True(cards.HasPair(CardRank.Six));
        }

        [Fact]
        public void HasPair_HasTwoPairWithMatchRankingShouldReturnTrue()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.True(cards.HasPair(CardRank.Two));
        }

        [Fact]
        public void HasPair_HasPairWithMatchRankingButNotAPairRankShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.HasPair(CardRank.Queen));
        }

        [Fact]
        public void HasPair_HasPairWithNoMatchRankingShouldReturnFalse()
        {
            var cards = playerData.PlayerWithTwoPairs1.Cards;

            Assert.False(cards.HasPair(CardRank.Ace));
        }

        #endregion

        #region ResolveSameHandRank

        [Fact]
        public void ResolveSameHandRank_TwoSameHandsMatchedRankInputShouldReturnPlayerWithFullHouse1()
        {
            var players = new List<Player>
            {
                playerData.PlayerWithFullHouse1,
                playerData.PlayerWithFullHouse2,
                playerData.PlayerWithHighCard1
            };

            var expectedWinner = players.Find(p => p.Name.Equals("PlayerWithFullHouse1"));

            Assert.Equal(expectedWinner, players.ResolveSameHandRank(HandRank.FullHouse));
        }

        [Fact]
        public void ResolveSameHandRank_TwoSameHandsMatchedRankInputShouldReturnFiveCardsHighCard1()
        {
            var players = new List<Player>
            {
                playerData.PlayerWithFullHouse1,
                playerData.PlayerWithHighCard1,
                playerData.PlayerWithHighCard2
            };

            var expectedWinner = players.Find(p => p.Name.Equals("PlayerWithHighCard1"));

            Assert.Equal(expectedWinner, players.ResolveSameHandRank(HandRank.HighCard));
        }

        [Fact]
        public void ResolveSameHandRank_TwoSameHandsMismatchedRankInputShouldReturnNull()
        {
            var players = new List<Player>
            {
                playerData.PlayerWithFullHouse1,
                playerData.PlayerWithFullHouse2,
                playerData.PlayerWithHighCard1
            };

            Assert.Null(players.ResolveSameHandRank(HandRank.HighCard));
        }

        [Fact]
        public void ResolveSameHandRank_NoMatchedRankInputShouldReturnNull()
        {
            var players = new List<Player>
            {
                playerData.PlayerWithFullHouse1,
                playerData.PlayerWithFullHouse2,
                playerData.PlayerWithHighCard1
            };

            Assert.Null(players.ResolveSameHandRank(HandRank.RoyalFlush));
        }

        #endregion

        #region RearrangeUsingHandRank

        [Fact]
        public void RearrangeUsingHandRank_RoyalFlush()
        {
            var player = playerData.PlayerWithRoyalFlushHearts;

            var expectedCardArrangement = new List<Card>
            {
                cardData.AceOfHearts,
                cardData.KingOfHearts,
                cardData.QueenOfHearts,
                cardData.JackOfHearts,
                cardData.TenOfHearts
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_StraightFlush()
        {
            var player = playerData.PlayerWithStraightFlush;

            var expectedCardArrangement = new List<Card>
            {
                cardData.QueenOfHearts,
                cardData.JackOfHearts,
                cardData.TenOfHearts,
                cardData.NineOfHearts,
                cardData.EightOfHearts
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_Straight()
        {
            var player = playerData.PlayerWithStraight1;

            var expectedCardArrangement = new List<Card>
            {
                cardData.SevenOfHearts,
                cardData.SixOfClubs,
                cardData.FiveOfHearts,
                cardData.FourOfHearts,
                cardData.ThreeOfSpades
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_HighCard()
        {
            var player = playerData.PlayerWithHighCard3;

            var expectedCardArrangement = new List<Card>
            {
                cardData.AceOfSpades,
                cardData.JackOfDiamonds,
                cardData.NineOfHearts,
                cardData.EightOfDiamonds,
                cardData.TwoOfSpades
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_FourOfAKind()
        {
            var player = playerData.PlayerWithFourOfAKind;

            var expectedCardArrangement = new List<Card>
            {
                cardData.AceOfDiamonds,
                cardData.AceOfHearts,
                cardData.AceOfSpades,
                cardData.AceOfClubs,
                cardData.FourOfClubs
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_ThreeOfAKind()
        {
            var player = playerData.PlayerWithThreeOfAKind1;

            var expectedCardArrangement = new List<Card>
            {
                cardData.SevenOfDiamonds,
                cardData.SevenOfHearts,
                cardData.SevenOfSpades,
                cardData.KingOfDiamonds,
                cardData.JackOfClubs
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_FullHouse()
        {
            var player = playerData.PlayerWithFullHouse2;

            var expectedCardArrangement = new List<Card>
            {
                cardData.ThreeOfDiamonds,
                cardData.ThreeOfHearts,
                cardData.ThreeOfClubs,
                cardData.AceOfDiamonds,
                cardData.AceOfHearts
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_Flush()
        {
            var player = playerData.PlayerWithFlush;

            var expectedCardArrangement = new List<Card>
            {
                cardData.QueenOfDiamonds,
                cardData.JackOfDiamonds,
                cardData.TenOfDiamonds,
                cardData.SevenOfDiamonds,
                cardData.SixOfDiamonds
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_TwoPairs()
        {
            var player = playerData.PlayerWithTwoPairs1;

            var expectedCardArrangement = new List<Card>
            {
                cardData.NineOfDiamonds,
                cardData.NineOfClubs,
                cardData.TwoOfDiamonds,
                cardData.TwoOfHearts,
                cardData.QueenOfDiamonds
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        [Fact]
        public void RearrangeUsingHandRank_Pair()
        {
            var player = playerData.PlayerWithPair1;

            var expectedCardArrangement = new List<Card>
            {
                cardData.SixOfHearts,
                cardData.SixOfClubs,
                cardData.NineOfSpades,
                cardData.SevenOfSpades,
                cardData.FiveOfClubs
            };

            var actualCardArrangement = player.RearrangeUsingHandRank();

            Assert.Equal(expectedCardArrangement, actualCardArrangement);
        }

        #endregion
    }
}