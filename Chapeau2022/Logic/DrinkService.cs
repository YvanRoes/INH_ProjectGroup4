using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    internal class DrinkService
    {
        DrinkDao drinkDao;

        public DrinkService() => new DrinkDao();

        public List<DrinkItem> GetAllDrinks() => drinkDao.GetAllItems();
    }
}
