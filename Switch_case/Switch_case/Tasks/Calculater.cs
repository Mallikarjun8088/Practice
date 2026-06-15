using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Tasks
{
    class Calculater
    {
        static void Main6(string[] args)
        {
            double num1;
            double num2;
            double result;
            

            Console.WriteLine("-------------------");
            Console.WriteLine("CALCULATER PROGRAM");
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter Num 1 : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Num 2:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select the Operation : ");
            Console.WriteLine("\t + : ADD");
            Console.WriteLine("\t - :  SUBSTRACT");
            Console.WriteLine("\t * : MULTIPLY");
            Console.WriteLine("\t / : DIVIDE");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = " +result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = " + result);
                    break;

            }

            Console.Read();
        }
        
    }
}
