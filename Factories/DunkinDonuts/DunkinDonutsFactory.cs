namespace AbstractFactory
{
    public class DunkinDonutsFactory : CoffeeShopAbstractFactory
    {
        public IBagOfBeans MakeBagOfBeans() => new DunkinDonutsBagOfBeans();
        public ICupOfCoffee MakeCupOfCoffee() => new DunkinDonutsCupOfCoffee();
    }
}