using System;

namespace _12_Coin_Nim
{
    class Menu
    {
        public static String MainMenu()
        {
            EmptySpace();
            Console.Write("                       -------------------------------------------------------------------\n");
            Console.Write("                      |              Welcome to Nim! The rules are simple.                |\n");
            Console.Write("                      |                                                                   |\n");
            Console.Write("                      | 1.) There are X number of coins presented: * * * * * * *          |\n");
            Console.Write("                      | 2.) Each player will take turns removing Either 1, 2 or 3 coins.  |\n");
            Console.Write("                      | 3.) The goal is to be the player that removes the very last coin. |\n");
            Console.Write("                      |                                                                   |\n");
            Console.Write("                      | Anytime you would like to exit the game, just type \"exit\".        |\n");
            Console.Write("                       -------------------------------------------------------------------\n");
            EmptySpace();

            Console.WriteLine("Would you like to start a new round? (y/n)");
            Console.Write(">");
            return Console.ReadLine().ToLower();
        }

        public static void MenuSelect()
        {
            switch (MainMenu())
            {
                case "y":
                case "yes":
                    CoinPile.TotalCoins = CoinPile.CoinPileAmount();
                    Players.DetermineStartingPlayer();
                    break;
                case "n":
                case "no":
                case "exit":
                    ExitGame();
                    break;
                default:
                    EmptySpace();
                    Console.WriteLine("Please type yes or no.");
                    MenuSelect();
                    break;
            }
        }

        private static void ExitGame()
        {
            Environment.Exit(0);
        }

        public static void EmptySpace()
        {
            Console.WriteLine();
        }
    }
}
