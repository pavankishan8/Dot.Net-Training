using System;

namespace SampleConApp
{
    class Range
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Float Values:");
            Console.WriteLine($"The range of float is {float.MinValue} and" +
                $"{float.MaxValue}");
            Console.WriteLine($"The range of double is {double.MinValue} and" +
                $"{double.MaxValue}");
            Console.WriteLine($"The range of decimal is {decimal.MinValue} and" +
                $"{decimal.MaxValue}");

            Console.WriteLine("Integral Values:");
            Console.WriteLine($"The range of byte is {byte.MinValue} and" +
                $"{byte.MaxValue}");
            Console.WriteLine($"The range of short is {short.MinValue} and" +
                $"{short.MaxValue}");
            Console.WriteLine($"The range of int is {int.MinValue} and" +
                $"{int.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} and" +
                $"{long.MaxValue}");


        }
    }
}
