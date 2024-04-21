using System;
using Lab10VisualProg;
using System.IO;




//ЗАДАНИЕ 

string directory = Environment.GetEnvironmentVariable("Temp"); // Получить значение переменной окружения
if (directory != null)
{
    string filePath = Path.Combine(directory, ".Acha.txt"); // Объединить путь к каталогу и имени файла
    FileClass file = FileClass.Open(filePath);
    string R01 = file.ReadLine();
    Console.WriteLine(R01);
}
else
{
    Console.WriteLine("Переменная окружения не задана.");
}





/////////////////////////////////////////////////////////////






//FileClass reopenedFile = FileClass.Create(@"C:\temp\test.txt");

//reopenedFile.WriteLine("Привет, Мир.");

//string R1 = reopenedFile.ReadLine();
//Console.WriteLine(R1);

//string W1 = "Ещё Мир";
//reopenedFile.Write(W1, 3);

//string R2 = reopenedFile.Read(15);
//Console.WriteLine(R2);

//reopenedFile.Close();



