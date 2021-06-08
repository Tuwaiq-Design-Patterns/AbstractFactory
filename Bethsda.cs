using System;

namespace AbstractFactory{

    class Bethsda : IGamesFactory //2
    {

        IEpicGames IGamesFactory.InstailEpicGames()
        {
             return new EpicGame2();
        }

        ISteamGames IGamesFactory.InstailSteamGames()
        {
            return new SteamGame1();
        }
    }
}