using System;

namespace Homework1
{
    public class Program
    {
        static Payroll payroll = new Payroll();

        static void Main(string[] args)
        {
            //Employee kalle = new Employee("Kalle",1000);
            //Employee nisse = new Employee("Nisse", 1000);

            SeedData();

            Employee[] employees = payroll.GetEmployees();
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }

        private static void SeedData()
        {
            payroll.AddEmployee(name: "Kalle", salary: 1000);
            payroll.AddEmployee(name: "Nisse", salary: 3000);
            payroll.AddEmployee(name: "Lisa", salary: 23000);
            payroll.AddEmployee(name: "Anne", salary: 5000);
        }
    }
}
