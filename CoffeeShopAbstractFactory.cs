namespace AbstractFactory
{
    public interface CoffeeShopAbstractFactory
    {
        public ICupOfCoffee MakeCupOfCoffee();
        public IBagOfBeans MakeBagOfBeans();
    }
}