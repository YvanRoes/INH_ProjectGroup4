using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DrinkItem : MenuItem
    {
        public DrinkType Item_DrinkType { get; set; }
        //Amount needed by the restaurant per week
        public string Item_Status;

        public DrinkItem() 
        {
            Item_Status = Status();
        }

        public string Status()
        {
            if (Item_Stock < Item_AmountNeeded)
            {
                return "Restock";
            }
            else if ((Item_Stock > Item_AmountNeeded) && (Math.Abs(Item_Stock-Item_AmountNeeded) < 10))
            {
                return "Low";
            }
            else
            {
                return "Full";
            }
        }
    }
}
