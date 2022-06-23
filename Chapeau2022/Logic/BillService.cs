using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BillService
    {
        private BillDao billdao = new BillDao();

        public void InsertBill(Bill bill)
        {
            billdao.InsertBill(bill);
        }
        public void UpdatePaymentStatus(int orderId)
        {
            billdao.UpdatePaymentStatus(orderId);
        }
        public List<Bill> GetAllTables()
        {

            return billdao.GetAllTables();
        }
    }
}