using System;
namespace AbstractFactory{

    public interface ISteamGames{//3
        string getName();
        string getDescription();
        string getRate();
    }
    public interface IEpicGames{//3
         string getName();
        string getDescription();
        string getRate();
    }
    //1
    public interface IGamesFactory{
        ISteamGames InstailSteamGames();
        IEpicGames InstailEpicGames();
    }
}