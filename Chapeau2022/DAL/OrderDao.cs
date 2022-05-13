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
    public class OrderDao : BaseDao
    {
        public List<MenuItem> GetAllItems()
        {
            string query = "SELECT * FROM STOCK";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<MenuItem> ReadTables(DataTable table)
        {
            List<MenuItem> list = new List<MenuItem>(); 

            foreach(DataRow dr in table.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    _itemId = (int)dr["ItemID"],
                    _itemName = (string)dr["ItemName"],
                    _itemType = (MenuItemType)dr["ItemType"],
                    _ItemPrice = (decimal)dr["ItemPrice"],   
                };
                list.Add(item);
            }
            return list;
        }
    }
}
