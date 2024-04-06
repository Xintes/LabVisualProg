using Lab9VisualProg;

var numbers = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("Коллеция:");
foreach (var group in numbers)
{
    Console.Write($"{group} ");
}

var filteredNumbers = numbers.Filter(x => x % 2 == 0);
Console.WriteLine("\n\nОтфильтрованные числа: " + string.Join(", ", filteredNumbers));

var doubledNumbers = numbers.Map(x => x * 2);
Console.WriteLine("\nИзменённые числа: " + string.Join(", ", doubledNumbers));

var sum = numbers.Reduce((x, y) => x + y);
Console.WriteLine("\nСумма: " + sum);

var fruits = new List<string> { "Автобус", "Вино", "Вино", "ВоксельныйИзмельчитеИнатор" };

var sortedFruits = fruits.SortBy(x => x.Length);
Console.WriteLine("\nСортировка по длинне: " + string.Join(", ", sortedFruits));

var groupedFruits = fruits.GroupByCount(fruit => fruit.Length);
Console.WriteLine("\nГрупировка по числу символов: ");
foreach (var group in groupedFruits)
{
    Console.WriteLine($"{group.Key}: {string.Join(", ", group.Value)}");
}