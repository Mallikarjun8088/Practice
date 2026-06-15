using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Classes
{
    class Object_argument
    {
        static void Main3(string[] args)
        {
            Cars car1 = new Cars("POLO", "Red");
            Console.WriteLine(car1.Name +" " + car1.colour);
            changecolour(car1, "White");
            Console.WriteLine(car1.Name +  " " + car1.colour);
            Console.Read();
        }

        public static void changecolour(Cars car, string colour)
        {
            car.colour = colour;
        }
    }

    public class Cars
    {
        public string Name;
        public string colour;

        public Cars(string Name, string colour)
        {
            this.Name = Name;
            this.colour = colour;
        }
    }
}
