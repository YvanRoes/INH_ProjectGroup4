using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class OrderedItemDao : BaseDao
    {
        public List<OrderedItem> GetAllOrders()
        {
            string query = "SELECT O.quantity FROM ORDERED_ITEM AS O JOIN DRINK as D ON D.item_Id = O.item_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderedItem> ReadTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItems = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedItem orderedItem = new OrderedItem()
                {
                    itemId = (int)dr["item_Id"],
                    quantity = (int)dr["quantity"]
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }
    }
}
