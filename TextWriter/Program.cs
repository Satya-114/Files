using System;
using System.IO;

namespace Text_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter writer = File.CreateText("roshan.txt");
            try
            {
                writer.Write("hi");
                writer.Write("Good evening \n how is your day");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Data written sucessfully...");
            writer.Flush();
            writer.Close();
        }
    }
}
