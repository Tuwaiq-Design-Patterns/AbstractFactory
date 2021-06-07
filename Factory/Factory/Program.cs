
// Code on abstract factory desgin pattren
using System;

namespace Factory
{
    class Program
    {
        interface Chair
        {
            public void hasLegs();
            public void sitOn();
        }
        public class VictorianChair : Chair
        {

            public void hasLegs()
            {
                Console.WriteLine("has four legs");
            }
            public void sitOn()
            {
                Console.WriteLine("You can");

            }
        }


        public class ModrenChair : Chair
        {

            public void hasLegs()
            {
                Console.WriteLine("has 3 legs");

            }
            public void sitOn()
            {
                Console.WriteLine("You can");
            }


        }

        static void Main(string[] args)
        {
            ModrenChair mod = new ModrenChair();
            mod.hasLegs();
            mod.sitOn();
            VictorianChair vic = new VictorianChair();
            vic.hasLegs();
            vic.sitOn();

        }
    }
    }
