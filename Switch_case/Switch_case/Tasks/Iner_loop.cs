using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Tasks
{
    class Iner_loop
    {
        static void Main3(string[] args)
        {
            Console.Write("Enter the number of rows");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of Coloums");
            int coloums = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of symbol");
            string symbol = Console.ReadLine();

            for (int i = 0; i<row ; i++)
            {
                for (int j = 0; j< coloums; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.Read();

        }

    }
}


