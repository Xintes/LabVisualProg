using System;
using System.IO;
namespace Lab10VisualProg
{
    using System;
    using System.IO;

    public class TextFileHandler
    {
        private FileStream fileStream;
        private StreamReader reader;
        private StreamWriter writer;

        public TextFileHandler()
        {
            string defaultFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "example.txt");
            CreateNewFile(defaultFilePath);
        }

        public TextFileHandler(string filePath)
        {
            CreateNewFile(filePath);
        }

        public void CreateNewFile(string filePath)
        {
            Close();
            fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            reader = new StreamReader(fileStream);
            writer = new StreamWriter(fileStream);
        }

        public void OpenExistingFile(string filePath)
        {
            Close();
            fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            reader = new StreamReader(fileStream);
            writer = new StreamWriter(fileStream);
        }

        public string ReadLine()
        {
            return reader.ReadLine();
        }

        public string Read(int count)
        {
            char[] buffer = new char[count];
            reader.Read(buffer, 0, count);
            return new string(buffer);
        }

        public void Write(string text)
        {
            writer.WriteLine(text);
            writer.Flush();
        }

        public void Write(string text, int count)
        {
            char[] buffer = text.ToCharArray();
            writer.Write(buffer, 0, count);
            writer.Flush();
        }

        public void Close()
        {
            writer?.Flush();
            writer?.Close();
            reader?.Close();
            fileStream?.Close();
        }
    }

}
