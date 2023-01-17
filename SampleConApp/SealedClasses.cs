using System;


namespace SampleConApp
{
        class SuperBase
        {
            public virtual void SimpleMethod() => Console.WriteLine("Base version");
        }
        class Concrete : SuperBase
        {
            public sealed override void SimpleMethod() => Console.WriteLine("Simple method from the sealed class");
        }

        class SubConcrete : Concrete
        {
            public new void SimpleMethod() => Console.WriteLine("Simple method's new implemention from the Derived class");
        }

    class SealedClasses
    { 
        static void Main(string[] args)
        {
            SuperBase cls = new SuperBase();
            cls.SimpleMethod();

            cls = new Concrete();
            cls.SimpleMethod();

            cls = new SubConcrete();
            if (cls is SubConcrete)
            {
                var copy = cls as SubConcrete;
                copy.SimpleMethod();
            }

        }
    }
}