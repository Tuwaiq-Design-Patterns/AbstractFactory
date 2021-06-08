using System;
namespace AbstractFactory{

     class Consumer
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("The company `ForAGames` has introduced many games lately");
            ConsumerMethod(new ForAGames());
            Console.WriteLine();

            Console.WriteLine("The company `Bethsa` has introduced many games lately");
            ConsumerMethod(new Bethsda());
        }

        public void ConsumerMethod(IGamesFactory factory)
        {
            var productA = factory.InstailSteamGames();
            var productB = factory.InstailEpicGames();

            Console.WriteLine(productB.getName());
            Console.WriteLine(productB.getDescription());
            Console.WriteLine(productB.getRate());

             Console.WriteLine(productA.getName());
            Console.WriteLine(productA.getDescription());
            Console.WriteLine(productA.getRate());

        }
    }
}