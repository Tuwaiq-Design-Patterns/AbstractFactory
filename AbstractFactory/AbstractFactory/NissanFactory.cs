using System;
namespace AbstractFactory
{
    public class NissanFactory : AbstractCarFactory
    {

        public EconomyCar getEconomyCar()
        {
            return new NissanEconomyCar();
        }

        public LuxuryCar getLuxuryCar()
        {
            return new NissanLuxuryCar();
        }
    }
}
