using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class StockService
    {
        StockDao _stockDao;

        public StockService() => new StockDao();

        public List<DrinkItem> GetAllDrinks() => _stockDao.GetAllDrinkItems();

        public List<FoodItem> GetAllFoodItems() => _stockDao.GetAllFoodItems();
    }
}
