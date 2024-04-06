
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius {
            get { return radius; }
            set
            {  if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        
        public override double Perimeter { get { return 2 * Math.PI * radius; } }
        public override double Area { get { return Math.PI * Math.Pow(radius, 2); } }
        public Circle(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

    }
}
