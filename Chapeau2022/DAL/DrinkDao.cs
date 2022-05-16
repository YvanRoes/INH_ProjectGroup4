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
    public class DrinkDao : BaseDao
    {
        public List<DrinkItem> GetAllItems()
        {
            string query = "SELECT ItemID, ItemName, ItemPrice,ItemQuantity, ItemAlcohol FROM DRINKSTOCK";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<DrinkItem> ReadTables(DataTable table)
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
    }
}
