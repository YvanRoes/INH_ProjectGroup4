using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAllEmployees()
        {
            string query = "select E.employee_Id, E.employee_Name, E.employee_StaffRole, E.[password], E.secret_question, E.secret_answer from EMPLOYEE as E";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddEmployee(Employee employee)
        {
            string query = "INSERT INTO EMPLOYEE (employee_Name, employee_StaffRole, password, secret_question, secret_answer) VALUES (@EmployeeName, @EmployeeRole, @EmployeePassword, @EmployeeSecretQuestion, @EmployeeSecretAnwser )";

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@EmployeeName", employee.Employee_Name);
            sqlParameters[1] = new SqlParameter("@EmployeeRole", (int)employee.Employee_Role);
            sqlParameters[2] = new SqlParameter("@EmployeePassword", employee.Employee_Pin);
            sqlParameters[3] = new SqlParameter("@EmployeeSecretQuestion", employee.Employee_SecretQuestion);
            sqlParameters[4] = new SqlParameter("@EmployeeSecretAnwser", employee.Employee_SecretAnwser);

            ExecuteEditQuery(query, sqlParameters);
        }
        public int GetLastId()
        {
            string query = "select MAX(employee_Id) as employee_Id from EMPLOYEE";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReturnInt(ExecuteSelectQuery(query, sqlParameters));
        }
        public void DeleteEmployee(int Id)
        {
            string query = "DELETE FROM EMPLOYEE WHERE employee_Id = @EmployeeId;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EmployeeId", Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateEmployee(Employee employee)
        {
            string query = "UPDATE EMPLOYEE SET employee_Name = @EmployeeName, employee_StaffRole = @EmployeeRole, password = @EmployeePassword, secret_question = @EmployeeSecretQuestion, secret_answer = @EmployeeSecretAnwser  WHERE employee_Id = @EmployeeId";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[5] = new SqlParameter("@EmployeeId", employee.Employee_Id);
            sqlParameters[0] = new SqlParameter("@EmployeeName", employee.Employee_Name);
            sqlParameters[1] = new SqlParameter("@EmployeeRole", (int)employee.Employee_Role);
            sqlParameters[2] = new SqlParameter("@EmployeePassword", employee.Employee_Pin);
            sqlParameters[3] = new SqlParameter("@EmployeeSecretQuestion", employee.Employee_SecretQuestion);
            sqlParameters[4] = new SqlParameter("@EmployeeSecretAnwser", employee.Employee_SecretAnwser);

            ExecuteEditQuery(query, sqlParameters);
        }
        public Employee GetEmployeeItemById(int Id)
        {
            string query = "select E.employee_Id, E.employee_Name, E.employee_StaffRole, E.[password], E.secret_question, E.secret_answer from EMPLOYEE as E where E.employee_Id = @EmployeeId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EmployeeId", Id);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    Employee_Role = (EmployeeRole)int.Parse((string)dr["employee_StaffRole"]),
                    Employee_Id = (int)dr["employee_Id"],
                    Employee_Name = (string)dr["employee_Name"],
                    Employee_Pin = BitConverter.ToInt32((Byte[])dr["password"]),
                    Employee_SecretQuestion = (string)dr["secret_question"],
                    Employee_SecretAnwser = (string)dr["secret_answer"],
                };
                employees.Add(employee);
            }
            return employees;
        }
        private int ReturnInt(DataTable dataTable)
        {
            int i = (int)dataTable.Rows[0]["employee_Id"];

            return i;
        }
    }
}
