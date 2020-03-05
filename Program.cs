using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public Employee(string first, string last, string title, DateTime start)
        {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = start;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS", new DateTime(1999, 1, 21));
            // Create three employees
            Employee Adam = new Employee("Adam", "Sheaffer", "Senior Instructor", new DateTime(2020, 2, 24));
            Employee Brenda = new Employee("Brenda", "Long", "Junior Instructor", new DateTime(2020, 2, 24));
            Employee Rose = new Employee("Rose", "Wisotzky", "Junior Instructor", new DateTime(2020, 2, 24));
            // Assign the employees to the company
            NSS.Employees.Add(Adam);
            NSS.Employees.Add(Brenda);
            NSS.Employees.Add(Rose);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployees();
        }
    }
}