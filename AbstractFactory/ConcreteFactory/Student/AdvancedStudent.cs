using AbstractFactory;

public class AdvancedStudent : IBasicMember
{
    public string GetMemberDetails()
    {
        return "Student: Basic, Goal: Build strong foundation, Class: B";
    }
}