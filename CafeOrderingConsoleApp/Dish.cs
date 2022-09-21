using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingConsoleApp
{
    class Dish : Ingredient
    {
        public int cookTime = 7;

        public static double bolognesePrice = (water + spagetti + meat + tomato) + (water + spagetti + meat + tomato) * 0.2;
        public static double steakPrice = (oil + meat) + (oil + meat) * 0.2;
        public static double soupPrice = (water + vegetables) + (water + vegetables) * 0.2;
        public static double breakfastPrice = (eggs + beacon + oil) + (eggs + beacon + oil) * 0.2;

        public static void CookTime()
        {
            Dish time = new Dish();
            Console.WriteLine("Your oreder will be ready in " + time.cookTime + " Minutes"); 
        }
    }  
}
