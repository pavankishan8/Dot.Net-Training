using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{

    class Dog
    {
        public void DogFunc() => Console.WriteLine("Dog barks");
    }

    class Animal : Dog
    {
        public void AnimalFunc() => Console.WriteLine("Barks");
        public void DogFunc() => Console.WriteLine("Boww Boww");
    }
    class MethodHiding
    {
        static void Main(string[] args)
        {
            Dog instance = new Animal();
            instance.DogFunc();

            if (instance is Animal)
            {
                Animal copy = instance as Animal;
                copy.DogFunc();
            }

        }
    }
}
