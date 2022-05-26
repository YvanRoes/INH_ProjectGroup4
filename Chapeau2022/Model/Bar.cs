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
        public int DrinkQuantity { get; set; }
        public DrinkType DrinkType { get; set; } 
        public string DrinkName { get; set; }
        public string DrinkDescription { get; set; }
        public ItemOrderedStatus DrinkStatus { get; set; }
        //public Bar(int tableNr, DateTime placed, int quantity, string drinkOrder)
        //{
        //    TableNr = tableNr;
        //    Placed = placed;
        //    Quantity = quantity;
        //    DrinkOrder = drinkOrder;
        //}
    }
}
