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
    public class DrinkDao : BaseDao
    {
        public List<DrinkItem> GetAllDrinks()
        {
            string query = "SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, D.item_DrinkType FROM MENU_ITEM AS M, DRINK as D WHERE M.item_ID = D.item_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        //returns an item of the id that is passed to the method
        public DrinkItem GetDrinkItemById(int drinkId)
        {
            string query = "WITH ITEMS AS(SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, D.item_DrinkType FROM MENU_ITEM AS M, DRINK as D WHERE D.item_Id = M.item_Id)SELECT *FROM ITEMS WHERE item_Id = @DrinkItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DrinkItemId", drinkId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        private List<DrinkItem> ReadTables(DataTable dataTable)
        {
            List<DrinkItem> drinks = new List<DrinkItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DrinkItem drink = new DrinkItem()
                {
                    Item_Id = (int)dr["item_Id"],
                    Item_Name = (string)dr["item_Name"],
                    Item_Price = (decimal)dr["item_Price"],
                    Item_DrinkType = (DrinkType)dr["item_DrinkType"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
