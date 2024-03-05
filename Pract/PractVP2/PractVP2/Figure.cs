using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractVP2
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual double Perimeter { get; }
        public virtual double Area { get; }
        public Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return $"Название: {Name}\nЦвет: {Color}\nПериметр: {Perimeter}\nПлощадь: {Area}";
        }
    }

}
