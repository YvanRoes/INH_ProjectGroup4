using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class KitchenService
    {
        KitchenDao kitchenDao;

        public KitchenService()
        {
            kitchenDao = new KitchenDao();
        }

        public List<KitchenItem> GetAllRunningOrders()
        {
            List<KitchenItem> kitchenItems = kitchenDao.GetAllRunningOrders();
            return kitchenItems;
        }

        public List<KitchenItem> GetAllFinishedOrders()
        {
            List<KitchenItem> kitchenItems = kitchenDao.GetAllFinishedOrders();
            return kitchenItems;
        }
    }
}
