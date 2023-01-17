using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SampleConApp
{

    public class EmpIDAlreadyExistsException : Exception
    {
        public EmpIDAlreadyExistsException() : this("Unknown Error")
        {

        }
        public EmpIDAlreadyExistsException(string message) : base(message)
        {
            Utilities.LogMessage(message);
        }
        public EmpIDAlreadyExistsException(string message, Exception inner) : base(message, inner)
        {

        }

    }
    class ExceptionDemo
    {
        static void tryExample()
        {
        RETRY:
            Console.WriteLine("Enter a number to add");
            int no;
            try
            {
                no = int.Parse(Console.ReadLine());
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("input expected was a valid integer");
                Utilities.LogMessage(formEx.Message);
                throw new EmpIDAlreadyExistsException("EmpID already exists");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The number should be b/w {0} to {1}", int.MinValue, int.MaxValue);
                Utilities.LogMessage(ex.Message);
                goto RETRY;
            }
            catch (EmpIDAlreadyExistsException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto RETRY;
            }
            Console.WriteLine("The entered value is " + no);
        }

        static void Main(string[] args)
        {
            try
            {
                tryExample();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
