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
        public List<OrderedItem> GetAllOrderedItems()
        {
            return billdao.GetAllOrderedItems();
        }
        public void UpdatePaymentStatus(int orderId)
        {
            billdao.UpdatePaymentStatus(orderId);
        }
    }
}
