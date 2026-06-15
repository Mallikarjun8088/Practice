using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_valu_tringle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter A Side Value");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c Side Value");
            double B = Convert.ToDouble(Console.ReadLine());

           double C = Math.Sqrt((A * A) + (B * B));

            Console.WriteLine("The thired Value : " + C);
            Console.Read();
        }
    }
}
