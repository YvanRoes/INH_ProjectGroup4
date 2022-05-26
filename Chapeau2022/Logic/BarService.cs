using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BarService
    {
        BarDao barDao;

        public BarService()
        {
            barDao = new BarDao();
        }

        public List<Bar> GetAllRunningOrders()
        {
            List<Bar> bars = barDao.GetAllRunningOrders();
            return bars;
        }

        public List<Bar> GetAllFinishedOrders()
        {
            List<Bar> bars = barDao.GetAllFinishedOrders();
            return bars;
        }
    }
}
