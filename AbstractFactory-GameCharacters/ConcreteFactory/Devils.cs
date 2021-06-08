using AbstractFactory_GameCharacters.AbstractCharacters;
using AbstractFactory_GameCharacters.AbstractFactory;
using AbstractFactory_GameCharacters.ConcreteCharacters;

namespace AbstractFactory_GameCharacters.ConcreteFactory
{
    public class Devils  : IKingdom
    {
        public IHealer Healer()
        {
            return new Frey();
        }

        public IWarrior Warrior()
        {
            return new Thor();
        }
    }
}