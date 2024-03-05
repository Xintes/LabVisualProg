using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Ring : Circle
    {
        private double insideRadius;
        public double InsideRadius
        {
            get { return insideRadius; }
            set
            {
                if (value >= 0)
                {
                    insideRadius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return 2 * Math.PI * (Radius + insideRadius); } }
        public override double Area { get { return Math.PI * (Math.Pow(Radius, 2) - Math.Pow(insideRadius, 2)); } }
        public Ring(string name, string color, double radius, double insideRadius) : base(name, color, radius)
        {
            InsideRadius = insideRadius;
        }
    }
}
