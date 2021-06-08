using System;

namespace AbstractFactory
{

    public interface IMotors
    {
        ICar MakeCar();
        IMotorcycle MakeMotorcycle();
    }

    class Hyuendai : IMotors
    {
        public ICar MakeCar()
        {
            return new HyuendaiCars();
        }

        public IMotorcycle MakeMotorcycle()
        {
            return new HyuendaiMotorcycles();
        }
    }

    class Toyota : IMotors
    {
        public ICar MakeCar()
        {
            return new ToyotaCars();
        }

        public IMotorcycle MakeMotorcycle()
        {
            return new ToyotaMotorcycles();
        }
    }

    public interface ICar
    {
        string Car();
    }

    class HyuendaiCars : ICar
    {
        public string Car()
        {
            return "Hyuendai Car "+DateTime.Now.Year;
        }
    }

    class ToyotaCars : ICar
    {
        public string Car()
        {
            return "Toyota Car "+DateTime.Now.Year;
        }
    }

    public interface IMotorcycle
    {
        string Motorcycle();

        string NightLights(ICar collaborator);
    }

    class HyuendaiMotorcycles : IMotorcycle
    {
        public string Motorcycle()
        {
            return "Hyuendai Motorcycle "+DateTime.Now.Year;
        }

        public string NightLights(ICar collaborator)
        {
            var result = collaborator.Car();

            return $"NightLighs included with {result}";
        }
    }

    class ToyotaMotorcycles : IMotorcycle
    {
        public string Motorcycle()
        {
            return "Toyota Motorcycle "+DateTime.Now.Year;
        }

       
        public string NightLights(ICar collaborator)
        {
            var result = collaborator.Car();

            return $"Nightlights included with {result}";
        }
    }

  
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Order from Hyuendai:");
            ClientMethod(new Hyuendai());
            Console.WriteLine();

            Console.WriteLine("Order from Toyota:");
            ClientMethod(new Toyota());
        }

        public void ClientMethod(IMotors factory)
        {
            var product1 = factory.MakeCar();
            var product2 = factory.MakeMotorcycle();

            Console.WriteLine(product2.Motorcycle());
            Console.WriteLine(product2.NightLights(product1));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}