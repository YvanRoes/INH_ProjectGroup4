using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {
        List<MenuItem> _items = new List<MenuItem>();

        void AddItem(MenuItem item) => _items.Add(item);

        void RemoveItem(MenuItem item) => _items.Remove(item);

        public DateTime Placed { get; set; }
        public int TableNr { get; set; }
        public int OrderId { get; set; }


    }
}
