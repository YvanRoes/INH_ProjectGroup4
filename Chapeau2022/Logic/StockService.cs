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

        public StockService() => _stockDao = new StockDao();

        public List<Drink> GetAllDrinks() => _stockDao.GetAllDrinkItems();

        public List<Food> GetAllFoodItems() => _stockDao.GetAllFoodItems();
    }
}
