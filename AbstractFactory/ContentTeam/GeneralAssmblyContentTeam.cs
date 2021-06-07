using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ContentTeam
{
    public class GeneralAssmblyContentTeam : IContentTeam
    {
        public void printContentTeamInfo()
        {
            Console.WriteLine("This is General Assmbly Content Team");
        }
    }
}
