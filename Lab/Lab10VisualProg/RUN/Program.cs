using System;
using Lab10VisualProg;
using System.IO;

FileClass reopenedFile = FileClass.Open(@"C:\temp\Gicha.txt");

string line1 = reopenedFile.ReadLine();
Console.WriteLine(line1);
string line2 = reopenedFile.Read(3);
Console.WriteLine(line2);

reopenedFile.Close();