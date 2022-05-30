using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class DrinkService
    {
        DrinkDao drinkDao;
        public DrinkService() => drinkDao = new DrinkDao();

        public List<DrinkItem> GetAllDrinkItems() => drinkDao.GetAllDrinks();

        public DrinkItem GetDrinkItemById(int Id) => drinkDao.GetDrinkItemById(Id);

        public  void UpdateDrink(DrinkItem drink) => drinkDao.UpdateDrink(drink);

        public void DeleteDrink(int Id) => drinkDao.DeleteDrink(Id);

        public void AddDrink(DrinkItem drink) => drinkDao.AddDrink(drink);
    }
}
