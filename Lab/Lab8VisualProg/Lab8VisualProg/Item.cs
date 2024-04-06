using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8VisualProg
{
    public class Item: IComparable<Item>
    {
        public string Article { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Cost { get; set; }
        public Item(string article, string name, string color, decimal cost)
        {
            Article = article;
            Name = name;
            Color = color;
            Cost = cost;
        }
        public int CompareTo(Item other)
        {
            return Article.CompareTo(other.Article);
        }
    }
}
