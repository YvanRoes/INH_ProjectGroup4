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
    public class StockDao : BaseDao
    {


        //Drinks
        public List<DrinkItem> GetAllDrinkItems()
        {
            string query = "SELECT ItemID, ItemName, ItemPrice,ItemQuantity, ItemAlcohol FROM DRINKSTOCK";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTablesDrinks(ExecuteSelectQuery(query, parameters));
        }

        private List<DrinkItem> ReadTablesDrinks(DataTable table)
        {
            List<DrinkItem> list = new List<DrinkItem>();

            foreach (DataRow dr in table.Rows)
            {
                DrinkItem item = new DrinkItem()
                {
                    _itemId = (int)dr["ItemID"],
                    _itemName = (string)dr["ItemName"],
                    _ItemPrice = (decimal)dr["ItemPrice"],
                    _ItemQty = (int)dr["ItemQuantity"],
                    _isAlcoholic = (bool)dr["ItemAlcohol"]
                };
                list.Add(item);
            }
            return list;
        }


        //Food
        public List<FoodItem> GetAllFoodItems()
        {
            string query = "SELECT ItemID, ItemName, ItemType, ItemPrice, ItemCourse, ItemQuantity FROM FOODSTOCK";
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
