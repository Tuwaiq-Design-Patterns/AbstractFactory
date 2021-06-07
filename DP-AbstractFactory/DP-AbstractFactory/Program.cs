using System;

namespace DP_AbstractFactory
{
    public interface IVehicleFactory
    {
        ICar createCar();
        IPlane createPlane();
    }
    class ReqgularVehicleFactory : IVehicleFactory
    {
        public ICar createCar()
        {
            return new RegularCar();
        }

        public IPlane createPlane()
        {
            return new RegularPlane();
        }
    }
    class SportsVehicleFactory : IVehicleFactory
    {
        public ICar createCar()
        {
            return new SportsCar();
        }

        public IPlane createPlane()
        {
            return new SportsPlane();
        }
    }
    public interface ICar
    {
        string carName();
    }
    
    class RegularCar : ICar
     {
         public string carName()
         {
             return "Regular Car";
         }
     }
    class SportsCar : ICar
    {
        public string carName()
        {
            return "Sports Car";
        }
    }
    public interface IPlane
    {
        string planeName();
        string planeName2( ICar collaborator);

    }
    class RegularPlane : IPlane
    {
        public string planeName()
        {
            return "Regular Plane";
        }
        public string planeName2(ICar collaborator)
        {
            var result = collaborator.carName();

            return $"The result of the regular Plane collaborating with the ({result})";
        }
    }
    class SportsPlane : IPlane
    {
        public string planeName()
        {
            return "Sports Plane";
        }
        public string planeName2(ICar collaborator)
        {
            var result = collaborator.carName();

            return $"The result of the Soprts Plane collaborating with the ({result})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             void ClientMethod(IVehicleFactory factory)
            {
                var Car = factory.createCar();
                var Plane = factory.createPlane();

                Console.WriteLine(Plane.planeName());
                Console.WriteLine(Plane.planeName2(Car));
            }

            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ReqgularVehicleFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new SportsVehicleFactory());

            Console.ReadKey();
        }
    }
}
