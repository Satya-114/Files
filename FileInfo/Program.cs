using System;
using System.IO;


namespace file_info

{
    class Program
    {
        static void Main(string[] args)
        {
            string loc = @"C:\Users\Satya Maddila\source\repos\FileInfo\bin\Debug\netcoreapp3.1\my folder\avinash.txt";
            FileInfo file = new FileInfo (loc);
            StreamWriter sw = file.CreateText();
            sw.WriteLine("this text is written to the file by using StreamWriter class.");
            sw.Close();
            string path = @"C:\Users\Satya Maddila\source\repos\FileInfo\bin\Debug\netcoreapp3.1\my folder";
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
                Console.WriteLine(file.FullName);
                Console.WriteLine(file.DirectoryName);
                Console.WriteLine(file.Extension);
                Console.WriteLine(file.IsReadOnly);
                Console.WriteLine(file.LastWriteTime);
                Console.WriteLine(file.Name);
        }
    }
}
