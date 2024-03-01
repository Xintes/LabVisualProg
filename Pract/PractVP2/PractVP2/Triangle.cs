using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Triangle : RegularPolygon
    {
        private double SideA;
        public double GetSetSideA
        {
            get { return SideA; }
            set
            {
                if (value >= 0)
                {
                    SideA = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double SideB;
        public double GetSetSideB
        {
            get { return SideB; }
            set
            {
                if (value >= 0)
                {
                    SideB = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double SideC;
        public double GetSetSideC
        {
            get { return SideC; }
            set
            {
                if (value >= 0)
                {
                    SideC = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public Triangle(string Name, string Color, double SideA, double SideB, double SideC) : base(Name, Color, 0, 0)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        public override double Perimeter
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }
        public override double GetArea { get { return SideA + SideB + SideC; } }
    }
}
