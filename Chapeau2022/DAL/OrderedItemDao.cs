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
            string query = "SELECT [ORDER].order_TimeTaken, F.[item_CourseType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                "FROM[ORDER]" +
                "JOIN ORDERED_ITEM AS O ON O.order_Nr = [ORDER].order_Id" +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id" +
                "JOIN FOOD AS F ON F.item_Id = M.item_Id" +
                $"WHERE itemOrdered_Status = {(int)itemOrderedStatus};";
                
                //"SELECT [ORDER].order_TimeTaken, F.[item_CourseType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                //"FROM[ORDER] " +
                //"JOIN IS_MADE_OF AS I ON I.order_Id = [ORDER].order_Id " +
                //"JOIN ORDERED_ITEM AS O ON O.itemOrdered_Id = I.itemOrdered_Id " +
                //"JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
                //"JOIN FOOD AS F ON F.item_Id = M.item_Id " +
                //$"WHERE itemOrdered_Status = {(int)itemOrderedStatus};";
                //"AND CAST(order_TimeTaken AS DATE) = CAST(GETDATE() AS DATE);";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFoodTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetAllDrinkOrders(ItemOrderedStatus itemOrderedStatus)
        {
            string query = "SELECT [ORDER].order_TimeTaken, D.[item_DrinkType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
                "FROM[ORDER]" +
                "JOIN ORDERED_ITEM AS O ON O.order_Nr = [ORDER].order_Id" +
                "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id" +
                "JOIN DRINK AS D ON D.item_Id = M.item_Id" +
                $"WHERE itemOrdered_Status = {(int)itemOrderedStatus};";

            //"SELECT [ORDER].order_TimeTaken, D.[item_DrinkType], M.[item_Name], O.[itemOrdered_Quantity], O.[item_Description], O.[itemOrdered_Status] " +
            //    "FROM[ORDER] JOIN IS_MADE_OF AS I ON I.order_Id = [ORDER].order_Id " +
            //    "JOIN ORDERED_ITEM AS O ON O.itemOrdered_Id = I.itemOrdered_Id " +
            //    "JOIN MENU_ITEM AS M ON M.item_Id = O.item_Id " +
            //    "JOIN DRINK AS D ON D.item_Id = M.item_Id " +
            //    $"WHERE itemOrdered_Status = {(int)itemOrderedStatus}; ";
                //"AND CAST(order_TimeTaken AS DATE) = CAST(GETDATE() AS DATE);";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinkTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //public void UpdateActivity(OrderedItem orderedItem)
        //{

        //    string query = "Update activity set activityname=@activityname,activitytype=@activitytype,startDate=@startDate,endDate=@endDate where activityID=@activityID";
        //    SqlParameter[] sqlParameters = new SqlParameter[5];
        //    sqlParameters[0] = new SqlParameter("@activityID", activity.ID.ToString());
        //    sqlParameters[1] = new SqlParameter("@activityname", activity.Name);
        //    sqlParameters[2] = new SqlParameter("@startDate", activity.startDate);
        //    sqlParameters[3] = new SqlParameter("@endDate", activity.endDate);
        //    sqlParameters[4] = new SqlParameter("@activitytype", activity.Type);
        //    ExecuteEditQuery(query, sqlParameters);
        //}

        private List<OrderedItem> ReadFoodTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItems = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string comment = "";

                if (dr["item_Description"].Equals(DBNull.Value))
                {
                    comment = "null";
                }
                else
                {
                    comment = (string)dr["item_Description"];
                }
                OrderedItem orderedItem = new OrderedItem()
                {
                    Placed = (DateTime)dr["order_TimeTaken"],
                    ItemOrdered_Quantity = (int)dr["itemOrdered_Quantity"],
                    Item_CourseType = (CourseType)dr["item_CourseType"],
                    Item_Name = (string)dr["item_Name"],
                    ItemOrderedDescription = comment,
                    ItemOrdered_status = (ItemOrderedStatus)dr["itemOrdered_Status"]
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }

        private List<OrderedItem> ReadDrinkTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItems = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedItem orderedItem = new OrderedItem()
                {
                    Placed = (DateTime)dr["order_TimeTaken"],
                    ItemOrdered_Quantity = (int)dr["itemOrdered_Quantity"],
                    Item_DrinkType = (DrinkType)dr["item_DrinkType"],
                    Item_Name = (string)dr["item_Name"],
                    ItemOrderedDescription = (string)dr["item_Description"],
                    ItemOrdered_status = (ItemOrderedStatus)dr["itemOrdered_Status"]
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }
    }
}
