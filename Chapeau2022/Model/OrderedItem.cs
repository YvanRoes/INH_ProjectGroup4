using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum ItemOrderedStatus
    {
        ready, notReady
    }
    public class OrderedItem : MenuItem
    {
        public int ItemOrdered_Id { get; set; }
        public int ItemOrdered_Quantity { get; set; }
        public ItemOrderedStatus ItemOrdered_status { get; set; }
        public CourseType Item_CourseType { get; set; }
        public DrinkType Item_DrinkType { get; set; }
        public DateTime Placed { get; set; }
        public string ItemOrderedDescription { get; set; }
        public DrinkItem Item_DrinkItem { get; set; }
        public int TableNr { get; set; }
        public int Order_Id { get; set; }
        public MenuType Item_MenuType { get; set; }


    }
}
