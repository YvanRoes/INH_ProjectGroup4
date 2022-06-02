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
    public class OrderDao : BaseDao
    {
        public List<int> GetOrderNumbers()
        {
            string query = "SELECT order_Id FROM [ORDER]";
            SqlParameter[] parameters = new SqlParameter[] { };
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<int> ReadTables(DataTable dataTable)
        {
            List<int> nums = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
                nums.Add((int)dr["order_Id"]);
            return nums;
        }

        public void MakeNewOrder(Order order)
        {
            string query = "INSERT INTO [ORDER](order_Id, order_TimeTaken, order_Status, employee_Id, table_Nr) values(@order, @time, @status, @employee, @table)";
            /*SqlParameter[] parameters = new SqlParameter[]{new SqlParameter("@time", DateTime.Now), new SqlParameter("@status", order.status), new SqlParameter("@employee", order.employee_Id), new SqlParameter("@table", order.table_Id)};*/
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@order", order.Order_Id), new SqlParameter("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), new SqlParameter("@status", order.status), new SqlParameter("@employee", 1), new SqlParameter("@table", order.table_Id) };
            ExecuteEditQuery(query, parameters);
        }
    }
}
