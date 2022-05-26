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
        public OrderService()
        {
             _orderDao = new OrderDao();
        }

        void SendSingleOrderToDatabase(Order order)
        {
            _orderDao.SendSingleOrder(order);
        }
    }
}
