using System;

namespace AbstractFactory
{
    class Driver
    {
        static void Main(string[] args)
        {
            CoffeeShopAbstractFactory starbucks = new StarbucksFactory();
            Console.WriteLine(starbucks.MakeCupOfCoffee().Brew());
            Console.WriteLine(starbucks.MakeBagOfBeans().Grind());

            CoffeeShopAbstractFactory dunkin = new DunkinDonutsFactory();
            Console.WriteLine(dunkin.MakeCupOfCoffee().Brew());
            Console.WriteLine(dunkin.MakeBagOfBeans().Grind());
        }
    }
}
