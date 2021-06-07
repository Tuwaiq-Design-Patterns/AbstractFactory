using System;

namespace abstracFactory
{
     public interface CarsAbstractFactory  {
        public IElectriCar CreateElectriCar();
        public IPetrolCar CreatePetrolCar();
    }

    class Toyota : CarsAbstractFactory
    {
        public IElectriCar CreateElectriCar()
        {
            return new ToytaElectriCar();
        }

        public IPetrolCar CreatePetrolCar()
        {
            return new ToytaPetrolCar();
        }
    }
    class Honda : CarsAbstractFactory
    {
        public IElectriCar CreateElectriCar()
        {
            return new HondaElectriCar();
        }

        public IPetrolCar CreatePetrolCar()
        {
            return new HondaPetrolCar();
        }
    }

    public interface IElectriCar{ public void electricar(); }

    public interface IPetrolCar{ public void petrolcar(); }


    public class ToytaPetrolCar : IPetrolCar {
    public void petrolcar()
        {
            Console.WriteLine("The car company is Toyota and its petrol");
        }
    }

    public class ToytaElectriCar : IElectriCar { 
    public void electricar()
        {
            Console.WriteLine("The car company is Toyota and its electri");

        }
    }

    public class HondaPetrolCar : IPetrolCar {
        public void petrolcar()
        {
            Console.WriteLine("The car company is Honda and its petrol");

        }
    }

    public class HondaElectriCar : IElectriCar { 
    
    
    public void electricar()
        {
            Console.WriteLine("The car company is Honda and its electri");
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            CarsAbstractFactory HondaCars = new Honda();
            HondaCars.CreateElectriCar().electricar();
            HondaCars.CreatePetrolCar().petrolcar();
            CarsAbstractFactory ToytaCars = new Toyota();
            ToytaCars.CreateElectriCar().electricar();
            ToytaCars.CreatePetrolCar().petrolcar();



                }
    }
}
