using System;

namespace AbstractFactory
{
    public class BurgerMac:IAbstractBurger
    {
        public void makeBurger()
        {
            Console.WriteLine("this is a burger from MAC");
        }
    }
}