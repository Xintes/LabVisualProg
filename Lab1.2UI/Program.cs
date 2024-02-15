using Lab1VisualProg;
int n = 3;
int[,] Massiv = new int[n,n];
Console.WriteLine("Введите массив");

for(int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("[" + i + "] [" + j + "] = ");
        Massiv[i, j] = int.Parse(Console.ReadLine());
    
    }
}

Console.WriteLine("Массив\n");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(Massiv[i, j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("\nЧисло положительных элементов");
Console.WriteLine(Lab1Task2.Positive(Massiv));
Console.WriteLine("\nЧисло отрицательных элементов");
Console.WriteLine(Lab1Task2.Negative(Massiv));
Console.WriteLine("\nКоординаты нулевых элементов");
Console.WriteLine(Lab1Task2.Coordinate(Massiv));

////////////////////////////////////2

string str = Console.ReadLine();

if (Lab1Task1.IsPalyndrome(str) == true)
{
    Console.WriteLine("Слово является палиндромом");
}
else Console.WriteLine("Слово не является палиндромом");
