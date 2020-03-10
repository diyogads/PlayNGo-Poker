using Poker.Library.Models;
using System.Collections.Generic;

namespace Poker.Library.Tests.Data
{
    public class HandDataTemplate
    {
        public readonly CardDataTemplate cardData = new CardDataTemplate();

        public List<Card> FiveCardsRoyalFlushClubs =>
            new List<Card>
            {
                cardData.AceOfClubs,
                cardData.KingOfClubs,
                cardData.QueenOfClubs,
                cardData.JackOfClubs,
                cardData.TenOfClubs
            };
        public List<Card> FiveCardsRoyalFlushHearts =>
            new List<Card>
            {
                cardData.QueenOfHearts,
                cardData.JackOfHearts,
                cardData.TenOfHearts,
                cardData.AceOfHearts,
                cardData.KingOfHearts
            };
        public List<Card> FiveCardsStraightFlush =>
            new List<Card>
            {
                cardData.TenOfHearts,
                cardData.NineOfHearts,
                cardData.QueenOfHearts,
                cardData.JackOfHearts,
                cardData.EightOfHearts
            };
        public List<Card> FiveCardsFourOfAKind =>
            new List<Card>
            {
                cardData.AceOfClubs,
                cardData.FourOfClubs,
                cardData.AceOfDiamonds,
                cardData.AceOfHearts,
                cardData.AceOfSpades
            };
        public List<Card> FiveCardsFullHouse1 =>
            new List<Card>
            {
                cardData.TenOfClubs,
                cardData.TenOfDiamonds,
                cardData.TenOfHearts,
                cardData.TwoOfDiamonds,
                cardData.TwoOfSpades
            };
        public List<Card> FiveCardsFullHouse2 =>
            new List<Card>
            {
                cardData.ThreeOfClubs,
                cardData.ThreeOfDiamonds,
                cardData.ThreeOfHearts,
                cardData.AceOfDiamonds,
                cardData.AceOfHearts
            };
        public List<Card> FiveCardsFlush =>
            new List<Card>
            {
                cardData.QueenOfDiamonds,
                cardData.JackOfDiamonds,
                cardData.SevenOfDiamonds,
                cardData.TenOfDiamonds,
                cardData.SixOfDiamonds
            };
        public List<Card> FiveCardsStraight =>
            new List<Card>
            {
                cardData.SevenOfHearts,
                cardData.FiveOfHearts,
                cardData.FourOfHearts,
                cardData.SixOfClubs,
                cardData.ThreeOfSpades
            };
        public List<Card> FiveCardsThreeOfAKind =>
            new List<Card>
            {
                cardData.SevenOfSpades,
                cardData.SevenOfHearts,
                cardData.SevenOfDiamonds,
                cardData.JackOfClubs,
                cardData.KingOfDiamonds
            };
        public List<Card> FiveCardsTwoPairs =>
            new List<Card>
            {
                cardData.NineOfClubs,
                cardData.NineOfDiamonds,
                cardData.TwoOfHearts,
                cardData.TwoOfDiamonds,
                cardData.QueenOfDiamonds
            };
        public List<Card> FiveCardsPair =>
            new List<Card>
            {
                cardData.SixOfClubs,
                cardData.SixOfHearts,
                cardData.NineOfSpades,
                cardData.FiveOfClubs,
                cardData.SevenOfSpades
            };
        public List<Card> FiveCardsHighCard1 =>
            new List<Card>
            {
                cardData.NineOfSpades,
                cardData.EightOfClubs,
                cardData.TwoOfClubs,
                cardData.ThreeOfSpades,
                cardData.KingOfClubs
            };
        public List<Card> FiveCardsHighCard2 =>
            new List<Card>
            {
                cardData.EightOfSpades,
                cardData.SixOfSpades,
                cardData.FiveOfSpades,
                cardData.ThreeOfHearts,
                cardData.FourOfDiamonds
            };
        public List<Card> FiveCardsHighCard3 =>
            new List<Card>
            {
                cardData.EightOfDiamonds,
                cardData.JackOfDiamonds,
                cardData.NineOfHearts,
                cardData.TwoOfSpades,
                cardData.AceOfSpades
            };
        public List<Card> LessThanFiveCards =>
            new List<Card>
            {
                cardData.SixOfHearts,
                cardData.JackOfDiamonds,
                cardData.ThreeOfDiamonds
            };
        public List<Card> MoreThanFiveCards =>
            new List<Card>
            {
                cardData.ThreeOfClubs,
                cardData.QueenOfDiamonds,
                cardData.TwoOfClubs,
                cardData.FourOfSpades,
                cardData.KingOfSpades,
                cardData.FiveOfDiamonds,
                cardData.EightOfHearts
            };
        public List<Card> FiveCardsHasDuplicateCards =>
            new List<Card>
            {
                cardData.JackOfSpades,
                cardData.TenOfSpades,
                cardData.TenOfSpades,
                cardData.QueenOfSpades,
                cardData.NineOfHearts
            };
    }
}
