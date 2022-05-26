namespace Model
{
    public enum CourseType
    {
        appetizer, main, dessert
    }
    public class FoodItem : IFoodItem, IMenuItem
    {
        public CourseType Item_CourseType { get; set; }
        public int Item_Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Item_Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public decimal Item_Price { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Item_Stock { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
