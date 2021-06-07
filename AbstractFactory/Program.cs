using System;

using AbstractFactory.Factory;
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractCSharpBootcampFactory tuwaiq = new TuwaiqFactory();

            tuwaiq.createCourse().printCourseInfo();
            tuwaiq.createContentTeam().printContentTeamInfo();

            IAbstractCSharpBootcampFactory GA = new GeneralAssmblyFactory();

            GA.createCourse().printCourseInfo();
            GA.createContentTeam().printContentTeamInfo();

            IAbstractCSharpBootcampFactory CD = new CodingDojoFactory();

            CD.createCourse().printCourseInfo();
            CD.createContentTeam().printContentTeamInfo();
        }
    }
}
