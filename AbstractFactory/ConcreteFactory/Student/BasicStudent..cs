using AbstractFactory;

public class BasicStudent : IAdvancedMember
{
    public string GetMemberDetails()
    {
        return "Student: Advanced, Goal: Learn advanced topics, Class: A";
    }
}