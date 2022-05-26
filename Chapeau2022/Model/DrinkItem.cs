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

    public class DrinkItem : IDrinkItem, IMenuItem
    {
        public DrinkType Item_DrinkType { get; set; }
        public int Item_Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Item_Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Item_Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Item_Stock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
