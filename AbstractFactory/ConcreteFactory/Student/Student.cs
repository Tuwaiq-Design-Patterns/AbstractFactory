using AbstractFactory;

public class Student : ITuwaiqMember
{
    public IBasicMember GetBasicMember()
    {
        return new AdvancedStudent();
    }

    public IAdvancedMember GetAdvancedMember()
    {
        return new BasicStudent();
    }
}