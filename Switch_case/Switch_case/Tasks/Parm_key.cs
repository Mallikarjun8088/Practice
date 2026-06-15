using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Tasks
{
    class Parm_key
    {
        static void Main7(string[] args)
        {
            double total = checkout(23, 23,66,77,88,99,33,9);
            Console.WriteLine(total);
            Console.Read();
        }

        static double checkout(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}
