using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace Logic
{
    public class FoodService
    {
        private FoodDao _foodDao;

        public FoodService() => _foodDao = new FoodDao();

        public List<FoodItem> GetAllItems()=> _foodDao.GetAllItems();
    }
}
