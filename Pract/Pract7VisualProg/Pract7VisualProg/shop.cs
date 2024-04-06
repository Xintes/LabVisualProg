
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract7VisualProg
{
    // Класс исключения при попытке вставить товар с уже существующим артикулом
    public class ExistingItemCodeException : Exception
    {
        public Item Item { get; }
        public ExistingItemCodeException(Item item)
        {
            Item = item;
        }
    }
    public class Shop
    {
        private List<Item> items;
        public Shop()
        {
            items = new List<Item>();
        }


        public void AddItem(Item newItem)
        {
            foreach (var item in items)
            {
                if (item.Article == newItem.Article)
                {
                    throw new ExistingItemCodeException(newItem);
                }
            }
            items.Add(newItem);
        }

        public void ShowItem()
        {
            Console.WriteLine("В магазине имеется: ");
            foreach (var item in items)
            {

                Console.WriteLine($"{item.Article}, {item.Name}, {item.Color}, {item.Cost}");
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.Cost);

            }
        }

    }
}
