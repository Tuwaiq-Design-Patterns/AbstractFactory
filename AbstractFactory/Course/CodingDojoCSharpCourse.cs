using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Course
{
    public class CodingDojoCSharpCourse : ICourse
    {
        public void printCourseInfo()
        {
            Console.WriteLine("This is Coding Dojo C Sharp Course");
        }
    }
}
