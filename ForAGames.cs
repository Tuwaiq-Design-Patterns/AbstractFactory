using System;

namespace AbstractFactory{

    class ForAGames : IGamesFactory
    {
        public IEpicGames InstailEpicGames()//2
        {
            return new EpicGame1();
        }

        public ISteamGames InstailSteamGames()
        {
            return new SteamGame2();
        }
    }

    
}