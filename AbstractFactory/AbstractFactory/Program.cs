using System;

namespace AbstractFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ResturantFactory rf = new HerfyFactory();
            IAbstractBurger b = rf.createBurger();
            IAbstractFreachfries fr = rf.createFreachfries();
            b.makeBurger();
            fr.makefries();
            

        }
    }
}