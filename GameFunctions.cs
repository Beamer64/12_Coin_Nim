using System;

namespace _12_Coin_Nim
{
    class GameFunctions
    {
        public static void CheckScore()
        {
            if (CoinPile.TotalCoins == 0)
            {
                if (Players.playerTurn)
                {
                    GameWon();
                    Menu.MenuSelect();
                }
                else
                {
                    GameLost();
                    Menu.MenuSelect();
                }
            }
        }
        public static void GameWon()
        {
            Menu.EmptySpace();
            Console.WriteLine("Holy cow you actually won? *Sends Bug Report*");
        }
        public static void GameLost()
        {
            Menu.EmptySpace();
            Console.WriteLine("You've lost, better luck next time.");
        }
    }
}