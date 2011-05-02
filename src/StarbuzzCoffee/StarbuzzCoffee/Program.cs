using System;
using StarbuzzCoffee.Condiments;

namespace StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEspresso();
            PrintDarkRoastDoubleMochaWhip();
            PrintHouseBlendSoyMochaWhip();
        }

        private static void PrintHouseBlendSoyMochaWhip()
        {
            Beverage beverage = new HouseBlend();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.Out.WriteLine(beverage);
        }

        private static void PrintDarkRoastDoubleMochaWhip()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.Out.WriteLine(beverage);
        }

        private static void PrintEspresso()
        {
            Beverage beverage = new Espresso();
            Console.Out.WriteLine(beverage);
        }
    }
}
