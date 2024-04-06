using Pract7VisualProg;
using System;
using System.Collections.Generic;

namespace run
{
    public class Program
    {
        public static void Main(string[] args)
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
        }
    }
}


