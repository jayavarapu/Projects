using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    // Relation ship 1-1, 1 to Many and Many to Many 

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public virtual Employer Employer { get; set; }


    }

    public class Employer
    {
        public Employer()
        {
            Employees = new List<Employee>();
        }
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }

}
