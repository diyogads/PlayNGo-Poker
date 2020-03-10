using Poker.Library.Models;
using Poker.Library.Tests.Data;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poker.Library.Tests
{
    public class GameTests
    {
        public readonly GameDataTemplate gameData = new GameDataTemplate();

        #region StartGame

        [Fact]
        public void StartGame_PlayersGetCardsShouldDistribute()
        {
            var game = new Game
            (
                new List<Player>
                {
                    new Player { Name = "Deo" },
                    new Player { Name = "Random" }
                }
            );

            game.StartGame();

            var overallCardNumber = game.Players.Sum(p => p.Cards.Count) + game.Deck.Cards.Count;

            Assert.Equal(52, overallCardNumber);
        }


        #endregion

        #region GetWinner

        [Fact]
        public void GetWinner_GameWithInvalidPlayerHandShouldReturnNull()
        {
            var game = gameData.GameWithInvalidPlayerHand;

            Assert.Null(game.GetWinner());
        }

        #endregion

        #region HasValidCardPool
               
        [Fact]
        public void HasValidCardPool_GameWithoutSamePlayerHandShouldReturnFalse()
        {
            var game = gameData.GameWithoutSamePlayerHand;

            Assert.False(game.HasValidCardPool());
        }

        [Fact]
        public void HasValidCardPool_GameWithSamePlayerHandShouldReturnFalse()
        {
            var game = gameData.GameWithSamePlayerHand;

            Assert.False(game.HasValidCardPool());
        }

        [Fact]
        public void HasValidCardPool_GameWithAllHighCardPlayerHandShouldReturnFalse()
        {
            var game = gameData.GameWithAllHighCardPlayerHand;

            Assert.False(game.HasValidCardPool());
        }

        [Fact]
        public void HasValidCardPool_GameWithInvalidPlayerHandShouldReturnFalse()
        {
            var game = gameData.GameWithInvalidPlayerHand;

            Assert.False(game.HasValidCardPool());
        }

        #endregion
    }
}
