using AbstractFactory;

public interface ITuwaiqMember
{
    public abstract IAdvancedMember GetAdvancedMember();
    public abstract IBasicMember GetBasicMember();
}