using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class EmployeeService
    {
        EmployeeDao employeeDao;
        public EmployeeService() => employeeDao = new EmployeeDao();
        public List<Employee> GetAllDrinkItems() => employeeDao.GetAllEmployees();
        public int GetLastId() => employeeDao.GetLastId();
        public void AddEmployee(Employee employee) => employeeDao.AddEmployee(employee);
        public void DeleteEmployee(int Id) => employeeDao.DeleteEmployee(Id);
        public Employee GetEmployeeById(int Id) => employeeDao.GetEmployeeItemById(Id);
        public void UpdateEmployee(Employee employee) => employeeDao.UpdateEmployee(employee);
    }
}
