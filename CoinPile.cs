using System;

namespace _12_Coin_Nim
{
    class CoinPile
    {
        public static int TotalCoins;
        public static int RoundTotal;
        public static int CoinPileAmount()
        {
            Menu.EmptySpace();
            Console.WriteLine("How many coins would you like to use?");
            return TotalCoins = Int32.Parse(Console.ReadLine());
        }

        public static void DisplayCoins()
        {
            Menu.EmptySpace();
            Console.Write("There are " + TotalCoins + " coins present: ");
            for (int i = 0; i < TotalCoins; i++)
            {
                Console.Write(" * ");
            }
        }

        public static void RemoveCoins(int coinNum)
        {   
            if (coinNum > 3 || coinNum < 1)
            {
                Menu.EmptySpace();
                Console.WriteLine("Please enter either 1, 2 or 3.");
                Players.PlayerMove();
            }
            else
            {
                TotalCoins -= coinNum;
                RoundTotal = coinNum;
            }
        }

        public static int CoinCount()
        {
            Random num = new Random();
            int ranReturn = num.Next(1, 4);
            if (TotalCoins <= 3)
            {
                return TotalCoins;
            }
            else if (TotalCoins % 4 == 0)
            {
                if (RoundTotal == 0)
                {
                    return ranReturn;
                }
                else
                {
                    return 4 - RoundTotal;
                }
            }
            else
            {
                int sub = TotalCoins;
                while (TotalCoins % 4 != 0)
                {
                    sub--;
                    if (sub % 4 == 0)
                    {
                        return TotalCoins - sub;
                    }
                }
            }
            throw new Exception("This wasn't supposed to run");
        }
    }
}
