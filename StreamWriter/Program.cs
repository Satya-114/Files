using System;
using System.IO;
using System.Text;


namespace Stream_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("demo.txt");
            string temp = string.Empty;
            do
            {
                Console.WriteLine("Enter your text [-1 to exit];");
                temp = Console.ReadLine();
                if (temp != "-1")
                {
                    sw.WriteLine(temp);
                }

            }while(temp != "-1") ;
            sw.Close();
                string line;
                using (StreamReader sr = new StreamReader("demo.txt"))

                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            }
    }
            
            
              
            
    

