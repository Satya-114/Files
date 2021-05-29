using System;
using System.IO;

namespace Binary_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            int i = 25;
            Double d = 3.14517;
            bool b = true;
            string s = "satya";
            try
            {
                bw = new BinaryWriter(new FileStream("mytext.txt", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot create file.");
                return;
            }
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }

            catch (IOException e)
        {
            Console.WriteLine(e.Message + "\n cannot write to file.");
            return;
        }
        bw.Close();
            }

    }
}
