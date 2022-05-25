using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bar
    {
        public int TableNr { get; set; }
        public DateTime Placed { get; set; }
        public int Quantity { get; set; }
        public string DrinkOrder { get; set; }
        //public Bar(int tableNr, DateTime placed, int quantity, string drinkOrder)
        //{
        //    TableNr = tableNr;
        //    Placed = placed;
        //    Quantity = quantity;
        //    DrinkOrder = drinkOrder;
        //}
    }
}
