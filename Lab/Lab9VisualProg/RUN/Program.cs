using Lab9VisualProg;
using System;
//// ПSSример использования MyAll:
//var numbers = new List<int> {4, 5 };
//int value = 3;
//bool allArePositive = numbers.MyAll(x => x > value); // Вернет true
//if (allArePositive)
//{
//    Console.WriteLine($"В коллекции все числа > {value}");
//}
//else Console.WriteLine($"В коллекции не все числа > {value}");




//// Пример использования MyIntersect:
//var collection1 = new List<int> { 1, 2, 3, 4, 5 };
//var collection2 = new List<int> { 4, 5, 6, 7, 8 };
//var result = collection1.MyIntersect(collection2);

//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();


//// Пример использования MyDoThing:
//var words = new List<string> { "night", "day", "morning", "days" };
//var lengths = words.MyDoThing(word => word.Length); 
//Console.WriteLine($"Длинна: {string.Join(", ", lengths)}");


//// Пример использования MyDistinct:
//var duplicates = new List<string> { "Tomato", "Cucummber", "Cucummber", "Cucummber" };
//var unique = duplicates.MyDistinct(word => word); // Вернет список без дубликатов ["apple", "banana", "orange"]
//Console.WriteLine($"Уникальные слова: {string.Join(", ", unique)}");

// MyToDictionary:
List<string> words1 = new List<string> { "apple", "aplas", "banana", "cat", "dog", "elephant", "fish" };

Console.Write("Введите ключ: ");
string inputKey = Console.ReadLine() ?? string.Empty; // Используем пустую строку вместо null так как null не допускается в функции MyToDictionary 

int n = inputKey.Length;
var filteredDictionary = words1.MyToDictionary(word => word.Substring(0, n), n);

if (filteredDictionary.ContainsKey(inputKey))
{
    List<string> words = filteredDictionary[inputKey];
    Console.WriteLine($"Слова с ключом '{inputKey}': {string.Join(", ", words.Where(word => word.StartsWith(inputKey)))}");
}
else
{
    Console.WriteLine($"Нет слов с ключом '{inputKey}'.");
}