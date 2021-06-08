using System;

namespace AbstractFactory
{

    //-------Specifications--------//
    public interface Iilatic
    {
       string writeIilaticAlphabatics();
    }

    public interface IBold
    {
        string writeIBoldAlphabatics();
    }
    //-----------------------------//

    //-------The main factory--------//
    public interface IFontsAbstractFactory
    {
        public Iilatic makeIlaticFont();

        public IBold makeBoldFont();
    }
    //-----------------------------//


    //-------Sub factories--------//

    public class CritterFactory : IFontsAbstractFactory
    {
        public IBold makeBoldFont()
        {
           return new CritterBold();

        }

        public Iilatic makeIlaticFont()
        {
                return new CritterIlatic();

        }
    }

    class StuzFactory : IFontsAbstractFactory
    {
        public IBold makeBoldFont()
        {
            return new StuzIBold();

        }

        public Iilatic makeIlaticFont()
        {
            return new StuzIilatic();

        }
    }
    //------------------------------//


    //-------Products of Critter--------//

    public class CritterBold : IBold
    {
        public string writeIBoldAlphabatics()
        {
            return "Your text changed to Critter with Bold pro";
        }
    }

    public class CritterIlatic : Iilatic
    {
        public string writeIilaticAlphabatics()
        {
            return "Your text changed to Critter with Ilatic pro";
        }
    }

    ////-------Products of Stuz--------//

    public class StuzIBold : IBold
    {
        public string writeIBoldAlphabatics()
        {
            return "Your text changed to Stuz with Bold pro";
        }
    }

    public class StuzIilatic : Iilatic
    {
        public string writeIilaticAlphabatics()
        {
            return "Your text changed to Stuz with Ilatic pro";
        }
    }
    ////-----------------------------//


    //-------Client class--------//
    class Client
    {
        public void Main()
        {
            //1. CritterFactory
            Console.WriteLine("\nClient request: Critter Factory\n");
            ClientReq(new CritterFactory());
            Console.WriteLine("-------------------");

            //2. StuzFactory
            Console.WriteLine("\nClient request: Stuz Factory\n");
            ClientReq(new StuzFactory());
            Console.WriteLine("-------------------");

        }

        public void ClientReq(IFontsAbstractFactory factory)
        {
            //1.Bold Request
            var Bold = factory.makeBoldFont();
            Console.WriteLine(Bold.writeIBoldAlphabatics());

            //2.Ilatic Request 
            var Ilatic = factory.makeIlaticFont();
            Console.WriteLine(Ilatic.writeIilaticAlphabatics());
        }
    }

    //-----------------------------//

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Console.WriteLine("-----Good Desgin Pattren ^_^ -----");
        }
    }
}
