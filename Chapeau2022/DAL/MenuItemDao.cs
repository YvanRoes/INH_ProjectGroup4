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
        public List<MenuItem> GetAllRunningOrdersName()
        {
            string query = "SELECT M.[itemName] FROM MENU_ITEM AS M JOIN ORDERED_ITEM AS O ON O.menu_Id = M.menu_Id WHERE status = 1; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    /*menuId = (int)dr["menu_Id"],
                    itemName = (string)dr["itemName"],
                    ItemPrice = (decimal)dr["itemPrice"],
                    stock = (int)dr["stock"]*/
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}
