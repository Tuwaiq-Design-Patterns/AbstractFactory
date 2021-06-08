using System;

namespace makeupAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ImakeupFactory ForEverMakeup = new ForEver();
            Client ForeverClient = new Client(ForEverMakeup);
            ImakeupFactory RevolutionMakeup = new Revolution();
            Client RevoluionClient = new Client(RevolutionMakeup);


            //Output

            Console.WriteLine(" ForEver Products \n ");
            Console.WriteLine(" - Foundation: ");
            Console.WriteLine(ForeverClient.GetFoundation());
            Console.WriteLine();
            Console.WriteLine(" - Blush ");
            Console.WriteLine(ForeverClient.GetBlush());
            Console.WriteLine(" \n ################################### \n ");
            Console.WriteLine(" Revolution Products \n ");
            Console.WriteLine(" - Foundation: ");
            Console.WriteLine(RevoluionClient.GetFoundation());
            Console.WriteLine();
            Console.WriteLine(" - Blush ");
            Console.WriteLine(RevoluionClient.GetBlush());


        }
        interface ImakeupFactory

        {
            IFoundation GetFoundation();
            IBlush GetBlush();
        }

 
        class ForEver : ImakeupFactory
        {
            public IFoundation GetFoundation()
            {
                return new ForEverFoundation();
            }

            public IBlush GetBlush()
            {
                return new ForEverBlush();
            }
        }

        class Revolution : ImakeupFactory
        {
            public IFoundation GetFoundation()
            {
                return new RevolutionFoundation();
            }

            public IBlush GetBlush()
            {
                return new RevolutionBlush();
            }
        }

        interface IFoundation
        {
            string makeupSpecifications();
        }

        interface IBlush
        {
            string makeupSpecifications();
        }

     
        class ForEverFoundation : IFoundation
        {
            public string makeupSpecifications()
            {
                return "A palette with 12 shades of acclaimed Ultra HD Stick Foundation for creamy, " +
                    "medium-to-full coverage with a long-lasting, natural finish.";
      }
        }


        class ForEverBlush : IBlush
        {
            public string makeupSpecifications()
            {
                return "A customizable selection of invisible cover cream blushes with a soft and easy-to-apply " +
                    "texture that brings makeup to life with a natural hint of color.";
            }
        }

        
        class RevolutionFoundation : IFoundation
        {
            public string makeupSpecifications()
            {
                return "With 50 shades and suitable for all skin types, " +
                    "our range of foundations gives you the best start to create that iconic look. ";
            }
        }


        class RevolutionBlush : IBlush
        {
            public string makeupSpecifications()
            {
                return "Amazing blushers to shop like the Heart Breakers by I Heart Revolution," +
                    " the Reloaded Blushers by Makeup Revolution and more!";
            }
        }

        class Client
        {
            IFoundation FoundationMakeup;
            IBlush BlushMakeup;
            public Client(ImakeupFactory factory)
            {
                FoundationMakeup = factory.GetFoundation();
                BlushMakeup = factory.GetBlush();
            }
            public string GetFoundation()
            {
                return FoundationMakeup.makeupSpecifications();
            }
            public string GetBlush()
            {
                return BlushMakeup.makeupSpecifications();
            }
        }
       
    }
}