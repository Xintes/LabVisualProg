using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Regtangle : Parallelagram
    {
        public override double Perimeter { get { return 2 * (GetSetSideA * GetSetSideB); } }
        public override double GetArea { get { return GetSetSideA * GetSetSideB; } }
        public Regtangle(string Name, string Color, double sideA, double sideB, double hight) : base(Name, Color, sideA, sideB, hight)
        {
        }
    }
}
