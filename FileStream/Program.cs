using System;
using System.IO;
using System.Text;

namespace File_Stream_4
{
    class Program
    {
        static void WriteFile(string Filename)
        {
            FileStream fs = new FileStream(Filename, FileMode.Create, FileAccess.Write, FileShare.None);
            if(fs.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes("Hello World");
                fs.Write(buffer, 0, buffer.Length);
            }
            fs.Flush();
            fs.Close();
        }
        static void ReadFile(string Filename)
        {
            FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            if (fs.CanRead)
            {
                byte[] buffer = new byte[fs.Length];
                int byteread = fs.Read(buffer, 0, buffer.Length);
                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0 ,byteread));
            }
            fs.Close();

        }
        static void Main(string[] args)
        {
            string fileName = @"MyDirectory\text.txt";
            WriteFile(fileName);
            ReadFile(fileName);
        }
    }
}
