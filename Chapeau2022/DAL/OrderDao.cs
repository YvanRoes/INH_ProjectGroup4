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
            MakeOrderTicket(order);
            MakeOrderItems(order);
        }

        private void MakeOrderTicket(Order order)
        {
            string query = "INSERT INTO [ORDER](order_Id, order_TimeTaken, order_Status, employee_Id, table_Nr) VALUES(@order, @time, @status, @employee, @table)";
            /*SqlParameter[] parameters = new SqlParameter[]{new SqlParameter("@time", DateTime.Now), new SqlParameter("@status", order.status), new SqlParameter("@employee", order.employee_Id), new SqlParameter("@table", order.table_Id)};*/
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@order", order.Order_Id), new SqlParameter("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), new SqlParameter("@status", order.status), new SqlParameter("@employee", order.employee_Id), new SqlParameter("@table", order.table_Id) };
            ExecuteEditQuery(query, parameters);
        }

        private void MakeOrderItems(Order order)
        {
            foreach(OrderedItem Item in order.menuItems)
            {
                string query = "INSERT INTO [ORDERED_ITEM](itemOrdered_Quantity, itemOrdered_Status, item_Id, itemOrdered_Comment, order_Id) VALUES(@OrderedQty, @OrderedStatus, @ItemId, @OrderedComment, @OrderId)";
                SqlParameter[] parameters = new SqlParameter[]{ new SqlParameter("@OrderedQty", Item._itemOrdered_Qty), new SqlParameter("@OrderedStatus", (int)Item._itemOrdered_Status), new SqlParameter("@itemId", Item.menuItem.Item_Id), new SqlParameter("@OrderedComment", Item._itemOrdered_Comment), new SqlParameter("@OrderId", order.Order_Id)};
                ExecuteEditQuery(query, parameters);
            }
        }
    }
}
