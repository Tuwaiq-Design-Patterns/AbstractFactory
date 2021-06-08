using System;
using AbstractFactory_GameCharacters.AbstractCharacters;

namespace AbstractFactory_GameCharacters.ConcreteCharacters
{
    public class Odin : IHealer
    {
        public void Heal()
        {
            Console.WriteLine("Healing with Odin");
        }
    }
}