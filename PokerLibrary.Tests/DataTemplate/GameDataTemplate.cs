using Poker.Library.Models;
using System.Collections.Generic;

namespace Poker.Library.Tests.Data
{
    public class GameDataTemplate
    {
        public readonly PlayerDataTemplate playerData = new PlayerDataTemplate();

        public Game GameWithoutSamePlayerHand => new Game
            (
                new List<Player>
                {
                    playerData.PlayerWithRoyalFlushClubs,
                    playerData.PlayerWithFullHouse1,
                    playerData.PlayerWithHighCard1
                }
            );

        public Game GameWithSamePlayerHand => new Game
            (
                new List<Player>
                {
                    playerData.PlayerWithFullHouse1,
                    playerData.PlayerWithFullHouse2,
                    playerData.PlayerWithHighCard1,
                    playerData.PlayerWithHighCard2,
                }
            );

        public Game GameWithAllHighCardPlayerHand => new Game
            (
                new List<Player>
                {
                    playerData.PlayerWithHighCard1,
                    playerData.PlayerWithHighCard2,
                    playerData.PlayerWithHighCard3,
                }
            );

        public Game GameWithInvalidPlayerHand => new Game
            (
                new List<Player>
                {
                    playerData.PlayerWithHighCard1,
                    playerData.PlayerWithHighCard2,
                    playerData.PlayerWithLessThanFiveCards,
                }
            );
    }
}
