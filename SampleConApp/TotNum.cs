using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class TotNum
    {
        public static void CharCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            CharCount("Gandhiji");
        }
    }
}
