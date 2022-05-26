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
            string query = "SELECT M.item_Id,item_Name,item_Price,item_Stock,item_DrinkType FROM MENU_ITEM AS M JOIN DRINK AS F ON M.item_Id = F.item_Id;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    Item_Stock = (int)dr["item_Stock"],
                    Item_DrinkType = (DrinkType)dr["item_DrinkType"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
