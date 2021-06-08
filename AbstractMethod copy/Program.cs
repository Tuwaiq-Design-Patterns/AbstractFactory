using System;

namespace AbstractMethod
{
    /*-------------Abstract Factory------------*/
    public interface IAbstractFactory
    {
        public IPlate makePlate();
        public ICup makeCup();

    }
    /*------------------------------------------*/


    /*concreate Factory 1. MicrowaveSafe 2. NonMicrosafe*/

    class MicrowaveSafeFactory : IAbstractFactory
    {
        public IPlate makePlate()
        {
            return new MicrowaveSafePlate();
        }
        public ICup makeCup()
        {
            return new MicrowaveSafeCup();
        }

    }

    class NonMicrowaveSafeFactory : IAbstractFactory
    {
        public IPlate makePlate()
        {
            return new NonMicrowaveSafePlate();
        }
        public ICup makeCup()
        {
            return new NonMicrowaveSafeCup();
        }

    }

    /*------------------------------------------*/


    /*interface of Products: 1.Plate 2.Cup*/

    public interface IPlate
    {
        string getPlateDetails();

    }

    public interface ICup
    {
        string getCupDetails();
    }
    /*------------------------------------------*/

    /*concrete products MicrowaveSafe(1.Plate 2.Cup) , NonMicrowaveSafe(1.Plate 2.Cup)*/

    class MicrowaveSafePlate : IPlate
    {
        public string getPlateDetails()
        {
            return " Palete Details: { Material: Ceramic, Size: 10'inch, Price: $20 }";
        }
    }

    class NonMicrowaveSafePlate : IPlate
    {
        public string getPlateDetails()
        {
            return " Palete Details: { Material: Metalic, size: 13'inch, Price: $35 }";
        }
    }

    class MicrowaveSafeCup : ICup
    {
        public string getCupDetails()
        {
            return " Cup Details: { Material: Glass, Size: 20-oz , Price: $12 } ";
        }
    }

    class NonMicrowaveSafeCup : ICup
    {
        public string getCupDetails()
        {
            return " Cup Details: { Material: plastic, Size: 16-oz, Price: $3 }";
        }
    }
    /*--------------------------------------------------------------------------------*/

    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("\n\n\tClient Rested from Microwave Safe Factory \n\n");
            ClientMethod(new MicrowaveSafeFactory());
            

            Console.WriteLine("\n\n\n\tClient Rested from Non Microwave Safe Factory \n\n");
            ClientMethod(new NonMicrowaveSafeFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var MSplate = factory.makePlate();
            var NMScup = factory.makeCup();

            Console.WriteLine(NMScup.getCupDetails());
            Console.WriteLine("\n"+ MSplate.getPlateDetails());
            Console.WriteLine("\n ################################################################################");
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
