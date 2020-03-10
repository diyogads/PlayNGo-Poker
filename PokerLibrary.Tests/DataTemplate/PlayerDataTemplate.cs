using Poker.Library.Models;

namespace Poker.Library.Tests.Data
{
    public class PlayerDataTemplate
    {
        public readonly HandDataTemplate data = new HandDataTemplate();

        public Player PlayerWithRoyalFlushClubs => new Player
        {
            Name = "PlayerWithRoyalFlushClubs",
            Cards = data.FiveCardsRoyalFlushClubs
        };
        public Player PlayerWithRoyalFlushHearts => new Player
        {
            Name = "PlayerWithRoyalFlushHearts",
            Cards = data.FiveCardsRoyalFlushHearts
        };

        public Player PlayerWithStraightFlush => new Player
        {
            Name = "PlayerWithStraightFlush",
            Cards = data.FiveCardsStraightFlush
        };

        public Player PlayerWithFourOfAKind => new Player
        {
            Name = "PlayerWithFourOfAKind",
            Cards = data.FiveCardsFourOfAKind
        };

        public Player PlayerWithFullHouse1 => new Player
        {
            Name = "PlayerWithFullHouse1",
            Cards = data.FiveCardsFullHouse1
        };

        public Player PlayerWithFullHouse2 => new Player
        {
            Name = "PlayerWithFullHouse2",
            Cards = data.FiveCardsFullHouse2
        };

        public Player PlayerWithStraight1 => new Player
        {
            Name = "PlayerWithStraight1",
            Cards = data.FiveCardsStraight
        };

        public Player PlayerWithThreeOfAKind1 => new Player
        {
            Name = "PlayerWithThreeOfAKind1",
            Cards = data.FiveCardsThreeOfAKind
        };

        public Player PlayerWithFlush => new Player
        {
            Name = "PlayerWithFlush",
            Cards = data.FiveCardsFlush
        };

        public Player PlayerWithTwoPairs1 => new Player
        {
            Name = "PlayerWithTwoPairs1",
            Cards = data.FiveCardsTwoPairs
        };

        public Player PlayerWithPair1 => new Player
        {
            Name = "PlayerWithPair1",
            Cards = data.FiveCardsPair
        };

        public Player PlayerWithHighCard1 => new Player
        {
            Name = "PlayerWithHighCard1",
            Cards = data.FiveCardsHighCard1
        };

        public Player PlayerWithHighCard2 => new Player
        {
            Name = "PlayerWithHighCard2",
            Cards = data.FiveCardsHighCard2
        };

        public Player PlayerWithHighCard3 => new Player
        {
            Name = "PlayerWithHighCard3",
            Cards = data.FiveCardsHighCard3
        };

        public Player PlayerWithDuplicateCards => new Player
        {
            Name = "PlayerWithDuplicateCards",
            Cards = data.FiveCardsHasDuplicateCards
        };

        public Player PlayerWithMoreThanFiveCards => new Player
        {
            Name = "PlayerWithMoreThanFiveCards",
            Cards = data.MoreThanFiveCards
        };

        public Player PlayerWithLessThanFiveCards => new Player
        {
            Name = "PlayerWithLessThanFiveCards",
            Cards = data.LessThanFiveCards
        };
    }
}
