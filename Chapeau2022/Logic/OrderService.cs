using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class OrderService
    {
        OrderDao _orderDao;
        static OrderService _instance;
        private OrderService()
        {
            _orderDao = new OrderDao();
        }

        public static OrderService GetInstance()
        {
            if (_instance == null)
                _instance = new OrderService();
            return _instance;
        }

        public int GetNewOrderId() => _orderDao.GetOrderNumbers().Max() + 1;

        public void SendOrderToDatabase(Order order) => _orderDao.MakeNewOrder(order);

    }
}
