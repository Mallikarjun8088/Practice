using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //int c = 123;
            //double d = Convert.ToDouble(c)+0.2;

            //int e = 222;
            //string f = Convert.ToString(e);

            //string g = "$";
            //char h = Convert.ToChar(g);

            //string i = "true";
            //bool j = Convert.ToBoolean(i);

            ////Console.WriteLine(g);
            ////Console.WriteLine(f);
            ////Console.WriteLine(b);
            ////Console.WriteLine(d);
            ////Console.WriteLine(j);

            //Console.WriteLine(j.GetType());

            ////Console.WriteLine(h.GetType());
            ////Console.WriteLine(d.GetType());
            ////Console.WriteLine(f.GetType());


            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region User_input

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine(); 
            


            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello" + name);
            Console.WriteLine("Your "+ age + "Years old."); 




            #endregion



            Console.Read();

        }
    }
}
