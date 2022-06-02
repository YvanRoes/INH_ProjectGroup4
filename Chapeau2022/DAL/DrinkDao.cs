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
        //returns a list of all drink items stored in the database
        public List<DrinkItem> GetAllDrinks()
        {
            string query = "SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, M.item_AmountNeeded, D.item_DrinkType FROM MENU_ITEM AS M, DRINK as D WHERE M.item_ID = D.item_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        //returns an item of the id that is passed to the method
        public DrinkItem GetDrinkItemById(int drinkId)
        {
            string query = "WITH ITEMS AS(SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, M.item_AmountNeeded, D.item_DrinkType FROM MENU_ITEM AS M, DRINK as D WHERE D.item_Id = M.item_Id)SELECT *FROM ITEMS WHERE item_Id = @DrinkItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DrinkItemId", drinkId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        //Update Drink Item information in the database
        public void UpdateDrink(DrinkItem drink)
        {
            string query = "UPDATE MENU_ITEM SET item_Name = @NameOfDrink, item_Price = @DrinkPrice, item_Stock = @Stock, item_AmountNeeded = @DrinkAmountNeeded  WHERE item_Id = @DrinkId; UPDATE DRINK SET item_DrinkType = @DrinkType WHERE item_Id = @DrinkId ";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@NameOfDrink", drink.Item_Name);
            sqlParameters[1] = new SqlParameter("@DrinkType", (int)drink.Item_DrinkType);
            sqlParameters[2] = new SqlParameter("@DrinkPrice", drink.Item_Price);
            sqlParameters[3] = new SqlParameter("@Stock", drink.Item_Stock);
            sqlParameters[4] = new SqlParameter("@DrinkId", drink.Item_Id);
            sqlParameters[5] = new SqlParameter("@DrinkAmountNeeded", drink.Item_AmountNeeded);

            ExecuteEditQuery(query, sqlParameters);
        }
        //Delete an item of specified ID
        public void DeleteDrink(int Id)
        {
            string query = "DELETE FROM MENU_ITEM WHERE item_Id = @DrinkId; DELETE FROM DRINK WHERE item_Id = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DrinkId", Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddDrink(DrinkItem drink)
        {
            string query = "INSERT INTO MENU_ITEM (item_Id, item_Name, Item_Price, Item_Stock, Item_AmountNeeded) VALUES (@DrinkId, @NameOfDrink, @DrinkPrice, @Stock, @DrinkAmountNeeded); INSERT INTO DRINK (item_Id, item_DrinkType) VALUES (@DrinkId, @DrinkType)";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@NameOfDrink", drink.Item_Name);
            sqlParameters[1] = new SqlParameter("@DrinkType", (int)drink.Item_DrinkType);
            sqlParameters[2] = new SqlParameter("@DrinkPrice", drink.Item_Price);
            sqlParameters[3] = new SqlParameter("@Stock", drink.Item_Stock);
            sqlParameters[4] = new SqlParameter("@DrinkId", drink.Item_Id);
            sqlParameters[5] = new SqlParameter("@DrinkAmountNeeded", drink.Item_AmountNeeded);

            ExecuteEditQuery(query, sqlParameters);
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
                    Item_DrinkType = (DrinkType)dr["item_DrinkType"],
                    Item_Stock = (int)dr["item_Stock"],
                    Item_AmountNeeded = (int)dr["item_AmountNeeded"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
