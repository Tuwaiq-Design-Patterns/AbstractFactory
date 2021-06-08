namespace AbstractFactory
{
    public class StarbucksFactory : CoffeeShopAbstractFactory
    {
        public IBagOfBeans MakeBagOfBeans() => new StarbucksBagOfBeans();
        public ICupOfCoffee MakeCupOfCoffee() => new StarbucksCupOfCoffee();
    }
}