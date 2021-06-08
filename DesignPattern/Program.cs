using System;

namespace DesignPatternWeek7Day3
{

   public interface IVehicleFactory
    {
        public IBike GetBike();
        public IScooter GetScooter();
    }

    public interface IBike { public void bike(); }
    public interface IScooter { public void scooter(); }

    public class Honda : IVehicleFactory
    {
        public IBike GetBike()
        {
            return new HondaBike();
        }

        public IScooter GetScooter()
        {
            return new HondaScooter();
        }
    }

    public class Yadea : IVehicleFactory
    {
        public IBike GetBike()
        {
            return new YadeaBike();
        }

        public IScooter GetScooter()
        {
            return new YadeaScooter();
        }
    }

    internal class HondaBike : IBike
    {
        public void bike()
        {
            Console.WriteLine("The product  is bike and the company is HONDA");
        }
    }

    internal class HondaScooter : IScooter
    {
        public void scooter()
        {
            Console.WriteLine("The product  is scooter and the company is HONDA");
        }
    }


    internal class YadeaBike : IBike
    {
        public void bike()
        {
            Console.WriteLine("The product  is bike and the company is YADEA");
        }
    }

    internal class YadeaScooter : IScooter
    {
        public void scooter()
        {
            Console.WriteLine("The product is scooter and the company is YADEA");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory HondaVehicle = new Honda();
            HondaVehicle.GetBike().bike();
            HondaVehicle.GetScooter().scooter();
            IVehicleFactory YadeaVehicle = new Yadea();
            YadeaVehicle.GetBike().bike();
            YadeaVehicle.GetScooter().scooter();

        }
    }
}
