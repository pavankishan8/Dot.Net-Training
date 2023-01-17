using System;

namespace SampleConApp
{
    class Test
    {
        public string Content { get; set; }
    }
    class Objects
    {
        static void Main(string[] args)
        {
            object data = 123;
            Console.WriteLine(data.GetHashCode());
            long copy = (int)data;
            data = ++copy;
            Console.WriteLine(data.GetType().Name);
            data = "Pavan R";
            Console.WriteLine(data.GetType().Name);
            Console.WriteLine(data.GetHashCode());
            data = true;
            Console.WriteLine(data.GetType().Name);

            data = new string[] { "Data1", "Data2", "Data3" };
            Console.WriteLine(data.GetType().Name);


            
            string[] contents = (string[])data;
            foreach (string content in contents) Console.WriteLine(content);
            Console.WriteLine("The data type: " + contents);

            Console.WriteLine("The string of the Test is " + new Test());

            Test t1 = new Test();
            Test t2 = t1;
            Console.WriteLine(t1.Equals(t2));

            object test = new Test();
            if (test is Test)
            {
                Test ex = test as Test;
                ex.Content = "Testing";
            }
        }
    }
}
