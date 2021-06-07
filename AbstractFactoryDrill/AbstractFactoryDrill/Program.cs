using System;

namespace AbstractFactoryDrill
{
    public interface IRecipeFactory
    {
        public abstract ISandwich CreateSandwich();
        public abstract IDessert CreateDessert();
    }

    public interface ISandwich
    {
        string content(); 
    }
        
    public interface IDessert
    {
        string content();
    }
        
    public class Shawerma : ISandwich
    {
        public string content()
        {
            return " [ Shawerma ] ";
        }
    }
    
    public class Kudu : ISandwich
    {
        public string content()
        {
            return "[ Kudu ]" ;
        }
    }
    
    public class CheeseCake : IDessert
    {
        public string content()
        {
            return "[ CheeseCake ]";
        }
    }
    
    public class MiniPancake : IDessert
    {
        public string content()
        {
            return "[ MiniPancake ]";
        }
    }

    public class ShrinpyFactory : IRecipeFactory
    {
        public ISandwich CreateSandwich()
        {
            return new Shawerma(); 
            
        }

        public IDessert CreateDessert()
        {
            return new CheeseCake(); 
        }
    }
    
    public class MamaNoraFactory : IRecipeFactory
    {
        public ISandwich CreateSandwich()
        {
            return new Kudu(); 
        }

        public IDessert CreateDessert()
        {
            return new MiniPancake(); 
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Are a Shawerma allergic person ? (Y) for yes or (N) for no ");
            char input = Console.ReadKey().KeyChar;
            IRecipeFactory factory; 
            switch(input)
            {
                case 'Y':
                    factory = new MamaNoraFactory();
                    break;

                case 'N':
                    factory = new ShrinpyFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }
            
            Console.WriteLine("Your Sandwitch " + factory.CreateSandwich().content() + " Your dessert  " +  factory.CreateDessert().content());
           
            
        }
    }
}