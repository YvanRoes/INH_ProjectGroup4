﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public int tableId { get; set; }
        public int Table_Nr { get; set; }

        public TableStatus tableOccupancy { get; set; }
    }
}
