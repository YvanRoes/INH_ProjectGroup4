using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum DrinkType
    {
        alcoholic, nonAlcoholic
    }

    public class DrinkItem : IDrinkItem, IMenuItem
    {
        public DrinkType Item_DrinkType { get; set; }
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public decimal Item_Price { get; set; }
        public int Item_Stock { get; set; }
    }
}
