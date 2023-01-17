using System;


namespace SampleConApp
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int i, j, even = 0, odd = 0;

            Console.WriteLine("Enter the number of elements to be inserted: ");
            j = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[j];
            Console.WriteLine("Enter the array elements:");

            for (i = 0; i < j; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < j; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even = even;
                    even++;
                }
                else
                {
                    odd = odd;
                    odd++;
                }
            }
            Console.WriteLine("Number of even terms are: " + even);
            Console.WriteLine("Number of odd terms are: " + odd);
            Console.ReadLine();
        }

    }
}

