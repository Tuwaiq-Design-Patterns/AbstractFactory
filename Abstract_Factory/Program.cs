using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }

    class Client
    {
        public void Main()
        {
            // this example just like a luck-game of two rooms (as factories) with different things on it (as products)

            Console.Write("\nChoose a number for the room you want... (1 or 2) ");
            int room =int.Parse(Console.ReadLine());
            if (room == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Room #1:");
                ClientMethod(new ConcreteRoom1());
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Room #2:");
                ClientMethod(new ConcreteRoom2());
            }
        }

        public void ClientMethod(IAbstractRoom room)
        {
            var door = room.CreateDoor();
            var treasure = room.CreateTreasure();

            Console.WriteLine(door.OpenTo());
            Console.WriteLine(treasure.Coins());
        }
    }

    public interface IAbstractRoom
    {
        IAbstractDoor CreateDoor();

        IAbstractTreasure CreateTreasure();
    }

    class ConcreteRoom1 : IAbstractRoom
    {
        public IAbstractDoor CreateDoor()
        {
            return new ConcreteDoor1();
        }

        public IAbstractTreasure CreateTreasure()
        {
            return new ConcreteTreasure1();
        }
    }

    class ConcreteRoom2 : IAbstractRoom 
    {
        public IAbstractDoor CreateDoor()
        {
            return new ConcreteDoor2(); 
        }

        public IAbstractTreasure CreateTreasure()
        {
            return new ConcreteTreasure2();
        }
    }

    // Eatch room have it's own door and open to a different place
    public interface IAbstractDoor
    {
        string OpenTo();
    }

    // Eatch room have it's own treasure
    public interface IAbstractTreasure
    {
        string Coins();
    }

    class ConcreteDoor1 : IAbstractDoor
    {   
        public string OpenTo()
        {
            return "Door for room #1 opens to dead end (Oops) ";
        }
    }
    class ConcreteDoor2 : IAbstractDoor
    {
        public string OpenTo()
        {
            return "Door for room #2 opens to the last point (YOU WON!!)";
        }
    }

    class ConcreteTreasure1 : IAbstractTreasure
    {
        public string Coins()
        {
            return "You got 20 coins in room #1";
        }
    }

    class ConcreteTreasure2 : IAbstractTreasure
    {
        public string Coins()
        {
            return "You got 1000 coins in room #2";
        }
    }
}
