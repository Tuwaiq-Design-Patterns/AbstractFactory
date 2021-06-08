namespace AbstractFactoryDemo
{
    public interface IGameAbstractFactory
    {
        IShootingGame CreateShootingGame();

        ISportGame CreateSportGame();
    }
}