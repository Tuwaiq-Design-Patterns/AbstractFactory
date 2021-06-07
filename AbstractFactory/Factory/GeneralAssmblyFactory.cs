using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.ContentTeam;
using AbstractFactory.Course;

namespace AbstractFactory.Factory
{
    public class GeneralAssmblyFactory : IAbstractCSharpBootcampFactory
    {
        public ICourse createCourse()
        {
            return new GeneralAssmblyCSharpCourse();
        }
        public IContentTeam createContentTeam()
        {
            return new GeneralAssmblyContentTeam();
        }
    }
}
