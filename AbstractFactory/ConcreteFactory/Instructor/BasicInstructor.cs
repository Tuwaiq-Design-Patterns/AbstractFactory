using AbstractFactory;

public class BasicInstructor : IAdvancedMember
{
    public string GetMemberDetails()
    {
        return "Instructor: Advanced, Role: Teach advanced topics, Class: A";
    }
}