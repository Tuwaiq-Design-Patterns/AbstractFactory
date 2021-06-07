using System;

namespace AbstractFactory_AppleSamsung
{
    class Program
    {
        interface IabstractFactory
        {
            void CreateMobile();
            void CreateLabtop();
        }

        class ConcrteFactoryApple : IabstractFactory
        {
            public void CreateMobile() { Console.WriteLine("Apple phone"); }

            public void CreateLabtop() { Console.WriteLine("Apple Laptop"); }
        }
        class ConcrteFactorySamsung : IabstractFactory
        {
            public void CreateMobile() { Console.WriteLine("samsunge phone"); }

            public void CreateLabtop() { Console.WriteLine("samsunge Laptop"); }
        }

        interface IProductMobile { }
        class ProductAppleMobile : IProductMobile { }
        class ProductSamungMobile : IProductMobile { }

        interface IProductLabtop { }
        class ProductAppleLabtop : IProductLabtop { }
        class ProductsamsungLabtop : IProductLabtop { }

        static void Main(string[] args)
        {
            IabstractFactory AppleObject = new ConcrteFactoryApple();
            AppleObject.CreateMobile();
            AppleObject.CreateLabtop();
            IabstractFactory SamsungeObject = new ConcrteFactorySamsung();
            SamsungeObject.CreateMobile();
            SamsungeObject.CreateLabtop();
        }
    }
}
