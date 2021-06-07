using System;

namespace AbstractFactory
{
public interface IAbstractFactory
    {
        IAbstractPort CreatePort();

        IAbstractProtocol CreateProtocol();
    }

    class HttpConcreteFactory : IAbstractFactory
    {
        private readonly bool _secure;

        public HttpConcreteFactory(bool secure)
        {
            _secure = secure;
        }
        public IAbstractPort CreatePort()
        {
            return _secure ?  new HttpSecurePort() :  new HttpPort();
        }

        public IAbstractProtocol CreateProtocol()
        {
            return _secure ? new HttpSecureProtocol() : new HttpProtocol();
        }
    }

    class FtpConcreteFactory : IAbstractFactory
    {
        private readonly bool _secure;

        public FtpConcreteFactory(bool secure)
        {
            _secure = secure;
        }
        public IAbstractPort CreatePort()
        {
            return _secure ? new FtpSecurePort() : new FtpPort();
        }

        public IAbstractProtocol CreateProtocol()
        {
            return _secure ? new FtpSecureProtocol() : new FtpProtocol();
        }
    }

    public interface IAbstractPort
    {
        string GetPortNumber();
    }

    public interface IAbstractProtocol
    {
        string GetProtocol();
    }


    class HttpPort : IAbstractPort
    {
        public string GetPortNumber()
        {
            return "80";
        }
    }

    class HttpProtocol : IAbstractProtocol
    {
        public string GetProtocol()
        {
            return "http";
        }
    }

    class HttpSecurePort : IAbstractPort
    {
        public string GetPortNumber()
        {
            return "443";
        }
    }

    class HttpSecureProtocol : IAbstractProtocol
    {
        public string GetProtocol()
        {
            return "https";
        }
    }
    

    class FtpPort : IAbstractPort
    {
        public string GetPortNumber()
        {
            return "21";
        }
    }

    class FtpProtocol : IAbstractProtocol
    {
        public string GetProtocol()
        {
            return "ftp";
        }
    }

    class FtpSecurePort : IAbstractPort
    {
        public string GetPortNumber()
        {
            return "22";
        }
    }

    class FtpSecureProtocol : IAbstractProtocol
    {
        public string GetProtocol()
        {
            return "sftp";
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Requesting http product from the http factory ... ");
            ClientMethod(new HttpConcreteFactory(false));
            Console.WriteLine("---------------------");

            Console.WriteLine("Requesting a secure variant of http from the http factory ... ");
            ClientMethod(new HttpConcreteFactory(true));
            Console.WriteLine("---------------------");

            Console.WriteLine("Requesting ftp product from the http factory ... ");
            ClientMethod(new FtpConcreteFactory(false));
            Console.WriteLine("---------------------");

            Console.WriteLine("Requesting a secure variant of ftp from the http factory ... ");
            ClientMethod(new FtpConcreteFactory(true));
            Console.WriteLine("---------------------");
        }

        public static void ClientMethod(IAbstractFactory factory)
        {
            var protocol = factory.CreateProtocol();
            var port = factory.CreatePort();
            Console.WriteLine($"Protocol is: {protocol.GetProtocol()} and runs on port: {port.GetPortNumber()}");
        }
        
    }
}