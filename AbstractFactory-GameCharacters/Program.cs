using System;
using AbstractFactory_GameCharacters.AbstractFactory;
using AbstractFactory_GameCharacters.ConcreteFactory;

namespace AbstractFactory_GameCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            IKingdom kingdom = null;
            
            Console.WriteLine("Select Kingdom");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Devils");
            Console.WriteLine("2. Angels");
            Console.WriteLine("----------------------");

            switch (Console.ReadLine())
            {
                case "1":
                    kingdom = new Devils();
                    break;
                case "2":
                    kingdom = new Angels();
                    break;
                default:
                    kingdom = new Devils();
                    break;
            }

            Console.WriteLine();
            kingdom.Healer().Heal();
            kingdom.Warrior().Fight();
        }
    }
}