using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public decimal Price { get; set; }
        public decimal Tip { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeID { get; set; }
        public int OrderNr { get; set; }
        public BillMethod Method { get; set; }

        public Bill(decimal price, decimal tip, DateTime dateTime, int employeeID, int orderNr, BillMethod method)
        {
            Tip = tip;
            Price = price;
            DateTime = dateTime;
            EmployeeID = employeeID;
            OrderNr = orderNr;
            Method = method;
        }
    }
}