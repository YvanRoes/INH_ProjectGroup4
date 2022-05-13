using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace Logic
{
    public class OrderService
    {
        private OrderDao _orderDao;

        public OrderService() => _orderDao = new OrderDao();

        public List<MenuItem> GetAllItems()=> _orderDao.GetAllItems();
    }
}
