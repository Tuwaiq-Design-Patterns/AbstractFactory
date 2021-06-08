namespace AbstractFactoryDemo
{
    public class Ps5Factory : IGameAbstractFactory
    {
        public IShootingGame CreateShootingGame()
        {
            return new ShootGame1();
        }

        public ISportGame CreateSportGame()
        {
            return new FootballGame1();
        }
    }
}