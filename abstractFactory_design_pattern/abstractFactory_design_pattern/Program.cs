using System;

namespace abstractFactory_design_pattern
{
    class Program
    {
        //abstract factory
        interface IMobilePhone
        {
            ISmartPhone GetSmartPhone();
        }
        //concrete factory
        class Apple : IMobilePhone
        {
            public ISmartPhone GetSmartPhone()
            {
                return new iPhone();
            }
        }
        class Samsung : IMobilePhone
        {
            public ISmartPhone GetSmartPhone()
            {
                return new Galaxy();
            }
        }
        //abstract product
        public interface ISmartPhone
        {
            string GetPhoneSpecs();
        }
        //product
        class iPhone : ISmartPhone
        {
            string ISmartPhone.GetPhoneSpecs()
            {
                return "OS: iOS, display: retina, company: apple";
            }
        }
        class Galaxy : ISmartPhone
        {
            string ISmartPhone.GetPhoneSpecs()
            {
                return "OS: android, display: led, company: samsung";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("first factory type:");
            ClientMethod(new Apple());
            Console.WriteLine("========================");
            Console.WriteLine("second factory type:");
            ClientMethod(new Samsung());
        }

         static void ClientMethod(IMobilePhone factory)
        {
            var productA = factory.GetSmartPhone();
            Console.WriteLine(productA.GetPhoneSpecs());
        }

    }
}
////client
//class Client
//{
//    public void Main()
//    {
//        Console.WriteLine("first factory type:");
//        ClientMethod(new Apple());
//        Console.WriteLine("========================");

//        Console.WriteLine("second factory type:");
//        ClientMethod(new Samsung());
//    }

//    public void ClientMethod(IMobilePhone factory)
//    {
//        var productA = factory.GetSmartPhone();
//        Console.WriteLine(productA.GetPhoneSpecs());
//    }
//}