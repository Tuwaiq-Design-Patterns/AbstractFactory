namespace AbstractFactoryDemo
{
    public class XboxFactory : IGameAbstractFactory
    {
        public IShootingGame CreateShootingGame()
        {
            return new ShootGame2();
        }

        public ISportGame CreateSportGame()
        {
            return new FootballGame2();
        }
    }
}