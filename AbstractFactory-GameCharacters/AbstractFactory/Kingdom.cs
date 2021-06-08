using AbstractFactory_GameCharacters.AbstractCharacters;

namespace AbstractFactory_GameCharacters.AbstractFactory
{
    public interface IKingdom
    {
        public IHealer Healer();
        public IWarrior Warrior();
    }
}