using Poker.Library.Models;
using Poker.Library.Utilities;
using System;
using System.Collections.Generic;

namespace Poker.ConsoleApplication
{
    public class Poker
    {
        static void Main(string[] args)
        {
            Game game = null;
            bool isExiting = false;

            do
            {
                DisplayMainMenu();

                switch (Console.ReadLine())
                {
                    case "y":
                        int numberOfPlayers = 0;
                        try
                        {
                            numberOfPlayers = Convert.ToInt32(GetNumberOfPlayers());
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {
                            if (numberOfPlayers > 0 && numberOfPlayers <= 9)
                                game = new Game(numberOfPlayers);
                        }
                        break;

                    case "n":
                        isExiting = true;
                        ExitConfirmation();
                        break;
                }

                if (game?.Players.Count > 0)
                {
                    game.StartGame();
                    ShowResults();
                    ShowPlayerCards(game.Players, game.GetWinner());
                }

                ShowRetry();

                switch (Console.ReadLine())
                {
                    case "n":
                        isExiting = true;
                        ExitConfirmation();
                        break;
                }
            }
            while (!isExiting);
        }

        private static void ShowTitle()
        {
            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t------ Poker Game ------");
            Console.WriteLine("\t------------------------\n");
        }

        private static string GetNumberOfPlayers()
        {
            Console.Clear();
            ShowTitle();
            Console.WriteLine("\tMax: 9 players");
            Console.WriteLine("\t------------------------");
            Console.Write("\tEnter number of players:");
            return Console.ReadLine();
        }

        private static void DisplayMainMenu()
        {
            Console.Clear();
            ShowTitle();
            Console.WriteLine("\tY - Start Game");
            Console.WriteLine("\tN - Exit Game");
        }

        private static void ExitConfirmation()
        {
            Console.Clear();
            ShowTitle();
            Console.WriteLine("\tPress any key to exit ...");
        }

        private static void ShowResults()
        {
            Console.Clear();
            ShowTitle();
        }

        private static void ShowPlayerCards(List<Player> players, Player winner)
        {
            foreach (var player in players)
            {
                Console.WriteLine("\n\t------------------------");
                Console.Write($"\t{ player.Name } { player.HandRank.ToString() }");

                if (player.Equals(winner))
                    Console.Write(" - Winner\n");
                else
                    Console.WriteLine();

                Console.WriteLine("\t------------------------");

                var rearrangedCards = player.RearrangeUsingHandRank();

                foreach (var card in rearrangedCards)
                {
                    Console.WriteLine($"\t{ card.Name }");
                }

                Console.WriteLine("\t------------------------");
            }
        }

        private static void ShowRetry()
        {
            Console.WriteLine("\n\tWould you like to retry game?");
            Console.WriteLine("\tY - Restart Game");
            Console.WriteLine("\tN - Exit Game");
        }
    }
}
