using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var ToyotaEconomyCar = new ToyotaEconomyCar();
            var ToyotaLuxuryCar = new ToyotaLuxuryCar();


            Console.Write("Toyota Cars \n");
            Console.Write(ToyotaEconomyCar.GetCarInfo());
            Console.Write(ToyotaLuxuryCar.GetCarInfo());
            Console.Write("--------------------------------\n");


            var NissanEconomyCar = new NissanEconomyCar();
            var NissanLuxuryCar = new NissanLuxuryCar();
            Console.Write("\nNissan Cars\n");
            Console.Write(NissanEconomyCar.GetCarInfo());
            Console.Write(NissanLuxuryCar.GetCarInfo());
            Console.Write("--------------------------------\n");
        }
    }
}
