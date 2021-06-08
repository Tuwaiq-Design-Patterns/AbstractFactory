using AbstractFactory_GameCharacters.AbstractCharacters;
using AbstractFactory_GameCharacters.AbstractFactory;
using AbstractFactory_GameCharacters.ConcreteCharacters;

namespace AbstractFactory_GameCharacters.ConcreteFactory
{
    public class Angels : IKingdom
    {
        public IHealer Healer()
        {
           return new Odin();
        }

        public IWarrior Warrior()
        {
            return new Thor();
        }
    }
}