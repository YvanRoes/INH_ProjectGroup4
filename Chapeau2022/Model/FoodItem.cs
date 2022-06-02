namespace Model
{
    public enum CourseType
    {
        appetizer, main, dessert
    }
    public enum MenuType 
    { 
        lunch, dinner
    }
    public class FoodItem : MenuItem
    {
        public CourseType Item_CourseType { get; set; }
        public MenuType Item_MenuType { get; set; }
    }
}
