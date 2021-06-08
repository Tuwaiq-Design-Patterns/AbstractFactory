using System;

namespace AbstractFactory
{
    class Program
    {
        interface IPerfumsFactory

        {
            IOUDPerfums GetOUDPerfums();
            IMUSKPerfums GetMUSKPerfums();
        }

        // The 'ConcreteFactory1' class.  
        class AbdulsamadAlQurashi : IPerfumsFactory
        {
            public IOUDPerfums GetOUDPerfums()
            {
                return new AbdulsamadSpecialOUD();
            }

            public IMUSKPerfums GetMUSKPerfums()
            {
                return new AbdulsamadMUSK();
            }
        }

        // The 'ConcreteFactory2' class.  
        class IbrahemAlQurashi : IPerfumsFactory
        {
            public IOUDPerfums GetOUDPerfums()
            {
                return new IbrahemSpecialOUD();
            }

            public IMUSKPerfums GetMUSKPerfums()
            {
                return new IbrahemMUSK();
            }
        }
        // The 'AbstractProductA' interface  
        interface IOUDPerfums
        {
            string GetPerfumeDetails();
        }
        // The 'AbstractProductB' interface  
        interface IMUSKPerfums
        {
            string GetPerfumeDetails();
        }

        // The 'ProductA1' class  
        class AbdulsamadSpecialOUD : IOUDPerfums
        {
            public string GetPerfumeDetails()
            {
                return "It reveals more than eighty years of aging and the pulse of life" +
                    " comes in you from the heart of the Indian incense sticks";
            }
        }

        // The 'ProductA2' class  
        class AbdulsamadMUSK : IMUSKPerfums
        {
            public string GetPerfumeDetails()
            {
                return "A concentrated perfume with the finest types of very rare black deer musk and amber";
            }
        }

        // The 'ProductB1' class  
        class IbrahemSpecialOUD : IOUDPerfums
        {
            public string GetPerfumeDetails()
            {
                return "This original mixture came with a distinctive" +
                    " wood scent mixed with old oud fat and drops of Taif rose.";
            }
        }

        // The 'ProductB2' class  
        class IbrahemMUSK : IMUSKPerfums
        {
            public string GetPerfumeDetails()
            {
                return "It is a mixture that combines serum and white musk," +
                    " resulting in Ibrahim Al Qurashi's unique mixture.";
            }
        }


        // The 'Client' class  
        class PerfumeClient
        {
            IOUDPerfums OUDPerfumes;
            IMUSKPerfums MUSKPerfumes;
            public PerfumeClient(IPerfumsFactory factory)
            {
                OUDPerfumes = factory.GetOUDPerfums();
                MUSKPerfumes = factory.GetMUSKPerfums();
            }
            public string GetOUDDetails()
            {
                return OUDPerfumes.GetPerfumeDetails();
            }
            public string GetMiskDetails()
            {
                return MUSKPerfumes.GetPerfumeDetails();
            }
        }
        static void Main(string[] args)
        {
            IPerfumsFactory AbdusamadAlQurashiPerfume = new AbdulsamadAlQurashi();
            PerfumeClient AbdusamadAlQurashiClient = new PerfumeClient(AbdusamadAlQurashiPerfume);

            Console.WriteLine("--------- AbdusamadAlQurashi -----------");
            Console.WriteLine("--------- OUD ---------");
            Console.WriteLine(AbdusamadAlQurashiClient.GetOUDDetails());
            Console.WriteLine();
            Console.WriteLine("--------- MUSK --------");
            Console.WriteLine(AbdusamadAlQurashiClient.GetMiskDetails());
            Console.WriteLine();
            IPerfumsFactory IbrahemAlQurashiPerfume = new IbrahemAlQurashi();
            PerfumeClient IbrahemAlQurashiClient = new PerfumeClient(IbrahemAlQurashiPerfume);

            Console.WriteLine("---------- IbrahemAlQurashi ------------");
            Console.WriteLine("--------- OUD ----------");
            Console.WriteLine(IbrahemAlQurashiClient.GetOUDDetails());
            Console.WriteLine();
            Console.WriteLine("---------- MUSK ---------");
            Console.WriteLine(IbrahemAlQurashiClient.GetMiskDetails());
            Console.WriteLine();

        }
    }
}
