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
        public int GetRoll(EmployeeRole employeeRole)
        {
            string query = "SELECT COUNT(*) AS count FROM Sales WHERE @employeeRole ";
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@employeeRole", employeeRole);
            DataTable dataTable = ExecuteSelectQuery(query, sp);
            int salesId = (int)dataTable.Rows[0]["count"];
            return salesId;
        }
    }
}
