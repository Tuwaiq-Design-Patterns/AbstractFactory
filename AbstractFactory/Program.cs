using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhonesAbstractFactory appleFactory = new AppleFactory();
            appleFactory.CreateNormalPhone().NormalPhone();
            appleFactory.CreateSmartPhone().SmartPhone();
            
            IPhonesAbstractFactory samsungFactory = new SamsungFactory();
            samsungFactory.CreateNormalPhone().NormalPhone();
            samsungFactory.CreateSmartPhone().SmartPhone();
        }
    }

    interface IPhonesAbstractFactory
    {
        public INormalPhone CreateNormalPhone();
        public ISmartPhone CreateSmartPhone();
    }

    class AppleFactory : IPhonesAbstractFactory
    {
        public INormalPhone CreateNormalPhone()
        {
            return new AppleNormalPhone();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new AppleSmartPhone();
        }
    }

    class SamsungFactory : IPhonesAbstractFactory
    {
        public INormalPhone CreateNormalPhone()
        {
            return new SamsungNormalPhone();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new SamsungSmartPhone();
        }
    }
    
    interface INormalPhone { void NormalPhone(); }
    interface ISmartPhone { void SmartPhone(); }

    class AppleNormalPhone : INormalPhone
    {
        public void NormalPhone()
        {
            Console.WriteLine("Apple Normal Phone.");
        }
    }
    
    class AppleSmartPhone : ISmartPhone
    {
        public void SmartPhone()
        {
            Console.WriteLine("Apple Smart Phone.");
        }
    } 
    
    class SamsungNormalPhone : INormalPhone
    {
        public void NormalPhone()
        {
            Console.WriteLine("Samsung Normal Phone.");
        }
    }
    
    class SamsungSmartPhone : ISmartPhone
    {
        public void SmartPhone()
        {
            Console.WriteLine("Samsung Smart Phone.");
        }
    } 
}