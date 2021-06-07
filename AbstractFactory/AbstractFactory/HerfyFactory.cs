namespace AbstractFactory
{
    public class HerfyFactory: ResturantFactory

    {
        public IAbstractBurger createBurger()
        {
            return new BurgerHerfy();
        }

        public IAbstractFreachfries createFreachfries()
        {
            return new FreachFriesHerfy();
        }
    }
}