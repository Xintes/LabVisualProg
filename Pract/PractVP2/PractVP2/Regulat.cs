using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class RegularPolygon : Figure
    {
        private int NumberOfSide;
        public int GetSetNumberOfSide
        {
            get { return NumberOfSide; }
            set
            {
                if (value >= 0)
                {
                    NumberOfSide = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double SideLenght;
        public double GetSetSideLenght
        {
            get { return SideLenght; }
            set
            {
                if (value >= 0)
                {
                    SideLenght = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return NumberOfSide * Math.Pow(SideLenght, 2) / (4 * Math.Tan(Math.PI / NumberOfSide)); } }
        public override double GetArea { get { return NumberOfSide * SideLenght; } }
        public RegularPolygon(string Name, string Color, double SideLenght, int NumberOfSide) : base(Name, Color)
        {
            this.NumberOfSide = NumberOfSide;
            this.SideLenght = SideLenght;
        }
    }
}
