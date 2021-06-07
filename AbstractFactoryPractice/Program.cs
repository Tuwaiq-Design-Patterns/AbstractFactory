using System;

namespace AbstractFactoryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory SmartPhoneFactoryApple = FactoryProducer.GetFactory("Apple");
            ISmartPhone smartPhoneApple = SmartPhoneFactoryApple.getSmartPhone("Apple");
            smartPhoneApple.info();

            AbstractFactory SmartPhoneFactorySamsung = FactoryProducer.GetFactory("Samsung");
            ISmartPhone smartPhoneSamsung = SmartPhoneFactorySamsung.getSmartPhone("Samsung");
            smartPhoneSamsung.info();

            AbstractFactory SmartPhoneFactoryHuawei = FactoryProducer.GetFactory("Huawei");
            ISmartPhone smartPhoneHuawei = SmartPhoneFactoryHuawei.getSmartPhone("Huawei");
            smartPhoneHuawei.info();
        }
    }


    public interface ISmartPhone
    {
        public void info();
    }

    public class Apple : ISmartPhone
    {
        public void info()
        {
            Console.WriteLine("IPhone12 Max");
        }
    }

    public class Samsung : ISmartPhone
    {
        public void info()
        {
            Console.WriteLine("Galaxys20");
        }
    }

    public class Huawei : ISmartPhone
    {
        public void info()
        {
            Console.WriteLine("Huawei P30 Pro");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract ISmartPhone getSmartPhone(string smartPhoneType);
    }

    public class AppleFactory : AbstractFactory
    {
        public override ISmartPhone getSmartPhone(string smartPhoneType)
        {
            if (smartPhoneType.Equals("Apple"))
            {
                return new Apple();
            }

            return null;
        }
    }

    public class SamsungFactory : AbstractFactory
    {
        public override ISmartPhone getSmartPhone(string smartPhoneType)
        {
            if (smartPhoneType.Equals("Samsung"))
            {
                return new Samsung();
            }

            return null;
        }
    }

    public class HuaweiFactory : AbstractFactory
    {
        public override ISmartPhone getSmartPhone(string smartPhoneType)
        {
            if (smartPhoneType.Equals("Huawei"))
            {
                return new Huawei();
            }

            return null;
        }
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factory)
        {
            if (factory.Equals("Apple"))
            {
                return new AppleFactory();
            }
            else if (factory.Equals("Samsung"))
            {
                return new SamsungFactory();
            }
            else if (factory.Equals("Huawei"))
            {
                return new HuaweiFactory();
            }

            else return null;
        }
    }



}
