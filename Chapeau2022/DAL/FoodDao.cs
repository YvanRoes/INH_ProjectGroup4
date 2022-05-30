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
    public class FoodDao : BaseDao
    {
        public List<FoodItem> GetAllFoodItems()
        {
            string query = "SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, F.item_CourseType,F.item_MenuType FROM MENU_ITEM AS M, FOOD as F WHERE F.item_Id = M.item_Id";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTablesFood(ExecuteSelectQuery(query, parameters));
        }
        //returns an item of the id that is passed to the method
        public FoodItem GetFoodItemById(int foodId) 
        {
            string query = "WITH ITEMS AS(SELECT M.item_Id, M.item_Name, M.item_Price, M.item_Stock, F.item_CourseType,F.item_MenuType FROM MENU_ITEM AS M, FOOD as F WHERE F.item_Id = M.item_Id)SELECT *FROM ITEMS WHERE item_Id = @FoodItemId"; ;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@FoodItemId", foodId);
            return ReadTablesFood(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        public void UpdateFoodItem(FoodItem food)
        {
            string query = "UPDATE MENU_ITEM SET item_Name = @FoodName, item_Price = @FoodPrice, item_Stock = @FoodStock WHERE item_Id = @FoodId; UPDATE FOOD SET item_CourseType = @FoodCourse, item_MenuType = @FoodMenuType WHERE item_Id = @FoodId";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@FoodName", food.Item_Name);
            sqlParameters[1] = new SqlParameter("@FoodMenuType", (int)food.Item_MenuType);
            sqlParameters[2] = new SqlParameter("@FoodPrice", food.Item_Price);
            sqlParameters[3] = new SqlParameter("@FoodStock", food.Item_Stock);
            sqlParameters[4] = new SqlParameter("@FoodId", food.Item_Id);
            sqlParameters[5] = new SqlParameter("@FoodCourse", (int)food.Item_CourseType);

            ExecuteEditQuery(query, sqlParameters);
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
                    Item_MenuType = (MenuType)dr["item_MenuType"]
                };
                list.Add(item);
            }
            return list;
        }
    }
}
