using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KitchenItem
    {
        public int TableNr { get; set; }
        public DateTime Placed { get; set; }
        public int FoodQuantity { get; set; }
        public CourseType CourseType { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public Status FoodStatus { get; set; }


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
