using System;

namespace abstracFactory
{
   
        public interface IUtensilsFactory
        {
            ICup CreateCup();
            IPlate CreatePlate();
        }
        class MicrowaveSafeFactory : IUtensilsFactory
        {
            public ICup CreateCup()
            {
                return new Cup_MicowaveSafe();
            }

            public IPlate CreatePlate()
            {
                return new Plate_MicowaveSafe();
            }
        }
        class NonMicrowaveSafeFactory : IUtensilsFactory
        {
            public ICup CreateCup()
            {
                return new Non_Cup_MicowaveSafe();
            }

            public IPlate CreatePlate()
            {
                return new Non_Plate_MicowaveSafe();
            }
        }
        public interface ICup
        {
            string Cup_Type();
        }

        class Cup_MicowaveSafe : ICup
        {
            public string Cup_Type()
            {
                return "Micowave Safe Cup";
            }
        }
        class Non_Cup_MicowaveSafe : ICup
        {
            public string Cup_Type()
            {
                return "NoN - Micowave Safe Cup";
            }
        }
        public interface IPlate
        {
            string Plate_Type();
            string Plate_Type2(ICup c);

        }
        class Plate_MicowaveSafe : IPlate
        {
            public string Plate_Type()
            {
                return "Micowave Safe Plate";
            }
            public string Plate_Type2(ICup c)
            {
                var result = c.Cup_Type();

                return $"The result of the Type ({result})";
            }
        }
        class Non_Plate_MicowaveSafe : IPlate
        {
            public string Plate_Type()
            {
                return "Non - Micowave Safe plate";
            }
            public string Plate_Type2(ICup c)
            {
                var result = c.Cup_Type();

                return $"The result of Type ({result})";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {

                void Client(IUtensilsFactory factory)
                {
                    var Cup = factory.CreateCup();
                    var Plate = factory.CreatePlate();

                    Console.WriteLine(Plate.Plate_Type());
                    Console.WriteLine(Plate.Plate_Type2(Cup));
                }

                Console.WriteLine("Type of the Utensils");
                Client(new MicrowaveSafeFactory());
                Console.WriteLine();

                Console.WriteLine("Type of the Utensils");
                Client(new NonMicrowaveSafeFactory());

              
            }
        }
    }


