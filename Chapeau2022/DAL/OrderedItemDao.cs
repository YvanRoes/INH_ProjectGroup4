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
        public List<OrderedItem> GetAllRunningOrdersQuantityAndStatus()
        {
            string query = "SELECT O.quantity, O.status FROM ORDERED_ITEM AS O JOIN DRINK as D ON D.item_Id = O.item_Id WHERE status = 1; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetAllFinishedOrdersQuantityAndStatus()
        {
            string query = "";
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
                    /*itemOrderedId = (int)dr["item_Id"],
                    itemQuantity = (int)dr["quantity"],
                    itemId = (int)dr["menu_Id"],
                    status = (Status)dr["status"]*/
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }
    }
}
