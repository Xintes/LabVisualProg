using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Triangle : RegularPolygon
    {
        private double sideA;
        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value >= 0)
                {
                    sideA = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double sideB;
        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value >= 0)
                {
                    sideB = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double sideC;
        public double SideC
        {
            get { return sideC; }
            set
            {
                if (value >= 0)
                {
                    sideC = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public Triangle(string name, string color, double sideA, double sideB, double sideC) : base(name, color, 0, 0)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double Perimeter
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }
        public override double Area { get { return SideA + SideB + SideC; } }
    }
}
