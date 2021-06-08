using System;
namespace AbstractFactory{
    class EpicGame1 : IEpicGames
    {
        public string getDescription()
        {
            return "Discove the world after a nuke in russia";
        }

        public string getName()
        {
            return "MetroLastLight";
        }

        public string getRate()
        {
            return "8/10";
        }
    }

    class EpicGame2 : IEpicGames
    {
        public string getDescription()
        {
            return "Discove the world after a nuke in russia, added more diffculty and more senarios";
        }

        public string getName()
        {
            return "MetroLastLightV2";
        }

        public string getRate()
        {
            return "9/10";
        }
    }
}