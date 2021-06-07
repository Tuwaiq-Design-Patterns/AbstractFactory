using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Course;
using AbstractFactory.ContentTeam;

namespace AbstractFactory.Factory
{
    public interface IAbstractCSharpBootcampFactory
    {
        public ICourse createCourse();
        public IContentTeam createContentTeam();
    }
}
