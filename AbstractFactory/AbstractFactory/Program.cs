using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolFactory sf = new classFactory();
            Console.WriteLine(sf.makeClass().makeChair());
            Console.WriteLine(sf.makeClass().makeTable());
            Console.WriteLine(sf.makeCafeteria().makeFood());
        }
    }
    public interface SchoolFactory
    {
        public Iclass makeClass();
        public Icafeteria makeCafeteria();
    }

    public interface Icafeteria
    {
        public string makeFood();
    }

    public interface Iclass
    {
        public string makeChair();
        public string makeTable();
    }

    public class Classes : Iclass
    {
        public string makeChair() => "Chair :)";

        public string makeTable() => "Table XD";
    }

    public class Caf : Icafeteria
    {
        public string makeFood() => "Food :(";
    }
    public class classFactory : SchoolFactory
    {
        public Icafeteria makeCafeteria() => new Caf();

        public Iclass makeClass() => new Classes();
    }
}
