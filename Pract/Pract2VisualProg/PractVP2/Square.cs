using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Square : RegularPolygon
    {
        public Square(string name, string color, double sideLenght) : base(name, color, sideLenght, 0)
        {
        }
        public override double Perimeter { get { return 4 * SideLenght; } }
        public override double Area { get { return SideLenght * SideLenght; } }
        
    }
}
