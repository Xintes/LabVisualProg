using Lab5VisualProg;
DynamicArray<int> myArray = new DynamicArray<int>();
Console.WriteLine($"Количество элементов: {myArray.Count}, Вместимость: {myArray.Capacity}");

myArray.Add(10);
myArray.Add(20);
myArray.Add(30);
myArray.Add(77);


Console.WriteLine($"Количество элементов: {myArray.Count}, Вместимость: {myArray.Capacity}");
foreach (int element in myArray)
{
    Console.WriteLine(element);
}

myArray.RemoveAt(3);

Console.WriteLine($"\n\nКоличество элементов: {myArray.Count}, Вместимость: {myArray.Capacity}");
foreach (int element in myArray)
{
    Console.WriteLine(element);
}

myArray.Insert(15, 1);

Console.WriteLine($"\n\nКоличество элементов: {myArray.Count}, Вместимость: {myArray.Capacity}");
foreach (int element in myArray)
{
    Console.WriteLine(element);
}

myArray.Add(10);
myArray.Add(20);
myArray.Add(30);
myArray.Add(77);
myArray.Add(10);
myArray.Add(20);
myArray.Add(30);
myArray.Add(77);
myArray.Add(10);
myArray.Add(20);
myArray.Add(30);
myArray.Add(77);
myArray.Add(10);
myArray.Add(20);
myArray.Add(30);
myArray.Add(77);
myArray.Add(30);
myArray.Add(77);

Console.WriteLine($"\n\nКоличество элементов: {myArray.Count}, Вместимость: {myArray.Capacity}");
foreach (int element in myArray)
{
    Console.WriteLine(element);
}