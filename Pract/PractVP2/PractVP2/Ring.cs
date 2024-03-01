using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Ring : Circle
    {
        private double InsideRadius;
        public double GetInsideRadius
        {
            get { return InsideRadius; }
            set
            {
                if (value >= 0)
                {
                    InsideRadius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return 2 * Math.PI * (GetSetRadius + InsideRadius); } }
        public override double GetArea { get { return Math.PI * (Math.Pow(GetSetRadius, 2) - Math.Pow(InsideRadius, 2)); } }
        public Ring(string Name, string Color, double Radius, double InsideRadius) : base(Name, Color, Radius)
        {
            this.InsideRadius = InsideRadius;
        }
    }
}
