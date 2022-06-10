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

        public List<OrderedItem> GetAllFoodOrders(ItemOrderedStatus itemOrderedStatus)
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllFoodOrders(itemOrderedStatus);
            return orderedItems;
        }

        public List<OrderedItem> GetAllDrinkOrders(ItemOrderedStatus itemOrderedStatus)
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllDrinkOrders(itemOrderedStatus);
            return orderedItems;
        }

        public void UpdateItemOrderedStatus(OrderedItem orderedItem)
        {
            orderedItemDao.UpdateItemOrderedStatus(orderedItem);
        }

        //Md Tasnim Kabir 
        public List<OrderedItem> GetAllOrderedItems()
        {
            
            return orderedItemDao.GetAllOrderedItems();
        }
    }
}
