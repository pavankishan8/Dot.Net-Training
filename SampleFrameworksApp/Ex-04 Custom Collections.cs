using System;
using System.Collections;
using System.Collections.Generic;

namespace SampleFrameworksApp
{
    class CustomerArray : IEnumerable
    {
        List<string> names = new List<string>();

        public void AddName(string name) => names.Add(name);

        public void DeleteName(int index)
        {
            if (index < names.Count)
                names.RemoveAt(index);
            else
                throw new Exception("Id is not there to delete");
        }
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                if (index < names.Count)
                    names[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in names)
                yield return item;
        }

        public int NamesCount => names.Count;
    }
    class Ex_05_CustomCollections
    {
        static void Main(string[] args)
        {
            CustomerArray array = new CustomerArray();
            array.AddName("Pavan");
            array.AddName("Raju");
            array.AddName("Uma");
            array.AddName("Priya");

            for (int i = 0; i < array.NamesCount; i++)
            {
                string old = array[i];
                array[i] = "Welcome to " + old;
                Console.WriteLine(array[i]);
            }

            //foreach (string name in array)
                //Console.WriteLine(name);

        }
    }
}

