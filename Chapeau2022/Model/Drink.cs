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

    public class Drink
    {
        public int itemId { get; set; }
        public DrinkType drinkType { get; set; }
    }
}
