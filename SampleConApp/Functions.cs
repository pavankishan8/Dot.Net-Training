using System;

namespace SampleConApp
{
    class MathComponent
    {
        public long AddFunction(int iVal1, int iVal2)
        {
            long result = iVal1 + iVal2;
            return result;
        }

        public void MathFunc(double v1, double v2, out double addedValue, out double subtractedValue, out double multipliedValue, out double divValue)
        {
            addedValue = v1 + v2;
            subtractedValue = v1 - v2;
            multipliedValue = v1 * v2;
            if (v2 != 0)
                divValue = v1 / v2;
            else
                throw new DivideByZeroException();
        }

        public void SquareBasedFunc(int inputValue, ref double squareValue, ref double sqrRoot)
        {
            squareValue = inputValue * inputValue;
            sqrRoot = Math.Sqrt(inputValue);
        }

        public long MultiplyValues(params int[] values)
        {
            long result = 1;
            foreach (int item in values)
            {
                result *= item;
            }
            return result;
        }

        class Functions
        {
            static void testFunc() => Console.WriteLine("Test Func");
            void testStaticFunc() => testFunc();
            static void Main(string[] args)
            {
                MathComponent component = new MathComponent();

                //int iVal1 = 9;
                //double fVal = 0, sVal = 0;
                //component.SquareBasedFunc(iVal1, ref fVal, ref sVal);
                //Console.WriteLine($"The fVal : {fVal} and sVal : {sVal}");

                //int firstValue = 451, secondValue = 30;
                //double addedVal, subVal, mulVal, divVal;
                //component.MathFunc(firstValue, secondValue, out addedVal, out subVal, out mulVal, out divVal);
                //Console.WriteLine($"The Added value: {addedVal}\nSubtracted Value: {subVal}\nThe multiplied Value: {mulVal}\nThe Divided Value: {divVal: ##.##}");

                long result = component.MultiplyValues(2, 3, 4, 5, 6, 7);
                Console.WriteLine("The Multiplied value: " + result);
            }
        }
    }
}
   


