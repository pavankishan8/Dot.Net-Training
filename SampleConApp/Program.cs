using System;

namespace SampleConApp
{
    class Ex01FirstProgram
    {
        static void Main()
        {
            Console.WriteLine("Testing My Code");
            //Console.ReadKey();

            Console.WriteLine("Enter the Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the Salary:");
            string salary = Console.ReadLine();

            Console.WriteLine("The Input Results: \nName: " + name + "\nAddress: " + address + "\nSalary: " + salary);
            Console.WriteLine($"{name} from {address} is earning a Salary of Rs.{salary}");
        }
    }
}
