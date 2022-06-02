using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace DAL
{
    //comments refer to methods above which they're written
    public class FoodDao : BaseDao
    {
        //returns all food items in a list format
        public List<FoodItem> GetAllFoodItems()
        {
            string query = "SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, M.item_AmountNeeded, F.item_CourseType,F.item_MenuType FROM MENU_ITEM AS M, FOOD as F WHERE F.item_Id = M.item_Id";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTablesFood(ExecuteSelectQuery(query, parameters));
        }
        //returns an item of the specified id
        public FoodItem GetFoodItemById(int foodId) 
        {
            string query = "WITH ITEMS AS(SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, M.item_AmountNeeded, F.item_CourseType,F.item_MenuType FROM MENU_ITEM AS M, FOOD as F WHERE F.item_Id = M.item_Id)SELECT *FROM ITEMS WHERE item_Id = @FoodItemId"; ;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@FoodItemId", foodId);
            return ReadTablesFood(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        //updates information about the item that's passed to the method
        public void UpdateFoodItem(FoodItem food)
        {
            string query = "UPDATE MENU_ITEM SET item_Name = @FoodName, item_Price = @FoodPrice, item_Stock = @FoodStock, item_AmountNeeded =@FoodAmountNeeded WHERE item_Id = @FoodId; UPDATE FOOD SET item_CourseType = @FoodCourse, item_MenuType = @FoodMenuType WHERE item_Id = @FoodId";

            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@FoodName", food.Item_Name);
            sqlParameters[1] = new SqlParameter("@FoodMenuType", (int)food.Item_MenuType);
            sqlParameters[2] = new SqlParameter("@FoodPrice", food.Item_Price);
            sqlParameters[3] = new SqlParameter("@FoodStock", food.Item_Stock);
            sqlParameters[4] = new SqlParameter("@FoodId", food.Item_Id);
            sqlParameters[5] = new SqlParameter("@FoodCourse", (int)food.Item_CourseType);
            sqlParameters[6] = new SqlParameter("@FoodAmountNeeded", food.Item_AmountNeeded);

            ExecuteEditQuery(query, sqlParameters);
        }
        //inserts the item that's passed to the method into the database
        public void AddFood(FoodItem item)
        {
            string query = "INSERT INTO MENU_ITEM (item_Id, item_Name, Item_Stock, Item_Price, Item_AmountNeeded) VALUES (@ItemId, @ItemName, @ItemStock, @ItemPrice, @ItemAmountNeeded); INSERT INTO FOOD (item_Id, item_CourseType, item_MenuType) VALUES (@ItemId, @ItemCourse, @ItemMenu)";

            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@ItemName", item.Item_Name);
            sqlParameters[1] = new SqlParameter("@ItemMenu", (int)item.Item_MenuType);
            sqlParameters[2] = new SqlParameter("@ItemPrice", item.Item_Price);
            sqlParameters[3] = new SqlParameter("@ItemStock", item.Item_Stock);
            sqlParameters[4] = new SqlParameter("@ItemId", item.Item_Id);
            sqlParameters[5] = new SqlParameter("@ItemCourse", (int)item.Item_CourseType);
            sqlParameters[6] = new SqlParameter("@ItemAmountNeeded", item.Item_AmountNeeded);

            ExecuteEditQuery(query, sqlParameters);
        }
        //delets the item of the specified id
        public void DeleteFood(int Id)
        {
            string query = "DELETE FROM MENU_ITEM WHERE item_Id = @ItemId; DELETE FROM FOOD WHERE item_Id = @ItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemId", Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public int GetLastId()
        {
            string query = "select MAX(item_Id) as item_Id from MENU_ITEM";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReturnInt(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<FoodItem> ReadTablesFood(DataTable table)
        {
            List<FoodItem> list = new List<FoodItem>();

            foreach (DataRow dr in table.Rows)
            {
                FoodItem item = new FoodItem()
                {
                    Item_Id = (int)dr["item_Id"],
                    Item_Name = (string)dr["item_Name"],
                    Item_Price = (decimal)dr["item_Price"],
                    Item_Stock = (int)dr["item_Stock"],
                    Item_CourseType = (CourseType)dr["item_CourseType"],
                    Item_MenuType = (MenuType)dr["item_MenuType"],
                    Item_AmountNeeded = (int)dr["item_AmountNeeded"]
                };
                list.Add(item);
            }
            return list;
        }
        private int ReturnInt(DataTable dataTable)
        {
            int i = (int)dataTable.Rows[0]["item_Id"];

            return i;
        }
    }
}
