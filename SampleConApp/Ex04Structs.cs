using System;

namespace SampleConApp
{
    struct Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }

        public Employee(int id, string name, string address, double salary)
        {
            EmpId = id;
            EmpName = name;
            EmpAddress = address;
            EmpSalary = salary;
        }
        public string GetDetails()
        {
             return $"The Name: {EmpName} of ID {EmpId} is from {EmpAddress} with Salary {EmpSalary}";
        }

    }
    class Ex04Structs
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee { EmpId = 2222, EmpAddress = "Bangalore", EmpName = "Pavan R", EmpSalary = 58000};
            Console.WriteLine(emp.GetDetails());
        }

        }
}
