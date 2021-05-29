using System;
using System.IO;

namespace Binary_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryReader br;
            int i;
            double d;
            bool b;
            string s;
            try
            {
                br = new BinaryReader(new FileStream("mytext.txt", FileMode.Open));
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            try
            {
                i = br.ReadInt32();
                d = br.ReadDouble();
                b = br.ReadBoolean();
                s = br.ReadString();
                Console.WriteLine("Integer data: {0}", i);
                Console.WriteLine("Double data: {0}", d);
                Console.WriteLine("Boolean data: {0}", b);
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.ReadKey();
        }
    }
}
