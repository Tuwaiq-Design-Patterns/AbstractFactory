using System;
using AbstractFactory_GameCharacters.AbstractCharacters;

namespace AbstractFactory_GameCharacters.ConcreteCharacters
{
    public class Frey : IHealer
    {
        public void Heal()
        {
            Console.WriteLine("Healing with Frey");
        }
    }
}