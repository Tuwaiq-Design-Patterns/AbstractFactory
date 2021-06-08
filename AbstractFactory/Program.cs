using System;

namespace AbstractFactory
{

    public interface IAbstractFactory
    {
        public ICar createCar();
        public ITruck createTruck();
        public ISuv createSuv();
    }

    /////////////////////////////////////

    public class Mercedes : IAbstractFactory
    {
        public ICar createCar()
        {
            return new Sclass();
        }

        public ISuv createSuv()
        {
            return new GWagon();
        }

        public ITruck createTruck()
        {
            return new XclassTruck();
        }
    }


    public class Ford : IAbstractFactory
    {
        public ICar createCar()
        {
            return new Crown_Victoria();
        }

        public ISuv createSuv()
        {
            return new Explorer();
        }

        public ITruck createTruck()
        {
            return new Rapror();
        }
    }

    /////////////////////////////////////

    public interface ICar 
    {
        public string getVehicle();
    }

    public interface ITruck
    {
        public string getVehicle();
    }

    public interface ISuv
    {
        public string getVehicle();
    }


    //////////////////////////////////////
    

    public class Sclass : ICar
    {
        public string getVehicle()
        {
            return "Mercedes - Sclass (4-DOOR CAR)";
        }
    }

    public class GWagon : ISuv
    {
        public string getVehicle()
        {
            return "Mercedes - G-Wagon (SUV)";
        }
    }

    public class XclassTruck : ITruck
    {
        public string getVehicle()
        {
            return "Mercedes - XclassTruck (TRUCK) ";
        }
    }


    public class Crown_Victoria : ICar
    {
        public string getVehicle()
        {
            return "FORD - Crown Victoria (4-DOOR CAR)";
        }
    }

    public class Explorer : ISuv
    {
        public string getVehicle()
        {
            return "FORD - Explorer (SUV)";
        }
    }

    public class Rapror : ITruck
    {
        public string getVehicle()
        {
            return "FORD - Raptor (TRUCK)";
        }
    }





    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("********* MERC **********");

            IAbstractFactory merccar = new Mercedes();

            Console.WriteLine(merccar.createCar().getVehicle());
            Console.WriteLine(merccar.createSuv().getVehicle());
            Console.WriteLine(merccar.createTruck().getVehicle());


            Console.WriteLine("\n");




            Console.WriteLine("******* BMW **********");

            IAbstractFactory bmwcar = new Ford();

            Console.WriteLine(bmwcar.createCar().getVehicle());
            Console.WriteLine(bmwcar.createSuv().getVehicle());
            Console.WriteLine(bmwcar.createTruck().getVehicle());



        }
    }
}
