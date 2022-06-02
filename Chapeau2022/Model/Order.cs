using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {
        int _Order_Id { get; set; }
        public int employee_Id { get; set; }
        public int table_Id { get; set; }
        public int status = 0;
        public List<OrderedItem> menuItems;


        public Order(int employee, int table)
        {
            menuItems = new List<OrderedItem>();
            employee_Id = employee;
            table_Id = table;
        }

        public int Order_Id { get { return _Order_Id; } set { _Order_Id = value; } }

        public void AddItem(MenuItem item, int Qty, string comment)
        {
            OrderedItem oI = new OrderedItem(item)
            {
                _itemOrder_id = _Order_Id,
                _itemOrdered_Qty = Qty,
                _itemOrdered_Comment = comment,
                _itemOrdered_Status = 0
            };
            menuItems.Add(oI);
        }

        public void RemoveItem(OrderedItem item) { menuItems.Remove(item); }

        public void Clear() { menuItems.Clear(); }
    }
}
