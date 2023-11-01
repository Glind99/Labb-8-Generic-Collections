using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8_Generic_Collections
{
    internal class Employee //Employee class
    {
        // Properties to store employee information
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string Role { get; set; }

        public Employee(int id, string name, string gender, int salary)// Constructor for creating an employee object with mandatory properties (id, name, gender, salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;

        }
        public Employee(int id, string name, string gender, int salary, string role) // Constructor for creating an employee object with all properties (id, name, gender, salary, role)
        {
            Id =id;
            Name = name;
            Gender = gender;
            Salary = salary;
            Role = role;
        }
        public override string ToString() // Override the ToString() method to provide a custom string representation of the employee object

        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary}.";
        }

    }
}
