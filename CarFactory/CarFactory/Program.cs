using System;

namespace CarFactory
{


    public interface AbstractCarFactory
    {
        IClassicCar MakeClassicCar();

        IModernCar MakeModernCar();
    }



    class FactoryOne : AbstractCarFactory
    {
        public IClassicCar MakeClassicCar()
        {
            return new Porsche_911();
        }

        public IModernCar MakeModernCar()
        {
            return new Bentley_Flying_Spur();
        }
    }



    public interface IClassicCar
    {
        string MakeCar();
    }

    class Porsche_911 : IClassicCar
    {
        public string MakeCar()
        {
            return " first-generation 911s still have plenty of horsepower and can hold their own on the track";
        }
    }



    public interface IModernCar
    {
        string MakeCar();
    }


    class Bentley_Flying_Spur : IModernCar
    {
        public string MakeCar()
        {
            return "As beautiful inside as its stately exterior suggests, the Flying Spur has amenities that could shame Air Force One.";
        }

    }




class Client
    {
        public  void Order_Classic_car(IClassicCar factory)
        {
            var car1= factory.MakeCar();

            Console.WriteLine(car1);

        }
    
    public void Order_modren_car(IModernCar factory)
    {
            var car2 = factory.MakeCar();

         Console.WriteLine(car2);

    }
}



class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            c.Order_Classic_car(new Porsche_911());

            Console.WriteLine();

            c.Order_modren_car(new Bentley_Flying_Spur());
        }
    }
}
