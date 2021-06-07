namespace AbstractFactory
{
    public interface ResturantFactory
    {
        IAbstractBurger createBurger();
        IAbstractFreachfries createFreachfries();
    }
}