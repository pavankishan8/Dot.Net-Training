using System;

namespace SampleConApp
{
    enum Cars { Lambo, BMW, Audi, Benz, Bugati}
    class EnumExample
    {
        static void Main(string[] args)
        {
            Cars car = Cars.BMW;
            Console.WriteLine("The car selected is " + car);
            Console.WriteLine("Enter the car you like by selecting any one of them:");

            Array possiblecar = Enum.GetValues(typeof(Cars));
            for (int i = 0; i < possiblecar.Length; i++)
                Console.WriteLine(possiblecar.GetValue(i));

            //Console.WriteLine("Which car do you like?");
            object inputValue = Enum.Parse(typeof(Cars), Console.ReadLine(),true);
            Cars selectedCar = (Cars)inputValue;
            Console.WriteLine("The Selected Car is " + selectedCar);

        }
    }
}