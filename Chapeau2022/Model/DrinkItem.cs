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
    public class DrinkItem
    {
        public DrinkType Item_DrinkType { get; set; }
        public int Item_Id { get ; set; }
        public string Item_Name { get; set; }
        public decimal Item_Price { get; set; }
        public int Item_Stock { get; set; }
        //Amount needed by the restaurant per week
        public int Item_AmountNeeded { get; set; }
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
