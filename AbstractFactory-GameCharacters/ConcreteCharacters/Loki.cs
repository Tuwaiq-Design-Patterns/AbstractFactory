using System;
using AbstractFactory_GameCharacters.AbstractCharacters;

namespace AbstractFactory_GameCharacters.ConcreteCharacters
{
    public class Loki : IWarrior
    {
        public void Fight()
        {
            Console.WriteLine("Fighting with Loki");
        }
    }
}