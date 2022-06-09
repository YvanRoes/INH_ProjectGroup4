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
        // Get all the ordered items from database
        public List<OrderedItem> GetAllOrderedItems()
        {
            string query = $@" 
                            SELECT m.item_Name,o.itemOrdered_Quantity,m.item_Price,od.order_Id,od.table_Nr,od.order_Status
                            FROM MENU_ITEM as m
                            JOIN ORDERED_ITEM as o on o.item_Id=m.item_Id
                            join [dbo].[ORDER] as od on od.order_Id=o.order_Id
                            WHERE od.order_Status={(int)PayStatus.notpaid}
                             ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderedItem> ReadTables(DataTable datatable)
        {
            List<OrderedItem> items = new List<OrderedItem>();

            foreach (DataRow dr in datatable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Item_Name = (string)dr["item_Name"],
                    Item_Price = (decimal)dr["item_Price"]
                };

                OrderedItem itemOrdered = new OrderedItem(menuItem)
                {
                    _itemOrdered_Qty = (int)dr["itemOrdered_Quantity"],
                    table_Id = (int)dr["table_Nr"],
                    _itemOrder_id = (int)dr["order_Id"],
                     
                };
                items.Add(itemOrdered);
            }

            return items;
        }
        // When the order is paid ,then update the payment status as paid on database
        public void UpdatePaymentStatus(int orderId)
        {
            string query = $@"UPDATE [dbo].[ORDER] 
                              SET order_Status = {(int)PayStatus.paid}
                              WHERE order_Id = @order_Id";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@order_Id", orderId);

            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
