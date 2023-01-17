using System;
using System.Collections.Generic;

namespace SampleFrameworksApp
{
    class Ex_02_GenericCollections
    {
        static void Main(string[] args)
        {
            hashSetExample();
            listExample();
        }

        private static void hashSetExample()
        {
            HashSet<string> basket = new HashSet<string>();
            basket.Add("Mangoes");

            if (!basket.Add("Mangoes"))
            {
                Console.WriteLine("This already exists");
            }
            basket.Add("Alphanso Mangoes");
            basket.Add("Ratnagiri Mangoes");
            Console.WriteLine("The count of the basket is " + basket.Count);

            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }
        }
        private static void listExample()
        {
            string[] oldValues = { "Kiwi Fruit", "Pine Apples", "Oranges", "Bananas" };
            List<string> fruits = new List<string>(oldValues);
            fruits.Add("Apples");
            fruits.Add("Big Apples");
            fruits.Add("Custard Apples");
            fruits.Add("Ooty Apples");
            fruits.Add("Green Apples");
            fruits.Insert(3, "Mangoes");
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
