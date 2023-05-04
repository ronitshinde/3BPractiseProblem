using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BOopsConceptPractiseProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //As object cannot be created of a constructor this is the way to call a constructor
            new ConstructBuilding();
            new ConstructBuilding("BridgeLabz",455213);
            new ConstructBuilding("Velocity",746321,'A',51,64);
            Console.ReadKey();
        }
    }
}
