using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Parallelagram : Figure
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
        private double Hight;
        public double GetSetHight
        {
            get { return Hight; }
            set
            {
                if (value >= 0)
                {
                    Hight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return 2 * (GetSetSideA * GetSetSideB); } }
        public override double GetArea { get { return GetSetSideA * GetSetHight; } }
        public Parallelagram(string Name, string Color, double sideA, double sideB, double hight) : base(Name, Color)
        {
            SideA = sideA;
            SideB = sideB;
            Hight = hight;
        }
    }
}
