using System;
using System.IO;

namespace Text_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader tr = File.OpenText("Roshan.txt");
            StreamReader sr = new StreamReader("Roshan.txt");
            try
            {
                Console.WriteLine(tr.ReadToEnd());
                Console.WriteLine();
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine();
                Console.WriteLine(sr.Read());
                Console.WriteLine();
                char[] buf = new char[50];
                int n = sr.ReadBlock(buf, 0, buf.Length);
                Console.WriteLine($"{n} characters read");
                Console.WriteLine();
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine();
                Console.WriteLine(sr.Read());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            tr.Close();

        }
    }
}
