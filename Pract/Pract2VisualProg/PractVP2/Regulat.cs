
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class RegularPolygon : Figure
    {
        private int numberOfSide;
        public int NumberOfSide
        {
            get { return numberOfSide; }
            set
            {
                if (value >= 0)
                {
                    numberOfSide = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double sideLenght;
        public double SideLenght
        {
            get { return sideLenght; }
            set
            {
                if (value >= 0)
                {
                    sideLenght = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return numberOfSide * Math.Pow(SideLenght, 2) / (4 * Math.Tan(Math.PI / numberOfSide)); } }
        public override double Area { get { return numberOfSide * SideLenght; } }
        public RegularPolygon(string name, string color, double sideLenght, int numberOfSide) : base(name, color)
        {
            NumberOfSide = numberOfSide;
            SideLenght = sideLenght;
        }
    }
}
