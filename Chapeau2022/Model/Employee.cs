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
        private EmployeeRole employeeRole;
        public EmployeeRole EmployeeRole { get { return employeeRole; } set { employeeRole = value; } }
    }
}
