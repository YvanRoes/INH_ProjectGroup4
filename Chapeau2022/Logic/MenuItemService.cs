using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class MenuItemService
    {
        MenuItemDao _menuItemDao = new MenuItemDao();
        private static MenuItemService _instance;

        private MenuItemService() => _menuItemDao.GetAllMenuItems();

        public static MenuItemService GetInstance()
        {
            if (_instance == null)
                _instance = new MenuItemService();
            return _instance;
        }

        public List<MenuItem> GetAllMenuItems() => _menuItemDao.GetAllMenuItems().OrderBy(i => i.Item_Name).ToList();

        public void UpdateMenuItemStocks(Order order) => _menuItemDao.UpdateMenuItemStocks(order);
    }
}
