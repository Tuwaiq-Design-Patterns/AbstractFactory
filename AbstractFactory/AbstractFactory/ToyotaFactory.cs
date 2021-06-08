using System;
namespace AbstractFactory
{
    public class ToyotaFactory : AbstractCarFactory
    {
        public EconomyCar getEconomyCar()
        {
            return new ToyotaEconomyCar();
        }

        public LuxuryCar getLuxuryCar()
        {
            return new ToyotaLuxuryCar();
        }
    }
}
