using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual double Perimeter { get; }
        public virtual double GetArea { get; }
        public Figure(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public override string ToString()
        {
            return $"Название: {Name}\nЦвет: {Color}\nПериметр: {Perimeter}\nПлощадь: {GetArea}";
        }
    }

}
