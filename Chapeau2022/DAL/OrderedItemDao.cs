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
    public class OrderedItemDao : BaseDao
    {
        public List<OrderedItem> GetAllFoodOrders(ItemOrderedStatus itemOrderedStatus)
        {
            string query = "SELECT [ORDER].order_TimeTaken, F.[item_CourseType], M.[item_Name], O.[itemOrdered_Quantity], O.[itemOrdered_Comment], O.[itemOrdered_Status], [ORDER].table_Nr, O.itemOrdered_Id " +
                "FROM[ORDER] " +
                "JOIN ORDERED_ITEM AS O ON O.order_Id = [ORDER].order_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                "JOIN FOOD AS F ON F.item_Id = M.item_Id " +
                "WHERE itemOrdered_Status = @itemOrderedStatus " +
                "AND CAST(order_TimeTaken AS DATE) = CAST(GETDATE() AS DATE) " +
                "ORDER BY [ORDER].order_TimeTaken DESC; ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@itemOrderedStatus", (int)itemOrderedStatus) };
            return ReadFood(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetAllDrinkOrders(ItemOrderedStatus itemOrderedStatus)
        {
            string query = "SELECT [ORDER].order_TimeTaken, D.[item_DrinkType], M.[item_Name], O.[itemOrdered_Quantity], O.[itemOrdered_Comment], O.[itemOrdered_Status], [ORDER].table_Nr, O.itemOrdered_Id " +
                "FROM[ORDER] " +
                "JOIN ORDERED_ITEM AS O ON O.order_Id = [ORDER].order_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                "JOIN DRINK AS D ON D.item_Id = M.item_Id " +
                "WHERE itemOrdered_Status = @itemOrderedStatus " +
                "AND CAST(order_TimeTaken AS DATE) = CAST(GETDATE() AS DATE) " +
                "ORDER BY [ORDER].order_TimeTaken DESC; ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@itemOrderedStatus", (int)itemOrderedStatus) };
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateItemOrderedStatus(OrderedItem orderedItem)
        {
            string query = "UPDATE ORDERED_ITEM " +
                "SET itemOrdered_Status = 1 " +
                "WHERE itemOrdered_Id = @itemOrderedId; ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@itemOrderedId", orderedItem._itemOrdered_id) };
            ExecuteEditQuery(query, sqlParameters);
        }

        /////// end KitchenAndBar queries

        public void MarkOrderedItemAsServed(OrderedItem orderedItem)
        {
            string query = "UPDATE ORDERED_ITEM " +
                "SET itemOrdered_Status = 2 " +
                "WHERE itemOrdered_Id = @itemOrderedId; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@itemOrderedId", orderedItem._itemOrdered_id.ToString());
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderedItem> ReadFood(DataTable datatable)
        {
            List<OrderedItem> items = new List<OrderedItem>();

            foreach (DataRow dr in datatable.Rows)
            {
                FoodItem item = new FoodItem()
                {
                    Item_Name = (string)dr["item_Name"],
                    Item_CourseType = (CourseType)dr["item_CourseType"],

                };

                string comment = "";
                if (dr["itemOrdered_Comment"] != DBNull.Value)
                    comment = (string)dr["itemOrdered_Comment"];

                OrderedItem itemOrdered = new OrderedItem(item)
                {
                    _itemOrdered_id = (int)dr["itemOrdered_Id"],
                    _itemOrdered_Comment = comment,
                    _itemOrdered_Qty = (int)dr["itemOrdered_Quantity"],
                    _itemOrdered_Placed = (DateTime)dr["order_TimeTaken"],
                    _itemOrdered_Status = (ItemOrderedStatus)dr["itemOrdered_Status"],
                    table_Id = (int)dr["table_Nr"]
                };
                items.Add(itemOrdered);
            }

            return items;
        }

        private List<OrderedItem> ReadDrinks(DataTable datatable)
        {
            List<OrderedItem> items = new List<OrderedItem>();

            foreach (DataRow dr in datatable.Rows)
            {
                DrinkItem item = new DrinkItem()
                {
                    Item_Name = (string)dr["item_Name"],
                    Item_DrinkType = (DrinkType)dr["item_DrinkType"]
                };

                string comment = "";
                if (dr["itemOrdered_Comment"] != DBNull.Value)
                    comment = (string)dr["itemOrdered_Comment"];

                OrderedItem itemOrdered = new OrderedItem(item)
                {
                    _itemOrdered_id = (int)dr["itemOrdered_Id"],
                    _itemOrdered_Comment = comment,
                    _itemOrdered_Qty = (int)dr["itemOrdered_Quantity"],
                    _itemOrdered_Placed = (DateTime)dr["order_TimeTaken"],
                    _itemOrdered_Status = (ItemOrderedStatus)dr["itemOrdered_Status"],
                    table_Id = (int)dr["table_Nr"]
                };
                items.Add(itemOrdered);
            }

            return items;
        }


        // MD Tasnim Kabir

        // Get all the ordered items from database
        public List<OrderedItem> GetAllOrderedItems(int tableNr)
        {
            string query = $@" 
                            SELECT m.item_Name,o.itemOrdered_Quantity,m.item_Price,od.order_Id,od.table_Nr,od.order_Status
                            FROM MENU_ITEM as m
                            JOIN ORDERED_ITEM as o on o.item_Id=m.item_Id
                            join [dbo].[ORDER] as od on od.order_Id=o.order_Id
                            WHERE od.order_Status={(int)PayStatus.notpaid} and od.table_Nr=@table_Nr
                             ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@table_Nr", tableNr);

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
        //Anna Koster
        //
        public List<OrderedItem> GetAllOrders(int tableNr)
        {
            string query = $@" 
                            SELECT m.item_Name,o.itemOrdered_Quantity, o.itemOrdered_Status, od.order_Id,od.table_Nr, od.order_TimeTaken
                            FROM MENU_ITEM as m
                            JOIN ORDERED_ITEM as o on o.item_Id=m.item_Id
                            join [dbo].[ORDER] as od on od.order_Id=o.order_Id
                            WHERE od.table_Nr={tableNr}
                             ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderedItem> ReadAllTables(DataTable datatable)
        {
            List<OrderedItem> items = new List<OrderedItem>();

            foreach (DataRow dr in datatable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Item_Name = (string)dr["item_Name"],
                };

                OrderedItem itemOrdered = new OrderedItem(menuItem)
                {
                    _itemOrdered_Qty = (int)dr["itemOrdered_Quantity"],
                    table_Id = (int)dr["table_Nr"],
                    _itemOrder_id = (int)dr["order_Id"],
                    _itemOrdered_Placed = (DateTime)dr["order_TimeTaken"],
                    _itemOrdered_Status = (ItemOrderedStatus)dr["itemOrdered_Status"],

                };
                items.Add(itemOrdered);

            }
            return items;

        }
    }
}