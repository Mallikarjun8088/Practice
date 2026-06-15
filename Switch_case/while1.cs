using System;

public class Class1
{
	public Class1()
    {
        Console.WriteLine("Enter the Name");
        string Name = Console.ReadLine(Console);

        while (Name == "")
        {
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine(Console);
        }
        Console.WriteLine("Hello " + Name );
	}
}
