using System;
namespace AbstractFactory{
    class SteamGame1 : ISteamGames
    {
        public string getDescription()
        {
            return "No-Comment Best Game Ever";
        }

        public string getName()
        {
            return "Skyrim";
        }

        public string getRate()
        {
            return "10/10";
        }
    }

    class SteamGame2 : ISteamGames
    {
        public string getDescription()
        {
            return "Imagine afre many years the world has been nuked many times, how the life gona be";
        }

        public string getName()
        {
            return "Fallout4";
        }

        public string getRate()
        {
            return "8/10";
        }
    }
}