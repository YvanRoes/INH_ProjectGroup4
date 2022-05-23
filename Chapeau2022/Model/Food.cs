namespace Model
{
    public enum CourseType
    {
        appetizer, main, dessert
    }
    public class Food
    {
        public CourseType courseType { get; set; }
    }
}
