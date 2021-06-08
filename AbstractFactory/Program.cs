using System;

namespace AbstractFactory
{

    public interface IFactory
    {
        public ICentralAC makeCentralAC();
        public IPortableAC makePortableAC();
    }

    public interface IPortableAC
    {
        public string getPortableAC();
    }

    public interface ICentralAC
    {
        public string getCentralAC();
    }

    public class LGFactory : IFactory
    {
        public ICentralAC makeCentralAC()
        {
            return new LGCentralAC();
        }

        public IPortableAC makePortableAC()
        {
            return new LGPortableAC();
        }
    }

    internal class LGPortableAC : IPortableAC
    {
        public string getPortableAC()
        {
            return "LG Portable Air Conditioner";
        }
    }

    internal class LGCentralAC : ICentralAC
    {
        public string getCentralAC()
        {
            return "LG Central Air Conditioner";
        }
    }

    public class FujiFactory : IFactory
    {
        public ICentralAC makeCentralAC()
        {
            return new FujiCentralAC();
        }

        public IPortableAC makePortableAC()
        {
            return new FujiPortableAC();
        }
    }

    internal class FujiPortableAC : IPortableAC
    {
        public string getPortableAC()
        {
            return "Fuji Portable Air Conditioner";
        }
    }

    internal class FujiCentralAC : ICentralAC
    {
        public string getCentralAC()
        {
            return "Fuji Central Air Conditioner";
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            ICentralAC centralAC = (new FujiFactory().makeCentralAC());
            Console.WriteLine(centralAC.getCentralAC());

            IPortableAC portableAC = (new LGFactory().makePortableAC());
            Console.WriteLine(portableAC.getPortableAC());

        }
    }
}
