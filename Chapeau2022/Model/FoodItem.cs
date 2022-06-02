namespace Model
{
    public enum CourseType { Appetizer, Main, Dessert }

    public enum MenuType { Lunch, Dinner }

    public class FoodItem : MenuItem
    {
        public CourseType Item_CourseType { get; set; }

        public MenuType Item_MenuType { get; set; }
    }
}
