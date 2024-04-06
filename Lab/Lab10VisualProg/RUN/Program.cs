using System;
using Lab10VisualProg;
using System.IO;
// Создание нового файла (путь задается по умолчанию)
TextFileHandler fileHandler1 = new TextFileHandler();
fileHandler1.Write("Hello, world!");
fileHandler1.Close();

// Создание нового файла по заданному пути
TextFileHandler fileHandler2 = new TextFileHandler("C:\\files\\example.txt");
fileHandler2.Write("This is a custom file path.");
fileHandler2.Close();

// Открытие существующего файла
TextFileHandler fileHandler3 = new TextFileHandler();
fileHandler3.OpenExistingFile("C:\\files\\existing.txt");
string line = fileHandler3.ReadLine();
Console.WriteLine("Read line: " + line);
fileHandler3.Close();

// Чтение строки из файла
TextFileHandler fileHandler4 = new TextFileHandler();
fileHandler4.OpenExistingFile("C:\\files\\existing.txt");
string line2 = fileHandler4.ReadLine();
Console.WriteLine("Read line: " + line2);
fileHandler4.Close();

// Чтение count символов из файла
TextFileHandler fileHandler5 = new TextFileHandler();
fileHandler5.OpenExistingFile("C:\\files\\existing.txt");
string text = fileHandler5.Read(10);
Console.WriteLine("Read characters: " + text);
fileHandler5.Close();

// Запись строки в файл
TextFileHandler fileHandler6 = new TextFileHandler();
fileHandler6.Write("This is a new line.");
fileHandler6.Close();

// Запись count символов в файл
TextFileHandler fileHandler7 = new TextFileHandler();
fileHandler7.Write("This is a new line.", 10);
fileHandler7.Close();