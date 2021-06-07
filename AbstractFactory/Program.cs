using System;

namespace AbstractFactory
{

  
    public interface IBakery
    {
        ICookies BakeCookie();

        ICupcake BakeCupcake();
    }

    class HananBakery : IBakery
    {
        public ICookies BakeCookie()
        {
            return new ChocolateCookies();
        }

        public ICupcake BakeCupcake()
        {
            return new ChocolateCupcake();
        }
    }

    class NorahBakery : IBakery
    {
        public ICookies BakeCookie()
        {
            return new ButterCookies();
        }

        public ICupcake BakeCupcake()
        {
            return new RainbowCupcake();
        }
    }

  
    public interface ICookies
    {
        string eatCookies();
    }

    class ChocolateCookies : ICookies
    {
        public string eatCookies()
        {
            return "yummy .. the best chocolate cookie ever !";
        }
    }

    class ButterCookies : ICookies
    {
        public string eatCookies()
        {
            return "best butter cookie in town";
        }
    }


    public interface ICupcake
    {
        string eatCupcake();

      
    }

    class ChocolateCupcake : ICupcake
    {
        public string eatCupcake()
        {
            return "I like the chocolate cupcake";
        }

   

    }

    class RainbowCupcake : ICupcake
    {
        public string eatCupcake()
        {
            return "The rainbow cupcake is good";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you think of Hanan bakery cupcake and cookies ? ");
            ClientMethod(new HananBakery());

            Console.WriteLine();

            Console.WriteLine("What do you think of Norah bakery cupcake and cookies ?");
            ClientMethod(new NorahBakery());

        }

        public static void ClientMethod(IBakery factory)
        {
            var productA = factory.BakeCookie();
            var productB = factory.BakeCupcake();

            Console.WriteLine(productA.eatCookies());
            Console.WriteLine(productB.eatCupcake());

        }
    }
}