using System;

namespace LabTopFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var HpNormalLabTop = new HpLabTopFactory();
            var Hp2In1LabTop = new HpLabTopFactory();
            Console.WriteLine("Hp Normal LabTop"+HpNormalLabTop.MakeNormalLapTop().TouchScreen());
            Console.WriteLine("Hp 2In1 LabTop "+Hp2In1LabTop.Make2In1LapTop().Detach());
            Console.WriteLine("Hp 2In1 LabTop "+Hp2In1LabTop.Make2In1LapTop().TouchScreen());
            
            var MicrosoftNormalLapTop = new MicrosoftLabTopFactory();
            var Microsoft2In1LapTop = new MicrosoftLabTopFactory();

            Console.WriteLine("Microsoft Normal LabTop"+MicrosoftNormalLapTop.MakeNormalLapTop().TouchScreen());
            Console.WriteLine("Microsoft 2In1 LabTop "+Microsoft2In1LapTop.Make2In1LapTop().Detach());
            Console.WriteLine("Microsoft 2In1 LabTop "+Microsoft2In1LapTop.Make2In1LapTop().TouchScreen());
            
        }
    }
}
