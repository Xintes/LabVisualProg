using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Rhombus : Parallelagram
    {
        private double Diag1;
        public double GetSetDiag1
        {
            get { return Diag1; }
            set
            {
                if (value >= 0)
                {
                    Diag1 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double Diag2;
        public double GetSetDiag2
        {
            get { return Diag2; }
            set
            {
                if (value >= 0)
                {
                    Diag2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return 2 * Math.Sqrt(Math.Pow(Diag1, 2) + Math.Pow(Diag2, 2)); } }
        public override double GetArea { get { return 1/2 * Diag1 * Diag2; } }
        public Rhombus(string Name, string Color, double Diag1, double Diag2) : base(Name, Color,0,0,0)
        {
            this.Diag1 = Diag1;
            this.Diag2 = Diag2;
        }
    }
}
