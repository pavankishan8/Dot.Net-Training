using System;
using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Customer(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nPhone: {Phone}\nEmail: {Email}\n";
    }
}

class ShoppingComplex
{
    private List<Customer> customers = new List<Customer>();
    

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);

    }

    public void RemoveCustomer(Customer customer)
    {
        customers.Remove(customer);
    }

    public void ListCustomers()
    {
        for (int i = 0; i < customers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {customers[i]}");
        }
    }

    public Customer SearchCustomer(string name)
    {
        foreach (Customer customer in customers)
        {
            if (customer.Name.ToLower() == name.ToLower())
            {
                return customer;
            }
        }
        return null;
    }
}

class UI
{
    static void Main(string[] args)
    {
        ShoppingComplex complex = new ShoppingComplex();
        while (true)
        {
            Console.WriteLine("To Add customer -------------------------------------->PRESS 1");
            Console.WriteLine("To Remove customer ----------------------------------->PRESS 2");
            Console.WriteLine("To List customers ------------------------------------>PRESS 3");
            Console.WriteLine("To Search customer ----------------------------------->PRESS 4");
            Console.WriteLine("To Exit ---------------------------------------------->PRESS 5");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Customer Phone No: ");
                string phone = Console.ReadLine();
                Console.Write("Enter Customer Email: ");
                string email = Console.ReadLine();
                Customer customer = new Customer(name, phone, email);
                complex.AddCustomer(customer);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCustomer Added Successfully!\n");
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (choice == 2)
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();
                Customer customer = complex.SearchCustomer(name);
                if (customer != null)
                {
                    complex.RemoveCustomer(customer);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCustomer removed!\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCustomer not found!\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            else if (choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---List of Customers---");
                Console.ForegroundColor = ConsoleColor.Blue;
                complex.ListCustomers();
            }
            else if (choice == 4)
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();
                Customer customer = complex.SearchCustomer(name);
                if (customer != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Customer found!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(customer);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Customer not found!");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
}