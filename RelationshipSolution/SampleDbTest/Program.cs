using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AddEmployees();


            Console.ReadLine();
        }

        private static void AddEmployees()
        {
            using (var context = new SampleDbContext())
            {

                var employer = new Employer
                {
                    EmployerName = "CTS"

                };
                var employee = new Employee
                {
                    EmployeeName = "srikanth",
                    Employer = employer
                };

                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }
    }
}
