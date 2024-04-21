using System;
using System.IO;
namespace Lab10VisualProg
{
    public class FileClass
    {
        private StreamReader reader;
        private StreamWriter writer;
        public Stream stream;

        private FileClass(Stream stream)
        {
            this.stream = stream;
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            
        }

        private static Stream CreateStream(string path)
        {
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            stream.Position = 0; // Установить указатель позиции чтения в начало файла
            return stream;

        }

        private static Stream OpenStream(string path)
        {
            return new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
        }

        public static FileClass Create(string path)
        {
            Stream stream = CreateStream(path);
            return new FileClass(stream);
        }

        public static FileClass Open(string path)
        {
            Stream stream = OpenStream(path);
            return new FileClass(stream);
        }

        public string ReadLine()
        {
            stream.Seek(0, SeekOrigin.Begin); // Сбросить позицию чтения в начало файла
            return reader.ReadLine();
        }

        public string Read(int count)
        {
            stream.Seek(0, SeekOrigin.Begin); // Сбросить позицию чтения в начало файла
            long length = reader.BaseStream.Length; // Получение длины потока в байтах

            if (length == 0) // Если длина потока равна нулю, вернуть пустую строку
                return "";

            int charsToRead = Math.Min(count, (int)length); // Определение количества символов для чтения (не больше длины потока)

            char[] buffer = new char[charsToRead];
            int bytesRead = reader.Read(buffer, 0, charsToRead);
            if (bytesRead == 0) // Если ничего не прочитано, вернуть пустую строку
                return "";

            return new string(buffer, 0, bytesRead); // Вернуть только прочитанные символы
        }


        public void WriteLine(string line)
        {
            writer.WriteLine(line);
            writer.Flush(); // вызов Flush для записи данных на диск
            reader.DiscardBufferedData();
        }

        public void Write(string text, int count)
        {
            writer.Write(text.Substring(0, count));
            writer.Flush(); //  вызов Flush для записи данных на диск
            reader.DiscardBufferedData();
        }

        public void Close()
        {
            writer.Dispose();
            reader.Dispose();
            stream.Dispose();
        }
    }

}


// Переменные окружения: что такое, для чего используются.
//Задать каталог для работы с файлами в виде переменной окружения.
// Брать путь для работы с файлами из переменой окружения

//На доработку: создать файл, записать в него что-то, считать это в консоль, 
// дописать что-то в файл, ещё раз считать всё в консоль, а потом закрыть  DONE