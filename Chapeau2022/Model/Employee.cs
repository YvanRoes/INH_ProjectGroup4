using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum EmployeeRole
    {
        waiter, bartender, chef, manager
    }

    public class Employee
    {
        public EmployeeRole EmployeeRole { get; set; }

        public Employee(EmployeeRole employeeRole)
        {

        }
    }
}
