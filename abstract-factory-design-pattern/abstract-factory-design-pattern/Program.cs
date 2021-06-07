using System;

namespace abstract_factory_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory #1

            AbstractFactory Apple = new AppleFactory();
            AbstractPhone phone1 = Apple.CreatePhone();
            AbstractTablet tablet1 = Apple.CreateTablet();

            Console.WriteLine("Phone one type : " + phone1.GetType());
            Console.WriteLine("tablet one type : " + tablet1.GetType());

            Console.WriteLine();
            Console.WriteLine();
            // Abstract factory #2

            AbstractFactory Sumsung = new SamsungFactory();
            AbstractPhone phone2 = Sumsung.CreatePhone();
            AbstractTablet tablet2 = Sumsung.CreateTablet();

            Console.WriteLine("Phone one type : " + phone2.GetType());
            Console.WriteLine("tablet one type : " + tablet2.GetType());


            Console.ReadKey();
        }
    }


    // The 'AbstractFactory' abstract class
    abstract class AbstractFactory

    {
        public abstract AbstractPhone CreatePhone();
        public abstract AbstractTablet CreateTablet();
    }



    // The 'ConcreteFactory1' class
    class AppleFactory : AbstractFactory

    {
        public override AbstractPhone CreatePhone()
        {
            return new iPhone();
        }
        public override AbstractTablet CreateTablet()
        {
            return new iPad();
        }
    }



    // The 'ConcreteFactory2' class
    class SamsungFactory : AbstractFactory

    {
        public override AbstractPhone CreatePhone()
        {
            return new S20();
        }
        public override AbstractTablet CreateTablet()
        {
            return new T20();
        }
    }



    // The 'AbstractProductA' abstract class
    abstract class AbstractPhone

    {

    }


    // The 'AbstractProductB' abstract class
    abstract class AbstractTablet

    {
   /*     public abstract void Interact(AbstractProductA a);*/
    }



    // The 'ProductA1' class
    class iPhone : AbstractPhone
    {
    /*    public iPhone(string model)
        {
            this.Model = model;
        }
        public string Model { get; set; }
        public override string ToString()
        {
            return "IPhone " + Model;
        }*/
    }



    // The 'ProductB1' class
    class iPad : AbstractTablet

    {

    }



    // The 'ProductA2' class
    class S20 : AbstractPhone

    {
    }



    // The 'ProductB2' class
    class T20 : AbstractTablet

    {

    }

   
}
