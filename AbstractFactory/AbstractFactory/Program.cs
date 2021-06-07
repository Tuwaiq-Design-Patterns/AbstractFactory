using System;

namespace AbstractFactory
{
    class Program
    {
        public interface RecycleFactory
    {
        BottelsFactory createBottel();

        BagsFactory createBag();

    }
    public interface BagsFactory
    {
        string txtBag();
    }
    public interface BottelsFactory
    {
        string txtBottel();
    }
    public class AramcoFactory : RecycleFactory
    {
        public BottelsFactory createBottel()
        {
            return new Bottel();
        }

        public BagsFactory createBag()
        {
                return new Bag();
        }

    }
    public class SanFactory : RecycleFactory
    {
        public BottelsFactory createBottel()
        {
                return new Bottel();
        }

        public BagsFactory createBag()
        {
                return new Bag();
        }
    }
  
    public class Bottel : BottelsFactory
    {
      

        public string txtBottel()
        {
            return "Bottels made from recycling plastic Bottels!";
        }
    }
    public class Bag : BagsFactory
    {
        public string txtBag()
        {
            return"Bags made from recycling plastic bag!";
        }
    }
   
    
 
        static void Main(string[] args)
        {
            Console.WriteLine("ARAMCO COMPANY PRODUCTS");
            ClientMethod(new AramcoFactory());
            Console.WriteLine("SAN COMPANY PRODUCTS");
            ClientMethod(new SanFactory());


        }
        public static void ClientMethod(RecycleFactory RF)
        {
            var pr = RF.createBag();
            var pr2 = RF.createBottel();
            Console.WriteLine(pr.txtBag());
            Console.WriteLine(pr2.txtBottel());
        }
    }
}
