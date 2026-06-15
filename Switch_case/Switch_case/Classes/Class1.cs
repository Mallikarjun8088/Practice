using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Classes
{
    class Class1
    {
        static void Main1(string[] args)
        {
            Employe employe = new Employe();
            employe.Name = "Mahi";
            employe.ID = 404;
            employe.Salary = 20000;
            //Employe employe1 = new Employe("Mahi", 404, 20000);
            //Employe employe2 = new Employe("Mallikarjun M", 404, 20000);
            //Employe employe3 = new Employe("Mahi", 404, 20000);
            //Temp temp = new Temp("Hari", 22, 8);

            Temp temp = new Temp();
            temp.Name = "Mallikarjun";
            temp.ID = 222;
            temp.hr = 8;

            temp.d1();

          //  employe.d1();

            //employe.d2();
            //employe.d3();
            Console.Read();
        }

    }
    public class Employe
    {
        public string Name;
        public int ID;
        public int Salary;

        //public Employe(string Name, int ID, int Salary)
        //{
        //    this.Name = Name;
        //    this.Salary = Salary;
        //    this.ID = ID;
        //}

        public void d1()
        {
            Console.WriteLine("Employe Name is : " + Name  /*"Employe ID is : " + ID, "Employe Salary is : " + Salary*/ );
            Console.WriteLine("Employe ID is : " + ID);
            Console.WriteLine("Employe Salary is : " + Salary);
        }

    }

       class Temp : Employe
    {
        public int hr;
        int salary = 30;
        

          public void d2()
        {
            salary = hr * 30;
            Console.WriteLine("Employe Name is : " + Name );
            Console.WriteLine("Employe ID is : " + ID);
            Console.WriteLine("The salary is " + salary );
          }
    }
}
