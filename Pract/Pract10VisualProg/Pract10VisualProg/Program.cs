using System;
using System.IO;

class Program
{
    static void Main()
    {
        string tempFolderPath = @"C:\temp";
        string k1FolderPath = Path.Combine(tempFolderPath, "K1");
        string k2FolderPath = Path.Combine(tempFolderPath, "K2");
        string allFolderPath = Path.Combine(tempFolderPath, "All");

        // Создание папок K1 и K2
        Directory.CreateDirectory(k1FolderPath);
        Directory.CreateDirectory(k2FolderPath);

        // Создание файлов t1.txt и t2.txt в папке K1
        File.WriteAllText(Path.Combine(k1FolderPath, "t1.txt"), "Этот текст записан в файле t1.txt");
        File.WriteAllText(Path.Combine(k1FolderPath, "t2.txt"), "Этот текст записан в файле t2.txt");

        // Чтение содержимого файлов t1.txt и t2.txt
        string t1Text = File.ReadAllText(Path.Combine(k1FolderPath, "t1.txt"));
        string t2Text = File.ReadAllText(Path.Combine(k1FolderPath, "t2.txt"));

        // Запись содержимого файлов t1.txt и t2.txt в файл t3.txt в папке K2
        File.WriteAllText(Path.Combine(k2FolderPath, "t3.txt"), t1Text + Environment.NewLine + t2Text);

        // Перенос файла t2.txt в папку K2
        File.Move(Path.Combine(k1FolderPath, "t2.txt"), Path.Combine(k2FolderPath, "t2.txt"));

        // Копирование файла t1.txt в папку K2
        File.Copy(Path.Combine(k1FolderPath, "t1.txt"), Path.Combine(k2FolderPath, "t1.txt"));

        // Переименование папки K2 в All
        Directory.Move(k2FolderPath, allFolderPath);

        // Удаление содержимого папки K1
        string[] k1Files = Directory.GetFiles(k1FolderPath);
        foreach (string file in k1Files)
        {
            File.Delete(file);
        }

        string[] k1Directories = Directory.GetDirectories(k1FolderPath);
        foreach (string directory in k1Directories)
        {
            Directory.Delete(directory, true);
        }

        // Удаление папки K1
        Directory.Delete(k1FolderPath);


        // Вывод информации о файлах в папке All
        string[] allFiles = Directory.GetFiles(allFolderPath);
        foreach (string file in allFiles)
        {
            Console.WriteLine($"Имя файла: {Path.GetFileName(file)}");
            Console.WriteLine($"Полный путь: {file}");
            Console.WriteLine($"Размер файла: {new FileInfo(file).Length} байт");
            Console.WriteLine();
        }
    }
}
