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
    public  class OrderedItemDao : BaseDao
    {
        public List<OrderedItem> GetAllFoodOrders(ItemOrderedStatus itemOrderedStatus)
        {
            string query = "SELECT [ORDER].order_TimeTaken, F.[item_CourseType], M.[item_Name], O.[itemOrdered_Quantity], O.[itemOrdered_Comment], O.[itemOrdered_Status], [ORDER].table_Nr, O.itemOrdered_Id " +
                "FROM[ORDER] " +
                "JOIN ORDERED_ITEM AS O ON O.order_Id = [ORDER].order_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                "JOIN FOOD AS F ON F.item_Id = M.item_Id " +
                $"WHERE itemOrdered_Status = {(int)itemOrderedStatus} " +
                "AND CAST(order_TimeTaken AS DATE) = CAST(GETDATE() AS DATE) " +
                "ORDER BY [ORDER].order_TimeTaken DESC; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFood(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetAllDrinkOrders(ItemOrderedStatus itemOrderedStatus)
        {
            string query = "SELECT [ORDER].order_TimeTaken, D.[item_DrinkType], M.[item_Name], O.[itemOrdered_Quantity], O.[itemOrdered_Comment], O.[itemOrdered_Status], [ORDER].table_Nr, O.itemOrdered_Id " +
                "FROM[ORDER] " +
                "JOIN ORDERED_ITEM AS O ON O.order_Id = [ORDER].order_Id " +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                "JOIN DRINK AS D ON D.item_Id = M.item_Id " +
                $"WHERE itemOrdered_Status = {(int)itemOrderedStatus} " +
                "AND CAST(order_TimeTaken AS DATE) = CAST(GETDATE() AS DATE) " +
                "ORDER BY [ORDER].order_TimeTaken DESC; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateItemOrderedStatus(OrderedItem orderedItem)
        {
            string query = "UPDATE ORDERED_ITEM " +
                "SET itemOrdered_Status = 1 " +
                "WHERE itemOrdered_Id = @itemOrderedId; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@itemOrderedId", orderedItem._itemOrdered_id.ToString());
            ExecuteEditQuery(query, sqlParameters);
        }
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

            foreach(DataRow dr in datatable.Rows)
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
                    _itemOrdered_id= (int)dr["itemOrdered_Id"],
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
    }
}
