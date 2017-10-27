using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOddSums
{

    class Program
    {


        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            int IntNum = Convert.ToInt16(sr.ReadLine());
            
            sw.WriteLine("INTEGER       EVEN SUM        ODD SUM           PROCESSING TIME");
            sw.WriteLine("---------------------------------------------------------------");
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                int Line = Convert.ToInt16():


                for (x = 1; x <= line; x++)
                {
                    if (line % x == 0)
                    {
                      Console.WriteLine(line);
                    }
                }
               
                sr.Close();
                sw.Close();
            }
                                                                                                   

        }
    }
}
