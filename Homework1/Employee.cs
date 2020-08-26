using System;
using System.Dynamic;
using System.Reflection.Metadata;

namespace Homework1
{
    public class Employee
    {
        private string name;
        private int salary;

        public string Name{ get; set; }
        public int Salary { get; set; }

        //public int Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
   

        public void AddEmployee(string name, int salary)
        {
            throw new NotImplementedException();
        }
    }
}