using System;
using System.Collections;

namespace SampleFrameworksApp
{
    class Ex01Collections
    {
        static void Main(string[] args)
        {
            //arrayListExample();
            hashTableExample();
        }

        private static void hashTableExample()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("SampleName", "Example123");//Adds the new key-value pair to the Collection
            hashtable["TestName"] = "Test123";//It the key already exists, it modifies the value, else adds a new key-value pair. 
            foreach (DictionaryEntry pair in hashtable)
            {
                Console.WriteLine("{0}-{1}", pair.Key, pair.Value);
            }
            //Iterating thru keys.........
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(hashtable[key]);//Display the values
            }

        }

        private static void arrayListExample()
        {
            ArrayList list = new ArrayList();//blank list of items. 
            list.Add("Apples");
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Add("Bananas");
            list.Remove("Bananas");
            list.Insert(2, "Kiwi Fruit");
            list.RemoveAt(1);
            Console.WriteLine("No of elements: " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
