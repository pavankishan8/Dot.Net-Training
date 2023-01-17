using System;


namespace SampleConApp
{
    class Ex02_DataTypes
    {
        static void Main()
        {
            Console.WriteLine($"The range of byte is {byte.MinValue} and" +
                $"{byte.MaxValue}");
            Console.WriteLine($"The range of int is {int.MinValue} and" +
                $"{int.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} and" +
                $"{long.MaxValue}");

            int iValue = 123;
            long lValue = long.MaxValue;

            checked
            {
                //iValue = (int)(lValue);
            }
            iValue = (int)(lValue);
            Console.WriteLine("The Int value now has: " + iValue);
        }
    }
}
