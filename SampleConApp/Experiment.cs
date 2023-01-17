using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{

    public class Experiment
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            int i, j, k, m;

            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= 1; j++)
                    Console.WriteLine(" ");

                for (k = 1; k <= i; k++)
                    Console.WriteLine(ch++);
                    ch--;

                for (m = 1; m < i; m++)
                    Console.WriteLine(--ch);
                    Console.WriteLine("\n");
                    ch = 'A';
            }
        }
    }

}
