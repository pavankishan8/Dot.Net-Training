using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLayer;

namespace SampleFrameworksApp.Practical
{
    class MainUI
    {
        static IDataComponent component = null;
        static MainUI()
        {
            //Console.WriteLine("Enter the Name of the Component as : List or ArrayList");
            //component = CustomerFactory.GetComponent(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            HashsetCollection collection = new HashsetCollection();
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Pavan R", CustomerAddress = "Bangalore", BillAmount = 86000 });
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Sachin R", CustomerAddress = "Mysore", BillAmount = 56000 });
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Vishwas V", CustomerAddress = "Chennai", BillAmount = 56000 });
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Priya B", CustomerAddress = "Dharwad", BillAmount = 96000 });
            collection.AddNewCustomer(new Customer { CustomerId = 112, CustomerName = "Pavan R", CustomerAddress = "Bangalore", BillAmount = 8600 });
            Console.WriteLine("The Total no of Customers: " + collection.AllCustomers.Count);

            foreach (var customer in collection.AllCustomers)
                Console.WriteLine(customer);
        }

        private static void factoryTesting()
        {
            component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Pavan R", CustomerAddress = "Bangalore", BillAmount = 5600 });
            component.UpdateCustomer(new Customer { CustomerId = 111, CustomerName = "Sachin R", CustomerAddress = "Mysore", BillAmount = 8200 });
            var data = component.GetAllCustomers();
            foreach (Customer customer in data)
                Console.WriteLine(customer);
            component.DeleteCustomer(111);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
