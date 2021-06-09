using System;

namespace AbstractFactory
{
    public interface IEasyMonster
    {
        public void ApplyDamage(int damage);
        public void ReceiveDamage(int damage);
    }
    public interface IHardMonster : IEasyMonster
    {
        public void ApplyUltimate(int damage);
    }
    
    public class EasyGoblin : IEasyMonster
    {
        private const double GoblinDamageScale = 0.25;
        private const double GoblinArmor = 0.1;
        
        public void ApplyDamage(int damage)
        {
            Console.WriteLine($"Easy goblin damaged the player {damage + damage * GoblinDamageScale}hp");
        }

        public void ReceiveDamage(int damage)
        {
            Console.WriteLine($"Easy goblin received damage from the player {damage - damage * GoblinArmor}hp");
        }
    }
    public class EasyDemon : IEasyMonster
    {
        private const double DemonDamageScale = 0.6;
        private const double DemonArmor = 0.3;
        
        public void ApplyDamage(int damage)
        {
            Console.WriteLine($"Easy demon damaged the player {damage + damage * DemonDamageScale}hp");
        }

        public void ReceiveDamage(int damage)
        {
            Console.WriteLine($"Easy demon received damage from the player {damage - damage * DemonArmor}hp");
        }
    }
    public class HardGoblin : IHardMonster
    {
        private const double UltimateDamageScale = 3;
        private const double DemonDamageScale = 1;
        private const double DemonArmor = 0.5;
        
        public void ApplyUltimate(int damage)
        {
            Console.WriteLine($"Hard goblin damaged the player {damage + damage * UltimateDamageScale}hp with ultimate");
        }
        
        public void ApplyDamage(int damage)
        {
            Console.WriteLine($"Hard goblin damaged the player {damage + damage * DemonDamageScale}hp");
        }

        public void ReceiveDamage(int damage)
        {
            Console.WriteLine($"Hard goblin received damage from the player {damage - damage * DemonArmor}hp");
        }
    }
    public class HardDemon : IHardMonster
    {
        private const double UltimateDamageScale = 5;
        private const double DemonDamageScale = 2;
        private const double DemonArmor = 0.9;
        
        public void ApplyUltimate(int damage)
        {
            Console.WriteLine($"Hard demon damaged the player {damage + damage * UltimateDamageScale}hp");
        }
        
        public void ApplyDamage(int damage)
        {
            Console.WriteLine($"Hard demon damaged the player {damage + damage * DemonDamageScale}hp");
        }

        public void ReceiveDamage(int damage)
        {
            Console.WriteLine($"Hard demon received damage from the player {damage - damage * DemonArmor}hp");
        }
    }
    
    public interface IMonsterFactory
    {
        public IEasyMonster MakeEasyMonster();
        public IHardMonster MakeHardMonster();
    }
    public class GoblinFactory : IMonsterFactory
    {
        public IEasyMonster MakeEasyMonster()
        {
            return new EasyGoblin();
        }

        public IHardMonster MakeHardMonster()
        {
            return new HardGoblin();
        }
    }
    public class DemonFactory : IMonsterFactory
    {
        public IEasyMonster MakeEasyMonster()
        {
            return new EasyDemon();
        }
        
        public IHardMonster MakeHardMonster()
        {
            return new HardDemon();
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Easy monsters
            IMonsterFactory factory = new GoblinFactory();
            IEasyMonster easyMonster1 = factory.MakeEasyMonster();
            IHardMonster hardMonster1 = factory.MakeHardMonster();
            
            factory = new DemonFactory();
            IEasyMonster easyMonster2 = factory.MakeEasyMonster();
            IHardMonster hardMonster2 = factory.MakeHardMonster();
            
            // Easy
            Console.WriteLine("Easy monsters");
            easyMonster1.ApplyDamage(10);
            easyMonster1.ReceiveDamage(10);

            easyMonster2.ApplyDamage(10);
            easyMonster2.ReceiveDamage(10);
            
            // Hard
            hardMonster1.ApplyDamage(10);
            hardMonster1.ReceiveDamage(10);
            hardMonster1.ApplyUltimate(10);

            hardMonster2.ApplyDamage(10);
            hardMonster2.ReceiveDamage(10);
            hardMonster2.ApplyUltimate(10);
        }
    }
}