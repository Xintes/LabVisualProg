using Lab8VisualProg;

// Создаем объект класса Tree с типом int
Tree<int> tree = new Tree<int>();

// Вставляем элементы в дерево
tree.Insert(9);
tree.Insert(2);
tree.Insert(7);
tree.Insert(8);
tree.Insert(3);
tree.Insert(6);
tree.Insert(5);

foreach (int element in tree)
{
    Console.Write($"{element} ");
}

// Проверяем наличие элемента в дереве
int elementToFind = 3;
bool found = tree.Find(3);
if (found)
    Console.WriteLine($"\nЭлемент {elementToFind} найден в дереве");
else
    Console.WriteLine($"\nЭлемент {elementToFind} не найден в дереве");

// Удаляем элемент из дерева
int elementToRemove = 2;
tree.Remove(elementToRemove);
Console.WriteLine($"Элемент {elementToRemove} удален из дерева");

// Выводим элементы дерева в порядке возрастания
Console.WriteLine("Элементы дерева в порядке возрастания:");
foreach (int element in tree)
{
    Console.Write($"{element} ");
}

//------------------------------------------------------Работа с ITEM

//Tree<Item> itemTree = new Tree<Item>();

//Item item0 = new Item("5", "Футболка", "Черный", 500);
//Item item1 = new Item("2", "Футболка", "Черный", 500);
//Item item2 = new Item("7", "Джинсы", "Синий", 1000);
//Item item3 = new Item("3", "Рубашка", "Белый", 800);
//Item item4 = new Item("9", "Рубашка", "Белый", 800);
//Item item5 = new Item("8", "Рубашка", "Белый", 800);


//itemTree.Insert(item0);
//itemTree.Insert(item1);
//itemTree.Insert(item2);
//itemTree.Insert(item3);
//itemTree.Insert(item4);
//itemTree.Insert(item5);

//Console.WriteLine("Предметы, добавленные в дерево:");

//foreach (var item in itemTree)
//{
//    Console.WriteLine($"{item.Article}, {item.Name}, {item.Color}, {item.Cost}");
//}

//Console.WriteLine();

//int foundNum = 3;
//Console.WriteLine($"Поиск предмета с артикулом {foundNum}:");
//bool found = itemTree.Find(new Item($"{foundNum}", "", "", 0));

//if (found) Console.WriteLine("Предмет найден!\n");
//else Console.WriteLine("Предмет не найден.\n");


//Console.WriteLine($"Удаление предмета с артикулом {foundNum}:");
//bool removed = itemTree.Remove(new Item($"{foundNum}", "", "", 0));

//if (removed) Console.WriteLine("Предмет успешно удален из дерева.\n");
//else Console.WriteLine("Предмет не найден в дереве.\n");



//Console.WriteLine("Оставшиеся предметы в дереве:");

//foreach (var item in itemTree)
//{
//    Console.WriteLine($"{item.Article}, {item.Name}, {item.Color}, {item.Cost}");
//}