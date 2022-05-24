﻿using DAL;
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

        public List<OrderedItem> GetAllOrders()
        {
            List<OrderedItem> orderedItems = orderedItemDao.GetAllOrders();
            return orderedItems;
        }


    }
}