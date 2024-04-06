using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8VisualProg
{
    // Класс исключения при попытке вставить товар с уже существующим артикулом
    class ExistingItemCodeException : Exception
    {
        public Item Item { get; }
        public ExistingItemCodeException(Item item)
        {
            Item = item;
        }
    }
}
