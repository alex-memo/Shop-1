using System.Collections;
using System;

namespace Tut2
{
    internal class Program
    {
        private static bool isShop=true;
        private static string shopName = "Ubisoft";
        private static string playerInput;
        private static string[] gamesAvailable= new string[] {"GTA", "Assasins Creed"};
        private static int price = 50;
        
        static void Main(string[] args)
        {
            Store();
        }
        private static void Store()
        {
            Console.WriteLine($"Hello and welcome to {shopName}");
            
            while (isShop)
            {
                playerInput = Console.ReadLine();
                playerInput=playerInput.ToLower();
                if (playerInput == null|| playerInput.Equals(""))
                {
                    Console.WriteLine("Please enter text!");
                }
                else if (playerInput.Equals("hi") || playerInput.Equals("hello"))
                {
                    Console.WriteLine($"Hello there! Welcome to {shopName}! Please input the game you're looking for!");
                }
                else if(playerInput.Contains("do you have")|| playerInput.Contains("is the game")||playerInput.Contains("game"))
                {
                    if (CheckAvailability(playerInput))//means the game is available
                    {
                        Console.WriteLine($"Yes, this game is available! The cost is {price.ToString()}!");
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately this game is not available at the time, check back later!");
                    }
                }
                else if(playerInput.Contains("exit")|| playerInput.Contains("leave")|| playerInput.Contains("bye"))
                {
                    Console.WriteLine("Come back later!");
                    System.Threading.Thread.Sleep(3000);
                    isShop = false;
                }
            }

        }
        private static bool CheckAvailability(string game)
        {
            int i = 0;
            while (i < gamesAvailable.Length)
            {
                if (game.Contains(gamesAvailable[i], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}