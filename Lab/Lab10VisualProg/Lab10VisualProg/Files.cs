using System;
using System.IO;
namespace Lab10VisualProg
{
    using System;
    using System.IO;

    public class FileClass
    {
        private StreamReader reader;
        private StreamWriter writer;
        private Stream stream;

        private FileClass(Stream stream)
        {
            this.stream = stream;
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
        }

        private static Stream CreateStream(string path)
        {
            return new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
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
            return reader.ReadLine();
        }

        public string Read(int count)
        {
            char[] buffer = new char[count];
            int bytesRead = reader.Read(buffer, 0, count);
            if (bytesRead == 0) // Если ничего не прочитано, вернуть пустую строку
                return "";

            return new string(buffer, 0, bytesRead); // Вернуть только прочитанные символы
        }


        public void WriteLine(string line)
        {
            writer.WriteLine(line);
        }

        public void Write(string text)
        {
            writer.Write(text);
        }

        public void Close()
        {
            writer.Dispose();
            reader.Dispose();
            stream.Dispose();
        }
    }

}
