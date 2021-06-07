using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ContentTeam
{
    public class CodingDojoContentTeam : IContentTeam
    {
        public void printContentTeamInfo()
        {
            Console.WriteLine("This is Coding Dojo Content Team");
        }
    }
}
