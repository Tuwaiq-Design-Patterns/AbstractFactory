using System;

namespace AbstractFactory
{
    public interface IBoss{
        public string getBoss();
    }
    public interface IArmy{
        public string getArmy();
    }
    public interface IAward{
        public string getAward();
    }
    public interface ILevelFactory
    {
        public IArmy MakeArmy();
        public IBoss MakeBoss();
        public IAward MakeAward();
    }
    public class AquaKing : IBoss
    {
        public string getBoss() =>  "(눈_눈) <-- HOW DARE YOU DISTURB MY SILENCE";
    }
    public class SkyWatcher : IBoss
    {
        public string getBoss() => "ヾ(｀◇´)ﾉ彡 <-- YOU BELONG TO THE DIRT";
    }
    public class LandConqueror : IBoss
    {
        public string getBoss() => "(∩⌣̀_⌣́) <-- AHH, YARE YARE"; // ( ‾᷅⚰‾᷄ )
    }
    public class AquaArmy : IArmy
    {
        public string getArmy() => "୧༼ಠ益ಠ༽୨ ୧༼ಠ益ಠ༽୨ ୧༼ಠ益ಠ༽୨ ୧༼ಠ益ಠ༽୨ ୧༼ಠ益ಠ༽୨";
    }
    public class SkyArmy : IArmy
    {
        public string getArmy() => "＼(｀0´)／ ＼(｀0´)／ ＼(｀0´)／ ＼(｀0´)／ ＼(｀0´)／";
    }
    public class LandArmy : IArmy
    {
        public string getArmy() => "(ノ≧┏Д┓≦)ノ (ノ≧┏Д┓≦)ノ (ノ≧┏Д┓≦)ノ (ノ≧┏Д┓≦)ノ (ノ≧┏Д┓≦)ノ";
    }
    public class Pearl : IAward
    {
        public string getAward() => "* O *";
    }
    public class Sirius : IAward
    {
        public string getAward() => "ミ★";
    }
    public class Daimond : IAward 
    {
        public string getAward() => "✧*。✧*。";
    }
    public class Ocean : ILevelFactory
    {
        public IArmy MakeArmy(){
            return new AquaArmy();
        }
        public IBoss MakeBoss(){
            return new AquaKing();
        }
        public IAward MakeAward(){
            return new Pearl();
        }
    }
    public class Desert : ILevelFactory
    {
        public IArmy MakeArmy(){
            return new LandArmy();
        }
        public IBoss MakeBoss(){
            return new LandConqueror();
        }
        public IAward MakeAward(){
            return new Daimond();
        }
    }
    public class Ether : ILevelFactory
    {
        public IArmy MakeArmy(){
            return new SkyArmy();
        }
        public IBoss MakeBoss(){
            return new SkyWatcher();
        }
        public IAward MakeAward(){
            return new Sirius();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILevelFactory CurrentLevel = new Desert(); // change levels here
            Console.WriteLine(
                CurrentLevel.MakeArmy().getArmy() + "\n\n" +
                CurrentLevel.MakeBoss().getBoss() + "\n\n" +
                CurrentLevel.MakeAward().getAward() 
            );
            
        }
    }
}
