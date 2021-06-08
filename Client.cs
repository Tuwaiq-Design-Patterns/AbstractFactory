using System;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            var nestleFactory = new NestleFactory();
            var alhadaFactory = new AlhadaFactory();

            var product1 = nestleFactory.GetWaterBottle();
            var product2 = nestleFactory.GetJuiceBottle();

            var product3 = alhadaFactory.GetWaterBottle();
            var product4 = alhadaFactory.GetJuiceBottle();

            Console.WriteLine("\nProduct 1: " + product1.GetBottleDetails());
            Console.WriteLine("Product 2: " + product2.GetBottleDetails());
            Console.WriteLine("\nProduct 3: " + product3.GetBottleDetails());
            Console.WriteLine("Product 4: " + product4.GetBottleDetails());
        }
    }
}
