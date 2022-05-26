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
    public class KitchenDao : BaseDao
    {
        public List<KitchenItem> GetAllRunningOrders()
        {
            string query = "SELECT [ORDER].order_TimeTaken, F.[item_CourseType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                "FROM[ORDER] " +
                "JOIN IS_MADE_OF AS I ON I.order_Id = [ORDER].order_Id " +
                "JOIN ORDERED_ITEM AS O ON O.itemOrdered_Id = I.itemOrdered_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                "JOIN FOOD AS F ON F.item_Id = M.item_Id " +
                "WHERE itemOrdered_Status = 1;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<KitchenItem> GetAllFinishedOrders()
        {
            string query = "SELECT [ORDER].order_TimeTaken, F.[item_CourseType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                "FROM[ORDER] " +
                "JOIN IS_MADE_OF AS I ON I.order_Id = [ORDER].order_Id " +
                "JOIN ORDERED_ITEM AS O ON O.itemOrdered_Id = I.itemOrdered_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                "JOIN FOOD AS F ON F.item_Id = M.item_Id " +
                "WHERE itemOrdered_Status = 0;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<KitchenItem> ReadTables(DataTable dataTable)
        {
            List<KitchenItem> kitchens = new List<KitchenItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                KitchenItem kitchen = new KitchenItem()
                {
                    Placed = (DateTime)dr["order_TimeTaken"],
                    FoodQuantity = (int)dr["itemOrdered_Quantity"],
                    CourseType = (CourseType)dr["item_CourseType"],
                    FoodName = (string)dr["item_Name"],
                    FoodDescription = (string)dr["item_Description"],
                    FoodStatus = (Status)dr["itemOrdered_Status"],
                };
                kitchens.Add(kitchen);
            }
            return kitchens;
        }
    }
}
