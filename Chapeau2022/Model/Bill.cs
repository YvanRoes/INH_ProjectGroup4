using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum PayStatus
    {
       notpaid,paid
    }
    public class Bill:OrderedItem
    {
        public decimal Tip { get; set; }
        public decimal Total{ get; set; }
        public decimal High_Vat { get; set; }
        public decimal Low_Vat { get; set; }
        public decimal Total_Vat { get; set; }
        public BillMethod Method { get; set; }
        public string Comment {get;set;}
        public Bill()
        {

        }
        public Bill(decimal total, decimal tip,string comment,BillMethod billMethod)
        {
            
            Total = total;
            Tip = tip;
            Comment = comment;
            Method = billMethod;
        }


    }
}