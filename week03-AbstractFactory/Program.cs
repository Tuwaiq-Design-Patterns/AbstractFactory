using System;

namespace week03_AbstractFactory
{
    interface ICar
    {
        IElectricCar GetElectricCar();
        IGasCar GetGasCar();
    }

    interface IElectricCar
    {
        string GetModelDetails();
    }

    interface IGasCar
    {
        string GetModelDetails();
    }


    /// toyota classes ///
    /// //
    class Toyota : ICar
    {
        public IElectricCar GetElectricCar()
        {
            return new Toyota_bZ4X();
        }

        public IGasCar GetGasCar()
        {
            return new Camry();
        }
    }

    internal class Toyota_bZ4X : IElectricCar
    {
        public string GetModelDetails()
        {
            return "Car Name: Toyota bZ4X" + "Features: 7 seats, auto transmission";

        }
    }

    internal class Camry : IGasCar
    {
        public string GetModelDetails()
        {
            return "Car Name: Camry \nType: Gas \nFeatures: 4 seats, auto transmission";
        }
    }
    //^^^^^^^^^^^^^^^^^^//
    /// toyota classes ///
    //////////////////////



    /// Audi classes ///
    /// //
    class Audi : ICar
    {
        public IElectricCar GetElectricCar()
        {
            return new Etron();
        }

        public IGasCar GetGasCar()
        {
            return new AudiQ8();
        }
    }

    internal class AudiQ8 : IGasCar
    {
        public string GetModelDetails()
        {
            return "Car Name: Audi Q8 \nType: Gas \nFeatures: 5 seats, auto transmission";
        }
    }

    internal class Etron : IElectricCar
    {
        public string GetModelDetails()
        {
            return "Car Name: E-tron \nType: Electric \nFeatures: 7 seats, auto transmission";
        }
    }

    //^^^^^^^^^^^^^^^^^^//
    /// Audi classes ///
    //////////////////////



    /// Clinet ///
    /// //
    class Client
    {
        IGasCar gasCar;
        IElectricCar electricCar;

        public Client(ICar factory)
        {
            gasCar = factory.GetGasCar();
            electricCar = factory.GetElectricCar();

        }

        public string GetGasCarDetails()
        {
            return gasCar.GetModelDetails();
        }

        public string GetElectricCarDetails()
        {
            return electricCar.GetModelDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("********** Toyota **********");
            ICar toyotaCar = new Toyota();
            Client toyotaClient = new Client(toyotaCar);
            Console.WriteLine(toyotaClient.GetGasCarDetails());
            Console.WriteLine(toyotaClient.GetElectricCarDetails());

            Console.WriteLine();

            Console.WriteLine("********** Audi **********");
            ICar audiCar = new Audi();
            Client audiClient = new Client(audiCar);
            Console.WriteLine(audiClient.GetGasCarDetails());
            Console.WriteLine(audiClient.GetElectricCarDetails());
            Console.ReadKey();
        }
    }
}
