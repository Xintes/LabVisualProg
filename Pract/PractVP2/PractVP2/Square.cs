using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Square : RegularPolygon
    {
        public Square(string Name, string Color, double SideLenght) : base(Name, Color, SideLenght, 0)
        {
        }
        public override double Perimeter { get { return 4 * GetSetSideLenght; } }
        public override double GetArea { get { return GetSetSideLenght * GetSetSideLenght; } }
    }
}
