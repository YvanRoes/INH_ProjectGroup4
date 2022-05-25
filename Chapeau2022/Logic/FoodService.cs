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
    }
}
