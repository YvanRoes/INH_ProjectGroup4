using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class FoodService
    {
        FoodDao _foodDao;

        public FoodService() => _foodDao = new FoodDao();

        public List<FoodItem> GetAllFoodItems() => _foodDao.GetAllFoodItems();

        public FoodItem GetFoodItemById(int id) => _foodDao.GetFoodItemById(id);

        public void UpdateFoodItem(FoodItem item) => _foodDao.UpdateFoodItem(item);

        public void AddItem(FoodItem item) => _foodDao.AddFood(item);

        public void DeleteItem(int id) => _foodDao.DeleteFood(id);

        public int GetLastId() => _foodDao.GetLastId();
    }
}
