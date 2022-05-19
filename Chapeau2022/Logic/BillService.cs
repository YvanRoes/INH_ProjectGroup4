using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class BillService
    {
        private BillDao billdao = new BillDao();

        public void BillRecord(Bill bill)
        {
            billdao.BillRecord(bill);
        }
    }
}
