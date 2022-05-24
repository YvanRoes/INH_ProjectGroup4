using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace DAL
{
    public class FoodDao : BaseDao
    {
        public List<FoodItem> GetAllFoodItems()
        {
            string query = "SELECT item_id, ItemName, ItemType, ItemPrice, ItemCourse, ItemQuantity FROM FOODSTOCK;";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTablesFood(ExecuteSelectQuery(query, parameters));
        }

        private List<FoodItem> ReadTablesFood(DataTable table)
        {
            List<FoodItem> list = new List<FoodItem>();

            foreach (DataRow dr in table.Rows)
            {
                FoodItem item = new FoodItem()
                {
                    Item_Id = (int)dr["ItemID"],
                    Item_Name = (string)dr["ItemName"],
                    Item_Price = (decimal)dr["ItemPrice"],
                    Item_Stock = (int)dr["ItemQuantity"],
                };
                list.Add(item);
            }
            return list;
        }
    }
}
