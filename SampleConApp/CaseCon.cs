using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    // Define the interface
    public interface IDataComponent
    {
        void Add(int id, string name, string address, int salary);
        void Remove(int id);
    }

    // Implement the interface in a FileComponent class
    public class FileComponent : IDataComponent
    {
        private readonly string _filePath;

        public FileComponent(string filePath)
        {
            _filePath = filePath;
        }

        public void Add(int id, string name, string address, int salary)
        {
            // Check if the file exists
            if (!File.Exists(_filePath))
            {
                // If the file doesn't exist, create it and add the header row
                File.WriteAllText(_filePath, "ID,Name,Address,Salary");
            }

            // Append the new employee data to the file
            File.AppendAllText(_filePath, Environment.NewLine + id + "," + name + "," + address + "," + salary);
        }

        public void Remove(int id)
        {
            // Read the contents of the file
            string[] lines = File.ReadAllLines(_filePath);

            // Find the index of the row with the specified ID
            int index = Array.FindIndex(lines, line => line.Split(',')[0] == id.ToString());

            // Remove the row from the array
            lines = lines.Where((line, i) => i != index).ToArray();

            // Write the modified array back to the file
            File.WriteAllLines(_filePath, lines);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a FileComponent object
            var dataComponent = new FileComponent("employees.csv");

            // Display the menu
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Remove employee");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            // Read the user's choice
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            while (choice != 3)
            {
                // Perform the chosen operation
                switch (choice)
                {
                    case 1:
                        // Read the employee data
                        Console.Write("Enter employee ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        int salary = int.Parse(Console.ReadLine());

                        // Add the employee
                        dataComponent.Add(id, name, address, salary);
                        break;
                    case 2:
                        Console.Write("Enter employee ID: ");
                        int id = int.Parse(Console.ReadLine());

                        // Remove the employee
                        dataComponent.Remove(id);
                        break;