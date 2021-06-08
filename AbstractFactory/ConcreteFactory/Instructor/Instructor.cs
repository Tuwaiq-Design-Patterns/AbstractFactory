using AbstractFactory;

public class Instructor : ITuwaiqMember
{
    public IBasicMember GetBasicMember()
    {
        return new AdvancedInstructor();
    }

    public IAdvancedMember GetAdvancedMember()
    {
        return new BasicInstructor();
    }
}