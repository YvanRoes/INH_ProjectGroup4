namespace Model
{
    public enum CourseType
    {
        appetizer, main, dessert
    }
    public class FoodItem : IFoodItem
    {
        public CourseType Item_CourseType { get; set; }
    }
}
