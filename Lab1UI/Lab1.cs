using Lab1VisualProg;

Console.Write("Введите слово: ");
string str = Console.ReadLine();

if (Lab1Task1.IsPalyndrome(str) == true)
{
    Console.WriteLine("Слово является палиндромом");
}
else Console.WriteLine("Слово не является палиндромом");