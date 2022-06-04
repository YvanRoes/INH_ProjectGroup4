using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum EmployeeRole
    {
        waiter=1, bartender, chef, manager
    }
    public class Employee
    {
        private int employee_Id;
        private string employee_Name;
        private string employee_SecretQuestion;
        private string employee_SecretAnwser;
        private int employee_Pin;
        private EmployeeRole employeeRole;
        public int Employee_Id { get { return employee_Id; } set { employee_Id = value; } }
        public string Employee_Name { get { return employee_Name; } set { employee_Name = value; } }
        public string Employee_SecretQuestion { get { return employee_SecretQuestion; } set { employee_SecretQuestion = value; } }
        public string Employee_SecretAnwser { get { return employee_SecretAnwser; } set { employee_SecretAnwser = value; } }
        public int Employee_Pin { get { return employee_Pin; } set { employee_Pin = value; } }
        public EmployeeRole Employee_Role { get { return employeeRole; } set { employeeRole = value; } }
    }
}
