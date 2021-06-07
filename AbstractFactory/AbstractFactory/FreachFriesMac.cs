using System;

namespace AbstractFactory
{
    public class FreachFriesMac: IAbstractFreachfries
    {
        public void makefries()
        {
            Console.WriteLine("this is a fries from mac");
        }
    }
}