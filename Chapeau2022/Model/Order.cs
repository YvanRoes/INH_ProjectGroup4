using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {
        List<OrderedItem> _items;
        DateTime _timeTaken;
        int _employee_Id;
        int _table_Id;

        public List<OrderedItem> Items { get { return _items; } }
        public DateTime TimeTaken { get { return _timeTaken; } }
        public int EmployeeId { get { return _employee_Id; } }
        public int table_Id { get { return _table_Id; } }


        public Order(List<OrderedItem> items, int employee, int table)
        {
            _items = items;
            _timeTaken = DateTime.Now;
            _employee_Id = employee;
            _table_Id = table;
        }

        
    }
}
