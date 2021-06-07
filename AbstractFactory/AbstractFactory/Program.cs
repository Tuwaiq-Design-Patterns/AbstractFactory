using System;

namespace AbstractFactory
{
    //Big Factory
    public interface IAbstractFactory
    {
        IAbstractProductBag CreateProductBag();
        IAbstractProductSunglasses CreateProductSunglasses();
    }
 //concrete class 1
    class CucciFactory : IAbstractFactory
    {
        public IAbstractProductBag CreateProductBag()
        {
            return new ConcreteProductCucciBag();
        }

        public IAbstractProductSunglasses CreateProductSunglasses()
        {
            return new ConcreteProductCucciSunglasses();
        }
    }

    //concrete class 2
    class LvFactory : IAbstractFactory
    {
        public IAbstractProductBag CreateProductBag()
        {
            return new ConcreteProductLVBag();
        }

        public IAbstractProductSunglasses CreateProductSunglasses()
        {
            return new ConcreteProductLVSunglasses();
        }
    }
    //Bag  interface
    public interface IAbstractProductBag
    {
        string Bag();
    }

    // Concrete class =  that implemented Bag interface , cucci bag
    class ConcreteProductCucciBag : IAbstractProductBag
    {
        public string Bag()
        {
            return "Cucci Bag";
        }
    }
    // Concrete class =  that implemented Bag interface , LV bag
    class ConcreteProductLVBag : IAbstractProductBag
    {
        public string Bag()
        {
            return "LV Bag";
        }
    }
    // Sunglasses interface
    public interface IAbstractProductSunglasses
    {
        string Sunglasses();
    }

    //class implement the second product Cucci Sunglaass
    class ConcreteProductCucciSunglasses : IAbstractProductSunglasses
    {
        public string Sunglasses()
        {
            return "Cucci Sunglasses";
        }
    }
    //class implement the second product LV Sunglaass
    class ConcreteProductLVSunglasses : IAbstractProductSunglasses
    {
        public string Sunglasses()
        {
            return "LV Sunglasses";
        }
    }

    class Client
    {
        public void Main()
        { 
            Console.WriteLine("Client: Wants Cucci Brand"); //Cucci Facotry
            ClientMethod(new CucciFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Wants LV Brand "); //LV Facotry
            ClientMethod(new LvFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productBag = factory.CreateProductBag();
            var productSunglasses = factory.CreateProductSunglasses();

            Console.WriteLine(productBag.Bag());
            Console.WriteLine(productSunglasses.Sunglasses());
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


