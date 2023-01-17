using System;

namespace SampleConApp
{
    class Mathcalc
    {
        static void Main(string[] args)
        {
            int x, y;
            char ope;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            ope = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (ope == '+') 
                Console.WriteLine(x + y);
            else if (ope == '-')
                Console.WriteLine(x - y);
            else if (ope == '*')
                Console.WriteLine(x * y);
            else if (ope == '/')
                Console.WriteLine(x / y);
            else
            Console.WriteLine("Wrong Character");
        }
    }
}
