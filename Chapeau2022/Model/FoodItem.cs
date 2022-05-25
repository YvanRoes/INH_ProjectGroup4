namespace Model
{
    public enum CourseType
    {
        appetizer, main, dessert
    }
    public class FoodItem : MenuItem
    {
        public CourseType Item_CourseType { get; set; }
    }
}
