using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the day");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Its Monday");
                    break;

                case "Tuesday":
                    Console.WriteLine("Its Tuesday");
                    break;

                case "Wensday":
                    Console.WriteLine("Its Wensday");
                    break;

                case "Thusdya":
                    Console.WriteLine("Its Thusdya");
                    break;

                case "Freiday":
                    Console.WriteLine("Its Freiday");
                    break;

                case "Saturday":
                    Console.WriteLine("Its Saturday");
                    break;

                case "Sunday":
                    Console.WriteLine("Its Sunday");
                    break;
               default:
                    Console.WriteLine(day + " Not in the List");
                    break;
            }
            Console.Read();
        }
    }
}
