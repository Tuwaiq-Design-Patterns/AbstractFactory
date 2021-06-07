using System;

namespace AbstractFactory
{

    public interface IAbstractFactory
    {
        IWashingMachines CreateProductWashingMachines();
        IFreezer CreateProductFreezer();
    }

    public interface IWashingMachines // first Product
    {
        string UsefulFunctionA();
    }

    public interface IFreezer // second Product
    {
        string UsefulFunctionB();
    }


    
    public class Samsung : IAbstractFactory // first factory
    {
        public IWashingMachines CreateProductWashingMachines()
        {
            return new SamsungWashingMachines();
        }

        public IFreezer CreateProductFreezer()
        {
            return new SamsungFreezer();
        }

    }

    public class SamsungWashingMachines : IWashingMachines
    {
        public string UsefulFunctionA()
        {
            return "The result of the product Samsung Washing Machines.";
        }
    }
    public class SamsungFreezer : IFreezer
    {
        public string UsefulFunctionB()
        {
            return "The result of the product Samsung Freezer.";
        }
    }


    public class LGCorporation : IAbstractFactory // second factory
    {
        public IWashingMachines CreateProductWashingMachines()
        {
            return new LGCorporationWashingMachines();
        }

        public IFreezer CreateProductFreezer()
        {
            return new LGCorporationFreezer();
        }

    }

    public class LGCorporationWashingMachines : IWashingMachines
    {
        public string UsefulFunctionA()
        {
            return "The result of the product LGCorporation Washing Machines.";
        }
    }
    public class LGCorporationFreezer : IFreezer
    {
        public string UsefulFunctionB()
        {
            return "The result of the product LGCorporation Freezer.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client: Testing client code with the first factory type...\n"); // Samsung

            var S1 = new Samsung();
            var S2 = S1.CreateProductWashingMachines();
            Console.WriteLine(S2.UsefulFunctionA());
            
            var S3 = new Samsung();
            var S4 = S3.CreateProductFreezer();
            Console.WriteLine(S4.UsefulFunctionB());

            //--------------------------------------------------------//
            
            Console.WriteLine("\nClient: Testing client code with the second factory type...\n"); // LGCorporation

            var L1 = new LGCorporation();
            var L2 = L1.CreateProductWashingMachines();
            Console.WriteLine(L2.UsefulFunctionA());

            var L3 = new LGCorporation();
            var L4 = L3.CreateProductFreezer();
            Console.WriteLine(L4.UsefulFunctionB());


        }
    }
}
