using System;

class Program
{
    public interface SkinCareFactory
    {
        IToner createToner();

        ICleanser createCleanser();

    }
    public interface ICleanser
    {
        string txtCleanser();
    }
    public interface IToner
    {
        string txtToner();
    }
    public class CosrxFactory : SkinCareFactory
    {
        public IToner createToner()
        {
            return new Toner();
        }

        public ICleanser createCleanser()
        {
            return new Cleanser();
        }

    }
    public class GlowFactory : SkinCareFactory
    {
        public IToner createToner()
        {
            return new Toner();
        }

        public ICleanser createCleanser()
        {
            return new Cleanser();
        }
    }

    public class Toner : IToner
    {


        public string txtToner()
        {
            return "Toner: Use me daily after cleansing!";
        }
    }
    public class Cleanser : ICleanser
    {
        public string txtCleanser()
        {
            return "Cleanser: Use me twice daily";
        }
    }



    static void Main(string[] args)
    {
        Console.WriteLine("COSRX PRODUCTS");
        ClientMethod(new CosrxFactory());
        Console.WriteLine("Glow PRODUCTS");
        ClientMethod(new GlowFactory());


    }
    public static void ClientMethod(SkinCareFactory SCF)
    {
        var pr = SCF.createCleanser();
        var pr2 = SCF.createToner();
        Console.WriteLine(pr.txtCleanser());
        Console.WriteLine(pr2.txtToner());
    }
}