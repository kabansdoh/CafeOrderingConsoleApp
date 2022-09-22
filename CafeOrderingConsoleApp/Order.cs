using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingConsoleApp
{
    class Order : Dish

    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to our restaurant\r");
            Console.WriteLine("Please choose one of the following dishes:\n");

            Console.WriteLine("\tBolognese - Spagetti with fried meat and tomato sauce\n " +
                              "\tIngredients: Meat, Spagetti, Tomatos\n" +
                              "\tPrice - " + bolognesePrice + "$\n");

            Console.WriteLine("\tSoup - Fresh soup with vegetables\n" +
                              "\tIngredients: Bouillon, Vegetables\n" +
                              "\tPrice - " + soupPrice + "$\n");

            Console.WriteLine("\tSteak - A juicy beef steak\n" +
                              "\tIngredients: Meat, Oil\n" +
                              "\tPrice - " + steakPrice + "$\n");

            Console.WriteLine("\tBreakfast - Fried eggs with bacon\n" +
                              "\tIngredients: Eggs, Bacon\n" +
                              "\tPrice - " + breakfastPrice + "$\n");
            Console.WriteLine("------------------------------------------------------------\n");

            //A collection of orders that will help assign them to cooks
            List<string> cookJack = new List<string>();       

            do
            {
                if (cookJack.Count < 5)
                {
                    switch (Console.ReadLine())
                    {
                        case "bolognese":
                            CookTime();
                            cookJack.Add("bolognese");
                            break;
                        case "soup":
                            CookTime();
                            cookJack.Add("soup");
                            break;
                        case "steak":
                            CookTime();
                            cookJack.Add("steak");
                            break;
                        case "breakfast":
                            CookTime();
                            cookJack.Add("breakfast");
                            break;
                        default:
                            Console.WriteLine("Please choose a dish from the list.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No cooks available\n");
                    Console.ReadKey();
                    break;
                }
               
            }
            while (cookJack.Count < 6);

            Console.ReadKey();
        }
    }
}
