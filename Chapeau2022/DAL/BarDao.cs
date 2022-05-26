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
    public class BarDao : BaseDao
    {
        public List<Bar> GetAllRunningOrders()
        {
            string query = "SELECT [ORDER].order_TimeTaken, D.[item_DrinkType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                "FROM[ORDER] JOIN IS_MADE_OF AS I ON I.order_Id = [ORDER].order_Id " +
                "JOIN ORDERED_ITEM AS O ON O.itemOrdered_Id = I.itemOrdered_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_I " +
                "JOIN DRINK AS D ON D.item_Id = M.item_Id " +
                "WHERE itemOrdered_Status = 1; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bar> GetAllFinishedOrders()
        {
            string query = "SELECT [ORDER].order_TimeTaken, D.[item_DrinkType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                "FROM[ORDER] JOIN IS_MADE_OF AS I ON I.order_Id = [ORDER].order_Id " +
                "JOIN ORDERED_ITEM AS O ON O.itemOrdered_Id = I.itemOrdered_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_I " +
                "JOIN DRINK AS D ON D.item_Id = M.item_Id " +
                "WHERE itemOrdered_Status = 0; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
       
        private List<Bar> ReadTables(DataTable dataTable)
        {
            List<Bar> bars = new List<Bar>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bar bar = new Bar()
                {
                    Placed = (DateTime)dr["order_TimeTaken"],
                    DrinkQuantity = (int)dr["itemOrdered_Quantity"],
                    DrinkType = (DrinkType)dr["item_DrinkType"],
                    DrinkName = (string)dr["item_Name"],
                    DrinkDescription = (string)dr["item_Description"],
                    DrinkStatus = (ItemOrderedStatus)dr["itemOrdered_Status"]
                };
                bars.Add(bar);
            }
            return bars;
        }
    }
}
