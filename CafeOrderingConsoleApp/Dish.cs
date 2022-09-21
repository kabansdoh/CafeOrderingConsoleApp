using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingConsoleApp
{

    class Dish : Ingredient
    {
        int cookTimeBol = 20;
        int cookTimeSoup = 15;
        int cookTimeSteak = 7;
        int cookTimeBr = 5;

        public static double bolognesePrice = (water + spagetti + meat + tomato) + (water + spagetti + meat + tomato) * 0.2;
        public static double steakPrice = (oil + meat) + (oil + meat) * 0.2;
        public static double soupPrice = (water + vegetables) + (water + vegetables) * 0.2;
        public static double breakfastPrice = (eggs + beacon + oil) + (eggs + beacon + oil) * 0.2;

        public static void BolTime()
        {
            Dish bolognese = new Dish();
            Console.WriteLine("Your oreder will be ready in " + bolognese.cookTimeBol + " Minutes");
        }

        public static void SoupTime()
        {
            Dish soup = new Dish();
            Console.WriteLine("Your oreder will be ready in " + soup.cookTimeSoup + " Minutes");
        }

        public static void SteakTime()
        {
            Dish steak = new Dish();
            Console.WriteLine("Your oreder will be ready in " + steak.cookTimeSteak + " Minutes");
        }

        public static void BrTime()
        {
            Dish breakfast = new Dish();
            Console.WriteLine("Your oreder will be ready in " + breakfast.cookTimeBr + " Minutes");
        }
    }
}
