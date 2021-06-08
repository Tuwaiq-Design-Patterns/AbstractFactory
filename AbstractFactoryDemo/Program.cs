using System;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ps5Factory ps5 = new Ps5Factory();
            XboxFactory xbox = new XboxFactory();
            
            Console.WriteLine("Testing PS5 factory");
            ClientMethod(ps5);
            
            Console.WriteLine("Testing Xbox factory");
            ClientMethod(xbox);
        }
        
        
        public static void ClientMethod(IGameAbstractFactory factory)
        {
            var shootingGame = factory.CreateShootingGame();
            var sportGame = factory.CreateSportGame();

            Console.WriteLine(shootingGame.GetShootingGame());
            Console.WriteLine(sportGame.GetSportGame());
        }
    }
}