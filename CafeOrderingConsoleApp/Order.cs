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
                              "\tPrice - " + bolognesePrice + "\n");

            Console.WriteLine("\tSoup - Fresh soup with vegetables\n" +
                              "\tIngredients: Bouillon, Vegetables\n" +
                              "\tPrice - " + soupPrice + "\n");

            Console.WriteLine("\tSteak - A juicy beef steak\n" +
                              "\tIngredients: Meat, Oil\n" +
                              "\tPrice - " + steakPrice + "\n");

            Console.WriteLine("\tBreakfast - Fried eggs with bacon\n" +
                              "\tIngredients: Eggs, Bacon\n" +
                              "\tPrice - " + breakfastPrice + "\n");
            Console.WriteLine("------------------------------------------------------------\n");

            string[] jack = new string[4];



            if (jack.Length < 5)
            { 
                switch (Console.ReadLine())
                {
                    case "bolognese":
                        BolTime();
                        break;
                    case "soup":
                        SoupTime();
                        break;
                    case "steak":
                        SteakTime();
                        break;
                    case "breakfast":
                        BrTime();
                        break;
                    case "end":

                        break;
                    default:
                        Console.WriteLine("Please choose a dish from the list.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Al cooks are busy");
            }

            Console.ReadKey();
        }
    }
}
