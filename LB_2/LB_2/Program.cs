using System;

namespace LB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee[] employees = { 
                new TimeEmployee("Анжела", 1, 50.3),
                new TimeEmployee("Надежда ", 2, 34.25),
                new TimeEmployee("Михаил", 3, 53.1),
                new FixedEmployee("Адриан", 4, 7000),
                new FixedEmployee("Марк", 5, 3000),
                new FixedEmployee("Александра", 6, 5611.31)
            };

            showEmployees(employees);

            Array.Sort(employees, new EmployeeComparer());

            Console.WriteLine("\nSORTED");

            showEmployees(employees);
        }

        static void showEmployees(IEmployee[] employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("Info: " + employee.getID() + " " + employee.getName() + " " + employee.countMounthWage());
            }
        }
    }
}
