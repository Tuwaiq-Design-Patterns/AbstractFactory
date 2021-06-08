using System;

namespace AbstractFactory
{
    interface SoftDrinks
    {
        ISoftDrinks GetSoftDrinks();
        ISoftDrinksPro GetSoftDrinksGlass();
    }

    class Miranda : SoftDrinks
    {
        public ISoftDrinks GetSoftDrinks()
        {
            return new Miranda1();
        }

        public ISoftDrinksPro GetSoftDrinksGlass()
        {
            return new Miranda2();
        }
    }

    class Pepsi : SoftDrinks
    {
        public ISoftDrinks GetSoftDrinks()
        {
            return new Pepsi1();
        }

        public ISoftDrinksPro GetSoftDrinksGlass()
        {
            return new Pepsi2();
        }
    }

    interface ISoftDrinks
    {
        string GetModelDetails();
    }

    interface ISoftDrinksPro
    {
        string GetModelDetails();
    }

    class Miranda1 : ISoftDrinks
    {
        public string GetModelDetails()
        {
            return "Miranda1";
        }
    }

    class Pepsi1 : ISoftDrinks
    {
        public string GetModelDetails()
        {
            return "Pepsi1";
        }
    }

    class Miranda2 : ISoftDrinksPro
    {
        public string GetModelDetails()
        {
            return "Miranda2";
        }
    }

    class Pepsi2 : ISoftDrinksPro
    {
        public string GetModelDetails()
        {
            return "Pepsi2";
        }
    }

    class SoftDrinksClient
    {
        ISoftDrinks smartPhone;
        ISoftDrinksPro normalPhone;

        public SoftDrinksClient(SoftDrinks factory)
        {
            smartPhone = factory.GetSoftDrinks();
            normalPhone = factory.GetSoftDrinksGlass();
        }

        public string GetSoftDrinksModelDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetSoftDrinksGlassModelDetails()
        {
            return normalPhone.GetModelDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SoftDrinks Miranda = new Miranda();
            SoftDrinksClient MirandaClient = new SoftDrinksClient(Miranda);

            Console.WriteLine("********* Miranda **********");
            Console.WriteLine(MirandaClient.GetSoftDrinksModelDetails());
            Console.WriteLine(MirandaClient.GetSoftDrinksGlassModelDetails());

            SoftDrinks Pepsi = new Pepsi();
            SoftDrinksClient PepsiClient = new SoftDrinksClient(Pepsi);

            Console.WriteLine("******* Pepsi **********");
            Console.WriteLine(PepsiClient.GetSoftDrinksModelDetails());
            Console.WriteLine(PepsiClient.GetSoftDrinksGlassModelDetails());

            Console.ReadKey();
        }
    }
}
