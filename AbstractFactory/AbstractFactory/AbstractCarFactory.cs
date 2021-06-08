using System;
namespace AbstractFactory
{
    public interface AbstractCarFactory
    {

        public LuxuryCar getLuxuryCar();
        public EconomyCar getEconomyCar();

    }

}
