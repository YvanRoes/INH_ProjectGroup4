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
    public class FoodDao : BaseDao
    {
        public List<FoodItem> GetAllItems()
        {
            string query = "SELECT ItemID, ItemName, ItemType, ItemPrice, ItemCourse, ItemQuantity FROM FOODSTOCK";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<FoodItem> ReadTables(DataTable table)
        {
            List<FoodItem> list = new List<FoodItem>();

            foreach (DataRow dr in table.Rows)
            {
                FoodItem item = new FoodItem()
                {
                    _itemId = (int)dr["ItemID"],
                    _itemName = (string)dr["ItemName"],
                    _ItemType = (MenuItemType)dr["ItemType"],
                    _ItemPrice = (decimal)dr["ItemPrice"],
                    _ItemQty = (int)dr["ItemQuantity"],
                    _ItemCourse = (MenuItemCourse)dr["ItemCourse"]
                };
                list.Add(item);
            }
            return list;
        }
    }
}
