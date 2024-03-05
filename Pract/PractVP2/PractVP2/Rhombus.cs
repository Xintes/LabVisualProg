using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public class Rhombus : Parallelagram
    {
        private double diag1;
        public double Diag1
        {
            get { return diag1; }
            set
            {
                if (value >= 0)
                {
                    diag1 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        private double diag2;
        public double Diag2
        {
            get { return diag2; }
            set
            {
                if (value >= 0)
                {
                    diag2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным.");
                }
            }
        }
        public override double Perimeter { get { return 2 * Math.Sqrt(Math.Pow(diag1, 2) + Math.Pow(diag2, 2)); } }
        public override double Area { get { return 1/2 * diag1 * diag2; } }
        public Rhombus(string name, string color, double diag1, double diag2) : base(name, color, 0,0,0)
        {
            Diag1 = diag1;
            Diag2 = diag2;
        }
    }
}
