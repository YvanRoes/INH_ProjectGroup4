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

    public class DrinkItem : IDrinkItem
    {
        public DrinkType Item_DrinkType { get; set; }
    }
}
