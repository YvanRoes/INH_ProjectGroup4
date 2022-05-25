using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kitchen
    {
        public int TableNr { get; set; }
        public DateTime Placed { get; set; }
        public int Quantity { get; set; }
        public CourseType CourseType { get; set; }
        public string FoodOrder { get; set; }

        //public Kitchen(int tableNr, DateTime placed, int quantity, CourseType coursetype, string drinkOrder)
        //{
        //    TableNr = tableNr;
        //    Placed = placed;
        //    Quantity = quantity;
        //    CourseType = coursetype;
        //    DrinkOrder = drinkOrder;
        //}
    }
}
