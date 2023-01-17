using System;
using System.Collections.Generic;

namespace SampleFrameworksApp
{
    class SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> phoneNos = new SortedDictionary<string, long>();

            phoneNos.Add("Pavan", 7760582791);
            phoneNos.Add("Priya", 7259305492);
            phoneNos.Add("Raju", 9538855597);
            phoneNos.Add("Sachin", 6562315524);
            phoneNos.Add("Vishwas", 7752154791);

            foreach (var nums in phoneNos)
            {
                Console.WriteLine(nums.Key+"-"+ nums.Value);
            }
        }
    }
}
