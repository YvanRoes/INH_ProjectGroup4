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
    public class BillDao : BaseDao
    {
        //Inser the  bill into the database
        public void InsertBill(Bill bill)
        {
            string query = $"INSERT INTO [BILL] VALUES (@total, @tip, @comment, @method)";
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@total", bill.Total);
            sqlParameters[1] = new SqlParameter("@tip", bill.Tip);
            sqlParameters[2] = new SqlParameter("@comment", bill.Comment);
            sqlParameters[3] = new SqlParameter("@method", bill.Method);
            ExecuteEditQuery(query, sqlParameters);


        }
        public List<OrderedItem> GetAllOrderedItems()
        {
            string query = $@" SELECT m.item_Name,o.itemOrdered_Quantity,m.item_Price,od.order_Id,od.table_Nr
                            FROM MENU_ITEM as m
                            JOIN ORDERED_ITEM as o on o.item_Id=m.item_Id
                            join [dbo].[ORDER] as od on od.order_Id=o.order_Id
                            WHERE od.order_Status={(int)PayStatus.notpaid} ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
         

        private List<OrderedItem> ReadTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItemsList = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedItem orderedItems = new OrderedItem()
                {
                    Item_Name = (string)dr["item_Name"],
                    ItemOrdered_Quantity = (int)dr["itemOrdered_Quantity"],
                    Item_Price = (decimal)dr["item_Price"],
                    TableNr = (int)dr["table_Nr"]
                    
                };
                orderedItemsList.Add(orderedItems);
            }
            return orderedItemsList;
        }


    }
}
