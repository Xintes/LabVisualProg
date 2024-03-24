using Lab6VisualProg;
DynamicArray<int> myArray = new DynamicArray<int>();


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
Console.WriteLine("\nИсходная коллеция");
foreach (int element in myArray)
{
    Console.Write(element + " ");
}
Console.WriteLine("\nФильрация");
myArray.Filter(x => x == 30 );

foreach (int element in myArray)
{
    Console.Write(element + " ");
}



//---------------------------------------------------
//Console.WriteLine();
//Console.WriteLine("\nСортировка");
//myArray.Sort((a, b) => a.CompareTo(b));

//foreach (int element in myArray)
//{
//    Console.Write(element + " ");
//}
