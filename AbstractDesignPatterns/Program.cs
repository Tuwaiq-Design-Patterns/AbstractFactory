using System;

namespace AbstractDesignPatterns
{

    class Program
    {
        static void Main(string[] args) // client 
        {

            IPhoneProduct appleFactory = new AppleFactory();
            appleFactory.CreatePhone();
        

            IPhoneProduct samsungFactory = new SamsungFactory();
            samsungFactory.CreatePhone();
   
         
        }
    }
    public abstract class  AbstractFactory
    {
        public IPhoneProduct createPhone();
        public  ITabletProduct createTablet();
        public  IWatcheProduct  createWatche();
    }
    public class AppleFactory : AbstractFactory
    {
        public IPhoneProduct CreatePhone()
        {
            return new AppleCreatePhone();
        }
        public ITabletProduct CreateTablet()
        {
            return new AppleCreateTablet();
        }
        public IWatcheProduct CreateWatche()
        {
            return new AppleCreateWatch();
        }
       
    }
    public  class  SamsungFactory : AbstractFactory
    {
      
        public  IPhoneProduct CreatePhone()
        {
            return new SamsungCreatePhone();
        }
        public ITabletProduct CreateTablet()
        {
            return new SamsungCreatetablet();
        }
        public IWatcheProduct CreateWatche()
        {
            return new SamsungCreateWatch();
        }
    }
        public interface IPhoneProduct
        {
        public void CreatePhone();

    }
        public interface ITabletProduct
        {
        public void CreateTablet();

    }
        public interface IWatcheProduct
        {
        public void CreateWatche();

        }
    public class AppleCreatePhone : IPhoneProduct
    {
        public void CreatePhone()
        {
            Console.WriteLine("I Phone");
        }
    }
    public class SamsungCreatePhone : IPhoneProduct
        {
        public void CreatePhone()
        {
            Console.WriteLine("Galaxy");
        }
    }
        public class AppleCreateTablet : ITabletProduct
        {
        public void CreateTablet()
        {
            Console.WriteLine("Ipad");
        }

    }
    public class SamsungCreatetablet : ITabletProduct
    {
        public void CreateTablet()
        {
            Console.WriteLine(" Tablet");
        }
    }
        public class AppleCreateWatch : IWatcheProduct
       
         {
           public void Createwatch()
               {
            Console.WriteLine(" Apple Watch");
                }
         }
    public class SamsungCreateWatch : IWatcheProduct
    {
        public void Createwatch()
        {
            Console.WriteLine(" Galaxy Watch");
        }

    }
    
}
