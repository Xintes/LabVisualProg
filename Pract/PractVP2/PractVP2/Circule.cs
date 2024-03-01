using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Circle : Figure
    {
        private double Radius;
        public double GetSetRadius {
            get { return Radius; }
            set
            {  if (value >= 0)
                {
                    Radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        
        public override double Perimeter { get { return 2 * Math.PI * Radius; } }
        public override double GetArea { get { return Math.PI * Math.Pow(Radius, 2); } }
        public Circle(string Name, string Color, double Radius) : base(Name, Color)
        {
            this.Radius = Radius;
        }

    }
}
