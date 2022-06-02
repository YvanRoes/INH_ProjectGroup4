using System;

namespace Model
{
    public enum CourseType { Appetizer, Main, Dessert }

    public enum MenuType { Lunch, Dinner }

    public class FoodItem : MenuItem
    {
        public CourseType Item_CourseType { get; set; }

        public MenuType Item_MenuType { get; set; }

        public string Status()
        {
            if (Item_Stock < Item_AmountNeeded)
            {
                return "Restock";
            }
            else if ((Item_Stock > Item_AmountNeeded) && (Math.Abs(Item_Stock - Item_AmountNeeded) < 10))
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
