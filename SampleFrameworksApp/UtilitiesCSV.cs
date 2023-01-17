using System;
using System.Diagnostics;
using System.Reflection;
namespace SampleConApp
{
    class UtilitiesCSV
    {
        internal static string Prompt(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int GetNumber(string question)
        {
            bool processing = false;
            int result;
            do
            {
                Console.WriteLine(question);
                processing = int.TryParse(Console.ReadLine(), out result);
            } while (!processing);
            return result;
        }

    }
}
