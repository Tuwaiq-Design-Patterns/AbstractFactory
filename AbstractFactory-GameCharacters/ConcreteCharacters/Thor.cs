using System;
using AbstractFactory_GameCharacters.AbstractCharacters;

namespace AbstractFactory_GameCharacters.ConcreteCharacters
{
    public class Thor : IWarrior
    {
        public void Fight()
        {
            Console.WriteLine("Fighting with Thor"); 
        }
    }
}