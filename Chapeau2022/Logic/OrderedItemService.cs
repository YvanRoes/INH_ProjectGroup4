using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class OrderedItemService
    {
        OrderedItemDao orderedItemDao;

        public OrderedItemService()
        {
            orderedItemDao = new OrderedItemDao();
        }

        public List<OrderedItem> GetAllRunningFoodOrders()
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllRunningFoodOrders();
            return orderedItems;
        }

        public List<OrderedItem> GetAllFinishedFoodOrders()
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllFinishedFoodOrders();
            return orderedItems;
        }

        public List<OrderedItem> GetAllRunningDrinkOrders()
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllRunningDrinkOrders();
            return orderedItems;
        }

        public List<OrderedItem> GetAllFinishedDrinkOrders()
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllFinishedDrinkOrders();
            return orderedItems;
        }


    }
}
