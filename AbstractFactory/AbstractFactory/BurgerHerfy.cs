using System;

namespace AbstractFactory
{
    public class BurgerHerfy : IAbstractBurger
    {
        public void makeBurger()
        {
            Console.WriteLine("this is a burger from herfy");
        }
    }
}