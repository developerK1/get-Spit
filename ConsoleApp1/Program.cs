using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArr= new String[4];
            int counter = 0;
            Console.WriteLine("Add a List...");

            while(counter < 4)
            {
                myArr[counter] = Console.ReadLine();
                

                if (counter < 3)
                {
                    Console.WriteLine("Add the Last one");
                }
                else
                {
                    Console.WriteLine("Add another one");
                }

                counter++;
            }

            Console.WriteLine("Here is your list...");

 
            for(int idx = 0; idx < 4; idx++)
            {
                Console.WriteLine(myArr[idx]);
            }

            Console.ReadKey();
;        }
    }
}
