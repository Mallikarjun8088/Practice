using System;

public class Class
{
    static void Main2(string[] args)
    {
        {
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();

            while (Name == "")
            {
                Console.WriteLine("Enter the Name");
                Name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + Name);
        }
    }
}
