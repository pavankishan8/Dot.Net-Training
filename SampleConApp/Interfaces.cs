using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    interface IExample
    {
        void Create();
    }

    interface ISimple
    {
        void Create();
    }

    class SimpleExample : IExample, ISimple
    {
        public void Create()
        {
            Console.WriteLine("General Implementation");
        }

        void ISimple.Create() => Console.WriteLine("Simple version of Create");
        void IExample.Create() => Console.WriteLine("Example version of Create");
    }
    class Interfaces
    {
        static void Main(string[] args)
        {
            SimpleExample simEx = new SimpleExample();
            simEx.Create();

            IExample ex = new SimpleExample();
            ex.Create();

            ISimple sim = new SimpleExample();
            sim.Create();
        }
    }
}

