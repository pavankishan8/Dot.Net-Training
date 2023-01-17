using System;


namespace SampleConApp
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Array");   //Asking the Input.
            int size = int.Parse(Console.ReadLine());    //Taking the input.

            Console.WriteLine("Please Enter  the CTS  Equivalent name for the type of the array that you want to create");    //Asking CTS.
            string typeName = Console.ReadLine();    //Taking CTS input.
            Type type = Type.GetType(typeName, true, true);    //Left true is for struct, Right is for case sensitive.
            Array myArray = Array.CreateInstance(type, size);    //Creating Array Instance.

            for (int i = 0; i < size; i++) {

                Console.WriteLine($"Enter the value of the type {type.Name}");  //Taking data type Input.
                string enteredValue = Console.ReadLine();   //Taking the Value.
                object convertedValue = Convert.ChangeType(enteredValue, type);    //Converting the Value.
                myArray.SetValue(convertedValue, i);

            }
                    Console.WriteLine("All the values are set");
                     foreach (object item in myArray)
                      {
                            Console.WriteLine(item);
                      }
        }
    }
}
