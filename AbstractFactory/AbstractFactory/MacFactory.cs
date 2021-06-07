namespace AbstractFactory
{
    public class MacFactory : ResturantFactory

    {
        public IAbstractBurger createBurger()
        {
            return new BurgerMac();
        }

        public IAbstractFreachfries createFreachfries()
        {
            return new FreachFriesMac();
        }
    }
}