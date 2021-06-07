using System;



namespace AbstractFactoryDesignPattern
{
    
        public interface IManufacturer
        {
            public IScreen CreateScreen();

            public ISystemOnChip CreateSystemOnChip();
        }
        public class Apple : IManufacturer
        {
            public IScreen CreateScreen()
            {
                return new RetinaScreen();
            }
            public ISystemOnChip CreateSystemOnChip()
            {
                return new SoCM1();
            }
        }
        class Samsung : IManufacturer
        {
            public IScreen CreateScreen()
            {
                return new OLEDScreen();
            }
            public ISystemOnChip CreateSystemOnChip()
            {
                return new SoCExoynes();
            }
        }
        public interface IScreen
        {
            string TwoKResolution();
        }
        class RetinaScreen : IScreen
        {
            public string TwoKResolution()
            {
                return "Retina screen has a resolution of 2K.";
            }
        }
        class OLEDScreen : IScreen
        {
            public string TwoKResolution()
            {
                return "OLED screen has a resolution of 2K.";
            }
        }

        public interface ISystemOnChip
        {
            string Compute();
            string DisplayOnScreen();
        }
        class SoCM1 : ISystemOnChip
        {
            public string Compute()
            {
                return "Powered by M1 chip.";
            }
            public string DisplayOnScreen()
            {
                return "SOC is rendering on the Retina screen.";

            }
        }
        class SoCExoynes : ISystemOnChip
        {
            public string Compute()
            {
                return "Powered by Exoynes.";
            }
            public string DisplayOnScreen()
            {
                return "SOC is rendering on the OLED screen.";

            }
        }

    public class Program
    {
        // client:
        public static void Main(string[] args)
        {
            IManufacturer AppleManufacturer  = new Apple();
            Console.WriteLine("Apple spec: ");
            var screenApple = AppleManufacturer.CreateScreen().TwoKResolution();
            var socApple = AppleManufacturer.CreateSystemOnChip();
            
            Console.WriteLine(socApple.DisplayOnScreen() + "\n" + socApple.Compute() + "\n" + screenApple);
            

            Console.WriteLine("\n");



            IManufacturer SamsungManufacturer = new Samsung();
            Console.WriteLine("Samsung spec: ");
            var screenSam = SamsungManufacturer.CreateScreen().TwoKResolution();
            var socSam = SamsungManufacturer.CreateSystemOnChip();

           Console.WriteLine(socSam.DisplayOnScreen() + "\n" + socSam.Compute() + "\n" + screenSam);

        }
    }

}
