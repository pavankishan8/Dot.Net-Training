using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Example
    {
        internal static int value;
        public Example() => Console.WriteLine("Instance Creator");
        static Example()
        {
            value = 100;
            Console.WriteLine("Static Creator");
        }
    }

    static class SingletonClass
    {
        public static void StaticMethod() => Console.WriteLine("Static Method called");
    }
    class StaticConstructor
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex = new Example();
            ex = new Example();
            ex = new Example();
            ex = new Example();
            Example.value = 123;
        }
    }
}
