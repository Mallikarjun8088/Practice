using System;

namespace Switch_case.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Employes employe = new Employes();

            employe.Name = "Mahi";
            employe.Id = "404";
            employe.Salary = "20000";

            Console.WriteLine(employe.Name);
            Console.WriteLine(employe.Id);
            Console.WriteLine(employe.Salary);

            Console.ReadKey();
        }
    }
}
