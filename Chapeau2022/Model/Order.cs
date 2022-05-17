﻿using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {
        List<MenuItem> _items = new List<MenuItem>();

        void AddItem(MenuItem item) => _items.Add(item);

        void RemoveItem(MenuItem item) => _items.Remove(item);
    }
}