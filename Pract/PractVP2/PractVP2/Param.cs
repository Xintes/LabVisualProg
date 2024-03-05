
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Parallelagram : Figure
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
                    sideA = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double hight;
        public double Hight
        {
            get { return hight; }
            set
            {
                if (value >= 0)
                {
                    hight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return 2 * (SideA * SideB); } }
        public override double Area { get { return SideA * Hight; } }
        public Parallelagram(string name, string color, double sideA, double sideB, double hight) : base(name, color)
        {
            SideA = sideA;
            SideB = sideB;
            Hight = hight;
        }
    }
}
