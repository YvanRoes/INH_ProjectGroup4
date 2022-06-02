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
        private int employee_Id;
        private int employee_Name;
        private int employee_Pin;
        private EmployeeRole employeeRole;
        public int Employee_Id { get { return employee_Id; } set { employee_Id = value; } }
        public int Employee_Name { get { return employee_Name; } set { employee_Name = value; } }
        public int Employee_Pin { get { return employee_Pin; } set { employee_Pin = value; } }
        public EmployeeRole EmployeeRole { get { return employeeRole; } set { employeeRole = value; } }
    }
}
