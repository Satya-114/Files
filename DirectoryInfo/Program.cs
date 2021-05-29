using System;
using System.IO;

namespace DirertoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string loc = @"C:\Users\Satya Maddila\source\repos\DirertoryInfo\bin\Debug\netcoreapp3.1\DirectoryInfo";
            string path = @"C:\Users\Satya Maddila\source\repos\DirertoryInfo\bin\Debug\netcoreapp3.1";
            Directory.CreateDirectory("NewDirectory");
            Directory.Delete("NewDirectory");
            String[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            DirectoryInfo info = new DirectoryInfo(loc);
            Console.WriteLine(info.FullName);
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Parent);
            Console.WriteLine(info.Exists);
            Console.WriteLine(info.LastWriteTime);
        }
    }


    
}
