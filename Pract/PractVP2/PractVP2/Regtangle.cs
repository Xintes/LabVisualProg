using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Regtangle : Parallelagram
    {
        public override double Perimeter { get { return 2 * (SideA * SideB); } }
        public override double Area { get { return SideA * SideB; } }
        public Regtangle(string name, string color, double sideA, double sideB, double hight) : base(name, color, sideA, sideB, hight)
        {
        }
    }
}
