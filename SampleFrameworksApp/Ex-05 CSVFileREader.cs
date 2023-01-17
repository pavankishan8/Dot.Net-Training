using SampleConApp;
using SampleFrameworksApp.Practical;
using System;
using System.Collections.Generic;
using System.IO;


namespace SampleFrameworksApp
{
    class CSVFileREader
    {
        
        const string fileName = "../../Customers.csv";

        static void Main(string[] args)
        {
            var choice = UtilitiesCSV.Prompt("Press A for adding or V for Viewing\nAdd or View");
            if (choice.ToUpper() == "A")
                writingExample();
            else if (choice.ToUpper() == "V")
                readingExample();
            else
                Console.WriteLine("Invalid Choice");
        }

        private static void readingExample()
        {
            List<Customer> allCustomers = new List<Customer>();

            var allLines = File.ReadAllLines(fileName);

            foreach (var line in allLines)
            {
                var words = line.Split(',');
                Customer cst = new Customer();
                cst.CustomerId = int.Parse(words[0]);
                cst.CustomerName = words[1];
                cst.CustomerAddress = words[2];
                cst.BillAmount = int.Parse(words[3]);
                allCustomers.Add(cst);
            }

            foreach (var cst in allCustomers)
            {
                Console.WriteLine(cst.CustomerName);
            }

        }

        private static void writingExample()
        {
            Customer cst = new Customer
            {
                CustomerId = UtilitiesCSV.GetNumber("Enter the Customer ID"),
                CustomerName = UtilitiesCSV.Prompt("Enter the Customer name"),
                CustomerAddress = UtilitiesCSV.Prompt("Enter the Customer Address"),
                BillAmount = UtilitiesCSV.GetNumber("Enter the Bill Amount")

            };
            File.AppendAllText(fileName, cst.ToString());
        }
    }
}
