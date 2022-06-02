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
        public void BillRecord(Bill bill)
        {
            string query = $"INSERT INTO [BILL] VALUES ({bill.Method}, '{bill.Tip}', '{bill.Price}', '{bill.DateTime.ToString("dddd, dd MMMM yyyy")}', {bill.EmployeeID}, {bill.OrderNr})";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
        public List<OrderedItem> GetAllOrderedItems()
        {
            string query = @"SELECT m.item_Name,o.itemOrdered_Quantity,m.item_Price
                             FROM MENU_ITEM as m
                             JOIN ORDERED_ITEM as o on o.item_Id=m.item_Id 
                                ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<OrderedItem> ReadTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItemsList = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                /*OrderedItem orderedItems = new OrderedItem()
                {
                    Item_Name= (string)dr["item_Name"],
                    ItemOrdered_Quantity = (int)dr["itemOrdered_Quantity"],
                    Item_Price= (decimal)dr["item_Price"],
                    
                };
                orderedItemsList.Add(orderedItems);*/
            }
            return orderedItemsList;
        }


    }
}
