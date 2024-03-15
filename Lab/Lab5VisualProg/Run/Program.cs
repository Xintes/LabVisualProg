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


///////////////////////////////////////
DynamicArray<int> mySort = new DynamicArray<int>();

mySort.Add(1);
mySort.Add(2);
mySort.Add(3);
mySort.Add(35);
mySort.Add(12);
mySort.Add(51);
mySort.Add(30);
mySort.Add(21);
mySort.Add(30);
mySort.Add(97);
mySort.Add(34);
Console.WriteLine($"\n\nМассив до сортировки");
foreach (int element in mySort)
{
    Console.Write(element + " ");
}

mySort.Sort();

Console.WriteLine($"\n\nМассив после сортировки");
foreach (int element in mySort)
{
    Console.Write(element + " ");
}


// Добавление элементов в dynamicArray

List<int> indexes = mySort.BinarySearch(30);
if (indexes.Count > 0)
{
    Console.WriteLine("Найдены элементы в позициях: " + string.Join(", ", indexes));
}
else
{
    Console.WriteLine("Элемент не найден");
}