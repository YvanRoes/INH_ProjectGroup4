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
    public class OrderedItem : IOrderedItem, IMenuItem, IFoodItem, IDrinkItem, IOrder
    {
        public int ItemOrdered_Id { get; set; }

        public int ItemOrdered_Quantity { get; set; }

        public ItemOrderedStatus ItemOrdered_status { get; set; }
        public int Item_Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Item_Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Item_Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Item_Stock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CourseType Item_CourseType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DrinkType Item_DrinkType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Placed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
