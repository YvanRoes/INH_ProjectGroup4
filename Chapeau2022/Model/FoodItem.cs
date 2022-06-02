﻿namespace Model
{
    public enum CourseType
    {
        appetizer, main, dessert
    }
    public enum MenuType 
    { 
        lunch, dinner
    }
    public class FoodItem
    {
        public CourseType Item_CourseType { get; set; }
        public MenuType Item_MenuType { get; set; }
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public decimal Item_Price { get; set; }
        public int Item_Stock { get; set; }
        public int Item_AmountNeeded { get; set; }
        public string Status()
        {
            if (Item_Stock < Item_AmountNeeded)
            {
                return "Restock";
            }
            else if (Item_Stock-Item_AmountNeeded < 10)
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
