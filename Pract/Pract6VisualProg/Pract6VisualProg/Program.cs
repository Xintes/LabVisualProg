using System;
using System.Collections.Generic;


class Item
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
}

// Класс исключения при попытке вставить товар с уже существующим артикулом
class ExistingItemCodeException : Exception //
{
    public Item Item { get; }

    //Data
    public ExistingItemCodeException(Item item)
    {
        Item = item;
    }
}

class Shop
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

class Program
{
    static void Main()
    {
        Shop shop = new Shop();
        bool continueAdding = true;

        while (continueAdding)
        {
            try
            {
                Console.Write("Введите артикул предмета: ");
                string article = Console.ReadLine();

                Console.Write("Введите название предмета: ");
                string name = Console.ReadLine();

                Console.Write("Введите цвет предмета: ");
                string color = Console.ReadLine();

                Console.Write("Введите стоимость предмета: ");
                decimal cost = decimal.Parse(Console.ReadLine());

                Item newItem = new Item(article, name, color, cost);
                shop.AddItem(newItem);

                Console.WriteLine("Предмет успешно добавлен в магазин.\n\n");
            }
            catch (ExistingItemCodeException ex)
            {
                Console.WriteLine($"Внимание: Вы пытаетесь добавить предмет {ex.Item.Name} с артиклем {ex.Item.Article}, который уже присутствует в магазине");
                Console.Write("Желаете продолжить добавление предметов? (да/нет): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() != "да")
                {
                    continueAdding = false;
                }
            }
        }

        shop.ShowItem();

        //try
        //{
        //    // 1 случай: генерация исключения и повторное его выбрасывание
        //    try
        //    {
        //        throw new ExistingItemCodeException(new Item());
        //    }
        //    catch (ExistingItemCodeException ex)
        //    {
        //        throw ex;
        //    }
        //}
        //catch (ExistingItemCodeException)
        //{
        //    Console.WriteLine("1 case: Exception caught and rethrown.");
        //}

        //try
        //{
        //    // 2 случай: генерация исключения и его простое выбрасывание
        //    try
        //    {
        //        throw new ExistingItemCodeException(new Item());
        //    }
        //    catch (ExistingItemCodeException ex)
        //    {
        //        throw;
        //    }
        //}
        //catch (ExistingItemCodeException)
        //{
        //    Console.WriteLine("2 case: Exception caught and rethrown.");
        //}
    }
}