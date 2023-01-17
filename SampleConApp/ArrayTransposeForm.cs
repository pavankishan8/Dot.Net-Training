using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class ArrayTransposeForm
    {
        public static void ReturnArray(int[,] array)
        {
            int rank = array.Rank;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.WriteLine(array[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

        }

    }
}
