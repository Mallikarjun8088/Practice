using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 3;
            //double y = 44;

            // double y = Math.Pow(x, 2);
            // double a = Math.Sqrt(x);
            //double b = Math.Abs(x); 
            //double m = Math.Max(x, y);
            //double min = Math.Min(x, y);

            //Console.WriteLine(min);
            //Console.WriteLine(m);
            //Console.WriteLine(b);
            //Console.WriteLine(a);
            //Console.WriteLine(y);

            ///////////////////////////////////////////////////////////////
            //#region Random_num

            //Random num = new Random();

            //int i = num.Next(1, 7);
            //Console.WriteLine(i);

            //#endregion

            Console.WriteLine("Enter you Name");
            string Name = Console.ReadLine();

            if (Name == "")
            {
                Console.WriteLine("You have not enterd youre name");

            }

            else if (Name != "")
            {
                Console.WriteLine("Hello " + Name);
                Console.WriteLine("Enter you age");
                int age = Convert.ToInt32(Console.ReadLine());
                {

                    if (age >= 18)
                    {
                        Console.WriteLine("Your now singed up!!");
                    }
                    else if (age <= 0)
                    {
                        Console.WriteLine("You havent yet born");
                    }
                    else
                    {
                        Console.WriteLine("your not eligeble");
                    }
                }
            }
            Console.Read();
        }

    }
}
