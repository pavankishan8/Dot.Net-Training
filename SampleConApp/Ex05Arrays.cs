using System;

namespace SampleConApp
{
    class Ex05Arrays
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the size of the Array");
            //int k = Convert.ToInt32(Console.ReadLine());
            //string[] names = new string[k];
            ////names = new string[] { "Pavan R","Priya B","Sachin","Vishwas","Raj"};

            //for(int i=0; i<k; i++)
            //{
            //    Console.WriteLine($"Enter the name for the position{i}");
            //    names[i] = Console.ReadLine();
            //}
            //Console.WriteLine("All the values are set, now reading the values");

            //Console.WriteLine("The size:" +names.Length);
            //Console.WriteLine("The Dimensions of the Array:" + names.Rank);
            //Console.WriteLine("The length of the 1st dimension" + names.GetLength(0));

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            /////////////////////////////////////////////////Multi Dimensional Array\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            int[,] data = new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string row = " ";
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row += data[i, j] + " ";
                }
                Console.Write(row.TrimEnd());
                Console.WriteLine();
            }

        }
    }
}
