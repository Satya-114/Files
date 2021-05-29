using System;
using System.IO;

namespace Stream_Reader
{
    class Program
    {
        public static void ReadfromFile(string filepath)
        {
            StreamReader r = new StreamReader("text.txt");
            while (!r.EndOfStream)
            {
                Console.WriteLine(r.ReadLine());
            }
            r.Close();
        }
         public static void WriteToFile(string filePath)
        {
            string[] names = new string[] { "satya", "messi", "curry" };
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
        }
        static void Main(string[] args)
        {
            String filePath = "text.txt";
            WriteToFile(filePath);
            ReadfromFile(filePath);
        }

        }
    }

