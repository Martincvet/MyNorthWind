using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TestNorthWind
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new NorthwindContext();
            var employees = context.Employees.ToList().OrderBy(x=>x.FirstName);
            foreach (var employee in employees)
            {
                Console.WriteLine($"Hello {employee.FirstName} {employee.LastName}!");
            }

            Console.ReadLine();
        }
    }
}
