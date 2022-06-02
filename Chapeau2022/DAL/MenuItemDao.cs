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
    public class MenuItemDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.AddRange(GetAllDrinkItems());
            menuItems.AddRange(GetAllFoodItems());

            return menuItems;
        }

        //Get all food
        List<FoodItem> GetAllFoodItems()
        {
            string query = "SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, F.item_CourseType, F.item_MenuType from MENU_ITEM as M, FOOD as F WHERE M.item_Id = F.item_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<FoodItem> ReadTables(DataTable dataTable)
        {
            List<FoodItem> menuItems = new List<FoodItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                FoodItem menuItem = new FoodItem()
                {
                    Item_Id = (int)dr["item_Id"],
                    Item_Name = (string)dr["item_Name"],
                    Item_Price = (decimal)dr["item_Price"],
                    Item_Stock = (int)dr["item_Stock"],
                    Item_CourseType = (CourseType)dr["item_CourseType"],
                    Item_MenuType = (MenuType)dr["item_MenuType"]

                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        //Get all drinks

        List<DrinkItem> GetAllDrinkItems()
        {
            string query = "SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, D.item_DrinkType from MENU_ITEM as M, DRINK as D WHERE M.item_Id = D.item_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DrinkItem> ReadTablesDrinks(DataTable dataTable)
        {
            List<DrinkItem> menuItems = new List<DrinkItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DrinkItem menuItem = new DrinkItem()
                {
                    Item_Id = (int)dr["item_Id"],
                    Item_Name = (string)dr["item_Name"],
                    Item_Price = (decimal)dr["item_Price"],
                    Item_Stock = (int)dr["item_Stock"],
                    Item_DrinkType = (DrinkType)dr["item_DrinkType"]

                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}
