using System;
using System.Threading;

namespace _12_Coin_Nim
{
    class Players
    {
        public static bool playerTurn = false;
        public static void PlayerMove()
        {
            playerTurn = true;

            Menu.EmptySpace();
            Console.WriteLine("It's your Turn!");

            CoinPile.DisplayCoins();

            Menu.EmptySpace();
            Console.WriteLine("How many coins would you like to take?");
            int inNum = Int32.Parse(Console.ReadLine());

            CoinPile.RemoveCoins(inNum);
            GameFunctions.CheckScore();
            AIMove();
        }
        public static void AIMove()
        {
            playerTurn = false;

            int AITake = CoinPile.CoinCount();

            Menu.EmptySpace();
            Console.WriteLine("It's the AI's Turn!");

            CoinPile.DisplayCoins();

            Menu.EmptySpace();
            Console.WriteLine("The AI will take " + AITake + " coin(s).");

            CoinPile.RemoveCoins(AITake);
            GameFunctions.CheckScore();
            PlayerMove();
        }

        public static void DetermineStartingPlayer()
        {
            String playerValue = CoinValue();
            
            Console.Clear();
            Console.WriteLine("Lets see who will go first by flipping a coin! Best out of 5.");

            Menu.EmptySpace();
            Console.WriteLine("You are " + playerValue);

            CoinFlip(playerValue);
        }

        private static String CoinValue()
        {
            Random value = new Random();

            int faceValue = value.Next(1, 3);

            if (faceValue % 2 == 0)
            {
                return "Heads";
            }
            return "Tails";
        }

        private static void CoinFlip(String pV)
        {
            Thread.Sleep(800);
            Menu.EmptySpace();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(CoinValue() + ", ");
                Thread.Sleep(1000);
            }
            String startingPlayer = CoinValue();

            Console.Write(startingPlayer);
            Thread.Sleep(1000);

            if (startingPlayer == pV)
            {
                PlayerMove();
            }
            AIMove();
        }
    }
}