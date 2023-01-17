using System;
using System.IO;
using System.Threading;

namespace SampleFrameworksApp
{
    class Ex_11_MultiThreading
    {
        static Thread thread;
        static int no = 0;

        static void threadFunc()
        {
            //Monitor.Enter(typeof(Ex11MultiThreading));
            lock (typeof(Ex_11_MultiThreading))
            {
                for (int i = 0; i < 10; i++)
                {
                    no += i;
                    var content = $"Thread Id with beep # {i} and count {no}";
                    Console.WriteLine(content);
                    Thread.Sleep(1000);
                }
            }
            //Monitor.Exit(typeof(Ex11MultiThreading));
        }

        static void LargeFuncWithParameters(object data)
        {
            string filename = data.ToString();
            var contents = File.ReadAllLines(filename);

            foreach (var line in contents)
            {
                Thread.Sleep(1000);

                foreach (var ch in line.ToCharArray())
                {
                    Console.Write(ch);
                    Thread.Sleep(200);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Complete set of Records is read");
        }

        static void defaultThreadOperation()
        {
            Console.WriteLine("The large function has started");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Large Func is doing some job!!!");
            }
            Console.Clear();
            Console.WriteLine("The large function has completed");
        }

        static void MultipleThreadsExample()
        {
            Thread t1 = new Thread(threadFunc);
            Thread t2 = new Thread(threadFunc);
            t1.Start();
            t2.Start();
        }

        static void LargeFunction()
        {
            Console.WriteLine("The large function has started");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Large Func is doing some job!!!");
            }
            Console.Clear();
            Console.WriteLine("The large function has completed");
        }

        static void ParameterizedThreadOperation()
        {
            ParameterizedThreadStart threadOp = new ParameterizedThreadStart(LargeFuncWithParameters);
            Thread th = new Thread(threadOp);
            th.IsBackground = true;
            th.Start("../../MOCK_DATA.csv");
            th.Join();
        }

        static void mainOperation()
        {
            Console.WriteLine("Main is doing its job");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main is doing some job!!!");
            }
            Console.WriteLine("The Main has ended, UR App now Terminates!!!!");

        }

        static void Main(string[] args)
        {
            //mainOperation();
            MultipleThreadsExample();
            //defaultThreadOperation();
            //ParameterizedThreadOperation();
            Console.WriteLine("Main is doing its job");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main is doing some job!!!");
                
            }
            Console.WriteLine("The Main has ended, UR App now Terminates!!!!");
            if (thread.ThreadState == ThreadState.Suspended)
            {
                thread.Resume();
            }


            //ThreadStart tFunc = new ThreadStart(LargeFunction);
            //Thread thread = new Thread(tFunc);
            //thread.Start();
            //Console.WriteLine("Main is doing its job");
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Main is doing some job!!!");
            //}
            //Console.WriteLine("The Main has ended, UR App now Terminates!!!!");
        }
    }
}

