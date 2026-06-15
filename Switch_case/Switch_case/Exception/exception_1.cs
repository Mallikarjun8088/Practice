using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Exception_1
{
    class exception_1
    {
        static void Main1(string[] args)
        {
            double x;
            double y;
            double result;

            try
            {
                Console.WriteLine("Enter the value of x");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the value of y");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;
                Console.WriteLine(result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("NOT A NUMBER");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Went Wrong");
            }
            finally
            {
                x = 0;
                y = 0;
                Console.WriteLine("Thank you");
            }
            Console.Read();
        }
        
    }
}
