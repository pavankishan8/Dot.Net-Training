using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Helper
    {
        public static int GetNumber(string num)
        {
            Console.WriteLine(num);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public static string GetValue(string str)
        {
            Console.WriteLine(str);
            string sentence = Console.ReadLine();
            return sentence;
        }
    }
}
