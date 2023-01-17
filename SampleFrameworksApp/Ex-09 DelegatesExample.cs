using SampleConApp;
using System;

namespace SampleFrameworksApp
{
    delegate double ArithmaticOperation(double v1, double v2);
    class MathComponent
    {
        public static void PerformOperation(ArithmaticOperation operation)
        {
            var v1 = double.Parse(UtilitiesCSV.Prompt("Enter the First Value"));
            var v2 = double.Parse(UtilitiesCSV.Prompt("Enter the Second Value"));
            //var res = operation(v1, v2);
            Delegate[] allOperations = operation.GetInvocationList();
            foreach (Delegate func in allOperations)
            {
                Console.WriteLine(func.Method.Name);
                Console.WriteLine("The Result of this Operation is " + func.DynamicInvoke(v1, v2));
                Console.WriteLine("\n");
                //Console.WriteLine("The Result of this Operation is " + res);
            }
        }
        class Ex_09_DelegatesExample
        {
            static double addFunc(double firstValue, double secondValue)
            {
                return firstValue + secondValue;
            }

            static double subFunc(double firstValue, double secondValue)
            {
                return firstValue - secondValue;
            }

            static double mulFunc(double firstValue, double secondValue)
            {
                return firstValue * secondValue;
            }

            static double divFunc(double firstValue, double secondValue)
            {
                return firstValue / secondValue;
            }
            static void Main(string[] args)
            {
                /////////////////////////////////////Operations with Menu///////////////////////////////////////

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Delegate Mathematical Function App\n");
                Console.ForegroundColor = ConsoleColor.Blue;

                MathComponent math = new MathComponent();
                while (true)
                {
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Substaction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. All above Operations at once");

                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    { MathComponent.PerformOperation(new ArithmaticOperation(addFunc));
                    }

                    else if (choice == 2)
                    {
                        MathComponent.PerformOperation(delegate (double v2, double v1)
                  {
                      return v2 - v1;
                  });
                    }

                    else if (choice == 3)
                    {
                        MathComponent.PerformOperation((a, b) => a * b);
                    }

                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.WriteLine("Wrong Selection!");
                    //    Console.ForegroundColor = ConsoleColor.Blue;
                    //    break;
                    //}

                    ////////////////////////////////////Operations without Menu/////////////////////////////////////

                    //MathComponent.PerformOperation(new ArithmaticOperation(addFunc));

                    //MathComponent.PerformOperation(delegate (double v2, double v1)
                    //{
                    //    return v2 - v1;
                    //});

                    //MathComponent.PerformOperation((a, b) => a * b);

                    ////////////////////////////////////////////////////////////////////////////////////////////////
                    else if (choice == 4){
                        ArithmaticOperation operations = new ArithmaticOperation(addFunc);

                        operations += new ArithmaticOperation(subFunc);

                        //operations += new ArithmaticOperation(delegate (double v1, double v2)
                        //{
                        //    return v1 * v2;
                        //});

                        //operations += new ArithmaticOperation(delegate (double v1, double v2)
                        //{
                        //    return v1 / v2;
                        //});

                        operations += new ArithmaticOperation(mulFunc);

                        operations += new ArithmaticOperation(divFunc);

                        MathComponent.PerformOperation(operations);
                    }

                }
            }
        }
    } }
